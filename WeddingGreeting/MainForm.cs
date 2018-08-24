﻿using EAlbums;
using ee.Models;
using ee.Utility.Npoi;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
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
        private static bool disableSpeech = false;

        private VideoPlayer player;
        EgoDevil.Utilities.UI.TrackBarEx trackBarThreshold;
        public MainForm()
        {
            InitializeComponent();



            trackBarThreshold = new EgoDevil.Utilities.UI.TrackBarEx()
            {
                Height = 24,
                Value = (int)GlobalConfig.Configurations.Threshold,
            };

            trackBarThreshold.LostFocus += trackBarThreshold_LostFocus;

            var tsControlHost = new ToolStripControlHost(trackBarThreshold)
            {
                Width = 140,
                AutoSize = false
            };

            this.tsmiSetThreshold.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsControlHost});


           



            this.BackColor = Color.Black;
            ResizeControlls();
            player = new VideoPlayer(this.picbVideoContainer);
            player.FaceRecognised += Player_FaceRecognised;
            player.NotRecognisedLongTime += Player_NotRecognisedLongTime;







            var devs = player?.GetDevices()?.Select(x => new KeyValuePair<string, string>(x.Key, x.Value))?.ToArray();
            cbbVideoSource.DisplayMember = "Value";   // Text，即显式的文本
            cbbVideoSource.ValueMember = "Key";    // Value，即实际的值
            cbbVideoSource.DataSource = devs;
            cbbVideoSource.SelectedIndex = 0;        //  设置为默认选中第一个

            var tsControlHost2 = new ToolStripControlHost(this.cbbVideoSource)
            {
                Width = 140,
                AutoSize = true
            };

            this.tsmiVideoSource.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsControlHost2});







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
                        Attend(target);
                        Speech(target);
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
        private void Attend(GuestInfo target)
        {
            target.IsAttend = true;
            target.AttendTime = DateTime.Now;
            GlobalConfig.SaveGuests();
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
        private void Speech(GuestInfo target)
        {
            if (GlobalConfig.Configurations.IsSpeechable)
            {
                var message = "";
                try
                {
                    message = string.Format(GlobalConfig.Configurations.GreetFormat, target.Name, target.Labels, target.TableNo);
                }
                catch (Exception)
                {

                    message = $"欢迎光临,{target.Name},{target.Labels}";
                }
                if (!disableSpeech)
                {
                    new Thread(() =>
                    {
                        disableSpeech = true;
                        SpeechProvider.Speech(message);
                        disableSpeech = false;

                    }).Start();
                }


            }
        }

        private void Clear()
        {

        }


        public static bool NumberDotTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ctl = (Control)sender;
            //允许输入数字、小数点、删除键和负号
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != (char)('.') && e.KeyChar != (char)('-'))
            {
                return true;
            }
            if (e.KeyChar == (char)('-'))
            {
                if (ctl.Text != "")
                {
                    return true;
                }
            }
            //小数点只能输入一次
            if (e.KeyChar == (char)('.') && ctl.Text.IndexOf('.') != -1)
            {
                return true;
            }
            //第一位不能为小数点
            if (e.KeyChar == (char)('.') && ctl.Text == "")
            {
                return true;
            }
            //第一位是0，第二位必须为小数点
            if (e.KeyChar != (char)('.') && e.KeyChar != 8 && ctl.Text == "0")
            {
                return true;
            }
            //第一位是负号，第二位不能为小数点
            if (ctl.Text == "-" && e.KeyChar == (char)('.'))
            {
                return true;
            }

            return false;
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
        private void tscbbVideoSource_Click(object sender, EventArgs e)
        {

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
        private void tsmiGuestManagement_Click(object sender, EventArgs e)
        {
            var frm = new FrmGuestManagement();
            frm.ShowDialog(this);
            RefreshGuests();
        }
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiImportGuest_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "(Excel文件)|*.xls;*.xlsx;",
                Multiselect = false
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                NpoiHelper npoi = new NpoiHelper(ofd.FileName);
                var dt = npoi.ExcelToDataTable("", true, out List<PicturesInfo> pictures);
                var jsonValue = JsonConvert.SerializeObject(dt);
                JsonSerializerSettings jsetting = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };

                var objects = JsonConvert.DeserializeObject<List<EnrollmentModel>>(jsonValue, jsetting);

                for (int i = 0; i < objects.Count; i++)
                {
                    objects[i].相片 = pictures[i].PictureData;
                    var item = objects[i];
                    var img = new Bitmap(item.FaceImage);
                    var imageFileName = Path.Combine($"GuestImages\\{item.ID}.jpg");
                    if (File.Exists(imageFileName))
                    {
                        File.Delete(imageFileName);
                    }
                    img.Save(imageFileName);
                    img.Dispose();
                    var info = new GuestInfo()
                    {
                        Id = item.ID,
                        Name = item.Name,
                        Gender = item.Gender,
                        GuestType = item.GuestType,
                        Entourage = item.Entourage,
                        Labels = item.Labels,
                        ImagePath = imageFileName,
                        TableNo = item.TableNo,
                        CreateTime = DateTime.Now,
                    };
                    GuestManagement.SaveOrUpdate(info);


                }
                RefreshGuests();
                MessageBox.Show("导入完成");
            }
        }

        private void trackBarThreshold_LostFocus(object sender, EventArgs e)
        {

            if (GlobalConfig.Configurations.Threshold != trackBarThreshold.Value && trackBarThreshold.Value > 0d)
            {
                GlobalConfig.Configurations.Threshold = trackBarThreshold.Value;
                GlobalConfig.SaveConfig();
            }
        }

        private void cbbVideoSource_Click(object sender, EventArgs e)
        {
           
        }

        private void cbbVideoSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (player?.IsPlaying ?? false)
            {
                player?.Stop();
                player?.SetVideoSource(cbbVideoSource.SelectedValue.ToString());
                player?.Play();
            }
            else
            {
                player?.SetVideoSource(cbbVideoSource.SelectedValue.ToString());
            }
        }
    }
}