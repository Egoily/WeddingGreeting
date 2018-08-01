using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using WeddingGreeting.Forms;

namespace WeddingGreeting
{
    public partial class MainForm : Form
    {
        private VideoPlayer player;
        public MainForm()
        {
            InitializeComponent();
            player = new VideoPlayer(this.picbVideoContainer);
            player.FaceRecognised += Player_FaceRecognised;
            player.NotRecognisedLongTime += Player_NotRecognisedLongTime;
            imageViewer.Loading();

        }

        private static bool isProcessing = false;
        private void Player_FaceRecognised(System.Drawing.Bitmap image, string userId, string userInfo)
        {
            if (isProcessing) return;
            isProcessing = true;
            try
            {


                picbCapturedFace.Image = new Bitmap(image);
                if (picbRecognisedFace.Tag == null
                    || (picbRecognisedFace.Tag != null && picbRecognisedFace.Tag.ToString().ToLower() != userId.ToLower()))
                {
                    picbRecognisedFace.Image = GetFaceImageByUserId(userId);
                    picbRecognisedFace.Tag = userId;
                }
                rtbMessage.InvokeIfRequired(c => c.Text = userInfo);

                var imageFileName = $"Attend\\{userId}.jpg";

                if (File.Exists(imageFileName))
                    File.Delete(imageFileName);
                var img = (Bitmap)image.Clone();
                img.Save(imageFileName, ImageFormat.Jpeg);
                img.Dispose();
            }
            catch (System.Exception ex)
            {

            }
            isProcessing = false;
        }
        private void Player_NotRecognisedLongTime()
        {
            Clear();
        }

        private Bitmap GetFaceImageByUserId(string userId)
        {
            try
            {

                var image = Bitmap.FromFile($"Images\\{userId}.jpg");
                if (image != null)
                {
                    var img = new Bitmap(image);
                    image.Dispose();
                    return img;
                }
            }
            catch (System.Exception)
            {

            }
            return null;
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            player?.Stop();
            player?.Dispose();
        }

        private void tsmiRegister_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmRegister();
            frm.ShowDialog(this);
        }

        private void tsmiPlayVideo_Click(object sender, System.EventArgs e)
        {
            player?.Play();
        }

        private void tsmiStopVideo_Click(object sender, System.EventArgs e)
        {
            player?.Stop();
            picbVideoContainer.Image = null;
            Clear();
        }

        private void Clear()
        {

            picbCapturedFace.Image = null;
            picbRecognisedFace.Image = null;
            picbRecognisedFace.Tag = null;

            rtbMessage.InvokeIfRequired(c => c.Clear());
        }
    }
}