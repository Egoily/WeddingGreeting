using Baidu.AI.Face;
using Baidu.AI.Face.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeddingGreeting.Forms
{
    public partial class FrmRegister : Form
    {

        public FrmRegister()
        {
            InitializeComponent();
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
                var image = Bitmap.FromFile(ofd.FileName);
                if (image != null)
                {
                    picbFacePicture.Image = new Bitmap(image);
                    image.Dispose();
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var success = SaveOrUpdate();
            if (success.HasValue)
            {
                var message = success.Value ? "录入成功" : "录入失败";
                MessageBox.Show(message);
            }
            Cursor = Cursors.Default;
        }

        private bool? SaveOrUpdate()
        {

            try
            {
                var userId = txtNamePinyin.Text.Trim();
                if (string.IsNullOrEmpty(userId))
                {
                    MessageBox.Show("请输入ID");
                    return null;
                }
                var name = txtName.Text;
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("请输入姓名");
                    return null;
                }
                var status = txtStatus.Text;
                if (string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("请输入身份");
                    return null;
                }
                var tableNo = txtTableNo.Text;
                if (string.IsNullOrEmpty(tableNo))
                {
                    MessageBox.Show("请输入桌号");
                    return null;
                }
                var image = picbFacePicture.Image;
                if (image == null)
                {

                    MessageBox.Show("请选择相片");
                    return null;

                }

                var imageFileName = Path.Combine($"GuestImages\\{userId}.jpg");

                if (File.Exists(imageFileName))
                    File.Delete(imageFileName);
                var img = (Bitmap)image.Clone();
                img.Save(imageFileName, ImageFormat.Jpeg);
                img.Dispose();
                var option = new FaceOption()
                {
                    User_Info = $"姓名: {name} \n身份: {status}\n桌号: {tableNo} ",
                };

                var user = APIBase.GetUserInfo(userId, GlobalConfig.GroupId);

                BaseResponse<FaceRegisterResult> jObj;
                if (user != null && user.error_code == 0 && (user.result?.user_list?.Any() ?? false))
                {
                    jObj = APIBase.FaceUpdate(new Bitmap(image), GlobalConfig.GroupId, userId, option);

                }
                else
                {
                    jObj = APIBase.FaceRegister(new Bitmap(image), GlobalConfig.GroupId, userId, option);
                }
                var success = (jObj != null && jObj.error_code == 0);
                if (success)
                {
                    var guest = GlobalConfig.Guests.FirstOrDefault(x => x.Id == userId);
                    if (guest == null)
                    {
                        GlobalConfig.Guests.Add(new ee.Models.GuestInfo()
                        {
                            Id = userId,
                            Name = name,
                            Labels = status,
                            TableNo = tableNo,
                            ImagePath = imageFileName,
                            CreateTime = DateTime.Now,
                        });
                    }
                    else
                    {
                        guest.Name = name;
                        guest.Labels = status;
                        guest.TableNo = tableNo;
                        guest.ImagePath = imageFileName;
                        guest.CreateTime = DateTime.Now;
                    }
                    GlobalConfig.Save();
                }

                return success;
            }
            catch (Exception ex)
            {
                return false;
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
