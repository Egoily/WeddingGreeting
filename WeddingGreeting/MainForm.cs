using EAlbums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WeddingGreeting.Forms;

namespace WeddingGreeting
{
    public partial class MainForm : Form
    {


        private static bool isProcessing = false;
        private static string currentUserId = "";
        private static int sameUserCount = 0;
        private static int maxSameUserCont = 100;



        private VideoPlayer player;


        public MainForm()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            ResizeControlls();
            player = new VideoPlayer(this.picbVideoContainer);
            player.FaceRecognised += Player_FaceRecognised;
            player.NotRecognisedLongTime += Player_NotRecognisedLongTime;


            guestViewer.Loading();
            hostViewer.Loading();

            RefreshGuests();
        }

        private void Player_FaceRecognised(System.Drawing.Bitmap image, string userId, string userInfo)
        {
            if (isProcessing) return;
            isProcessing = true;
            try
            {
                if (currentUserId != userId)
                {

                    currentUserId = userId;
                    guestViewer.InvokeIfRequired(c => c.ShowItem(currentUserId));

                    var target = GlobalConfig.Guests.FirstOrDefault(x => x.Id == userId);
                    if (target != null)
                    {
                        target.IsAttend = true;
                        target.AttendTime = DateTime.Now;
                        GlobalConfig.SaveGuests();

                        SetAttendance(GlobalConfig.Guests.Count(x => x.IsAttend));
                    }
                }
                else
                {
                    sameUserCount++;
                    if (sameUserCount > maxSameUserCont)
                    {
                        //guestViewer.InvokeIfRequired(c => c.ShowItem(""));
                        currentUserId = "";
                        sameUserCount = 0;
                    }
                }
                guestViewer.InvokeIfRequired(c => c.ShowItem(currentUserId));

            }
            catch (System.Exception ex)
            {

            }
            isProcessing = false;
        }
        private void Player_NotRecognisedLongTime()
        {
            Clear();
            currentUserId = "";
            sameUserCount = 0;
            guestViewer.InvokeIfRequired(c => c.ShowItem(""));
        }
        private void ResizeControlls()
        {
            picbVideoContainer.Location = new Point(0, menuStrip.Height);
            picbVideoContainer.Size = new Size(128, 96);
            guestViewer.Location = new Point(0, menuStrip.Height);
            guestViewer.Size = new Size(Width, (Height - menuStrip.Height) / 2 - 1);
            guestViewer.ResetOrginalCenter();
            hostViewer.Location = new Point(0, menuStrip.Height + (Height - menuStrip.Height) / 2 + 2);
            hostViewer.Size = new Size(Width, (Height - menuStrip.Height) / 2 - 1);
            hostViewer.ResetOrginalCenter();

            dmAttendance.Location = new Point(this.Width - dmAttendance.Width, menuStrip.Height);

        }
        private void StartVideo()
        {
            player?.Play();
        }
        private void StopVideo()
        {
            player?.Stop();
            picbVideoContainer.Image = null;
            Clear();
        }
        private void RefreshGuests()
        {
            var thumbElements = new List<ThumbElement>();
            foreach (var item in GlobalConfig.Guests.Where(x => x.ImagePath != null && x.ImagePath != ""))
            {
                thumbElements.Add(new ThumbElement()
                {
                    Name = item.Id,
                    FullPath = item.ImagePath,
                    Description = $"姓名: {item.Name} \n身份: {item.Labels}\n桌号: {item.TableNo} ",
                    IsSelected = item.IsAttend,
                });
            }
            guestViewer.LoadingByThumbElements(thumbElements);

            SetAttendance(GlobalConfig.Guests.Count(x => x.IsAttend));
        }
        private void SetAttendance(int count)
        {
            if (count >= 0)
            {
                dmAttendance.Value = count;
            }
            else
            {
                dmAttendance.Value += 1;
            }
        }
        private void Clear()
        {

        }






        private void MainForm_Load(object sender, EventArgs e)
        {
            new MoveControl(this.picbVideoContainer);
        }
        private void MainForm_Resize(object sender, System.EventArgs e)
        {
            ResizeControlls();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y <= 20)
            {
                menuStrip.Visible = true;
            }
            else
            {
                menuStrip.Visible = false;
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            player?.Stop();
            player?.Dispose();
        }

        private void menuStrip_MouseEnter(object sender, EventArgs e)
        {
            menuStrip.Visible = true;
        }

        private void menuStrip_MouseLeave(object sender, EventArgs e)
        {
            menuStrip.Visible = false;
        }

        private void tsmiRegister_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmRegister();
            frm.ShowDialog(this);
            RefreshGuests();
        }
        private void tsmiControlVideo_Click(object sender, EventArgs e)
        {
            if (tsmiControlVideo.Text == "开始")
            {
                StartVideo();
                tsmiControlVideo.Text = "停止";
            }
            else
            {
                StopVideo();
                tsmiControlVideo.Text = "开始";
            }
        }

        private void tsmiRefresh_Click(object sender, System.EventArgs e)
        {
            RefreshGuests();
        }
        private void tsmiConfigVideoWindow_Click(object sender, EventArgs e)
        {
            var frm = new FrmConfigVideoWindow(this.picbVideoContainer);
            frm.Show(this);
        }
        private void tsmiStatistics_Click(object sender, EventArgs e)
        {
            var frm = new FrmStatistics();
            frm.ShowDialog(this);
        }
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}