using System;
using System.Drawing;
using System.Windows.Forms;
using ee.Models;
using EgoDevil.Utilities.UI.MessageForm;

namespace WeddingGreeting.UserControls
{
    public partial class GuestInfoCtrl : UserControl
    {


        private string currentImagePath;

        private GuestInfo information;
        public GuestInfo Information
        {
            get
            {
                information = new GuestInfo()
                {
                    Id = txtID.Text.Trim(),
                    Name = txtName.Text,
                    Gender = cbbGender.SelectedIndex,
                    GuestType = cbbGuestType.SelectedIndex,
                    Labels = txtLabels.Text,
                    TableNo = txtTableNo.Text,
                    SeatNo = txtSeatNo.Text,
                    ImagePath = currentImagePath,
                    Entourage = txtEntourage.Text ?? "",
                    CreateTime = DateTime.Now,
                };
                return information;
            }
            set
            {
                information = value;
                if (information != null)
                {
                    txtID.ReadOnly = true;
                    txtID.Text = information.Id;
                    txtName.Text = information.Name;
                    cbbGender.SelectedIndex = information.Gender;
                    cbbGuestType.SelectedIndex = information.GuestType;
                    txtLabels.Text = information.Labels;
                    txtTableNo.Text = information.TableNo;

                    txtEntourage.Text = information.Entourage;


                    currentImagePath = information.ImagePath;

                    if (!string.IsNullOrEmpty(currentImagePath))
                    {
                        var img = Bitmap.FromFile(currentImagePath);
                        picbFacePicture.Image = new Bitmap(img);
                        img.Dispose();
                    }

                }
                else
                {
                    txtID.ReadOnly = false;
                    cbbGender.SelectedIndex = 0;
                    cbbGuestType.SelectedIndex = 0;
                    txtID.Text = string.Empty;
                    txtName.Text = string.Empty;
                    txtLabels.Text = string.Empty;
                    txtTableNo.Text = string.Empty;
                    txtEntourage.Text = string.Empty;

                    picbFacePicture.Image = null;
                }

            }
        }


        public GuestInfoCtrl()
        {
            InitializeComponent();
        }


        public bool Validation()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtName.Focus();
                MsgForm.Show("请输入姓名");
                return false;
            }
            if (string.IsNullOrEmpty(txtLabels.Text))
            {
                txtLabels.Focus();
                MsgForm.Show("请输入标签");
                return false;
            }
            if (string.IsNullOrEmpty(txtTableNo.Text))
            {
                txtTableNo.Focus();
                MsgForm.Show("请输入桌号");
                return false;
            }
            if (picbFacePicture.Image == null)
            {
                picbFacePicture.Focus();
                MsgForm.Show("请选择相片");
                return false;

            }
            return true;
        }

        public GuestInfo GetInformation()
        {
            return new GuestInfo()
            {
                Id = txtID.Text.Trim(),
                Name = txtName.Text,
                Gender = cbbGender.SelectedIndex,
                GuestType = cbbGuestType.SelectedIndex,
                Labels = txtLabels.Text,
                TableNo = txtTableNo.Text,
                SeatNo = txtSeatNo.Text,
                ImagePath = currentImagePath,
                Entourage = txtEntourage.Text ?? "",
                CreateTime = DateTime.Now,
            };
        }

        private void GuestInfoCtrl_Load(object sender, EventArgs e)
        {
            cbbGender.SelectedIndex = 0;
            cbbGuestType.SelectedIndex = 0;
        }
        private void picbFacePicture_DoubleClick(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "(*.jpg,*.png,*.jpeg,*.bmp)|*.jpg;*.png;*.jpeg;*.bmp",
                Multiselect = false
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                currentImagePath = ofd.FileName;
                var image = Bitmap.FromFile(ofd.FileName);
                if (image != null)
                {
                    picbFacePicture.Image = new Bitmap(image);
                    image.Dispose();
                }
            }
        }

        private void picbFacePicture_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picbFacePicture_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }



    }
}
