using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeddingGreeting.Forms
{
    public partial class FrmVideoSnap : Form
    {
        private VideoPlayer player;

        public DialogResult DlgResult { get; set; }
        public Bitmap Image { get; set; }
        public FrmVideoSnap()
        {
            InitializeComponent();
            InitPlayer();
        }

        private void InitPlayer()
        {
            player = new VideoPlayer(this.picbVideoContainer);
            player.Play();
        }
        private List<Rectangle> CheckFaces(Bitmap image, out Bitmap maxFaceImage)
        {
            return ee.Utility.OpenCv.FaceHandler.CheckFaces(ref image, out maxFaceImage);
        }

        private void DrawFace(ref Bitmap image, List<Rectangle> rects)
        {
            var rectList = ee.Utility.OpenCv.FaceHandler.ConvertFaceRect(rects, image.Width, image.Height);
            ee.Utility.OpenCv.FaceHandler.DrawFacesRect(ref image, rectList, 200, 200, 1);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Image = null;
            DlgResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSnap_Click(object sender, EventArgs e)
        {
            btnSnap.Enabled = false;
            if (btnSnap.Text == "拍照")
            {
                var image = new Bitmap(picbVideoContainer.Image);
                player.Pause();
                var rects = CheckFaces(image, out Bitmap maxFaceImage);
                DrawFace(ref image, rects);

                Bitmap old = (Bitmap)this.picbVideoContainer.Image;
                this.picbVideoContainer.Image = new Bitmap(image);
                old?.Dispose();

                Image = maxFaceImage;
                btnSnap.Text = "重拍";
            }
            else if (btnSnap.Text == "重拍")
            {
                player.Play();
                btnSnap.Text = "拍照";
            }
            btnSnap.Enabled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DlgResult = DialogResult.OK;
            this.Close();
        }

        private void FrmVideoSnap_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Dispose();
        }
    }
}
