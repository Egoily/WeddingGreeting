using Baidu.AI.Face;
using Baidu.AI.Face.Models;
using EgoDevil.Utilities.UI.MessageForm;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WeddingGreeting.Forms
{
    public partial class FrmRegister : Form
    {




        public FrmRegister()
        {
            InitializeComponent();
        }



        private bool? SaveOrUpdate()
        {

            try
            {

                var name = txtName.Text;
                if (string.IsNullOrEmpty(name))
                {
                    MsgForm.Show("请输入姓名");
                    return null;
                }
                var labels = txtLabels.Text;
                if (string.IsNullOrEmpty(labels))
                {
                    MsgForm.Show("请输入标签");
                    return null;
                }
                var tableNo = txtTableNo.Text;
                if (string.IsNullOrEmpty(tableNo))
                {
                    MsgForm.Show("请输入桌号");
                    return null;
                }
                var image = picbFacePicture.Image;
                if (image == null)
                {
                    MsgForm.Show("请选择相片");
                    return null;

                }

                var userId = txtNamePinyin.Text.Trim();

                if (string.IsNullOrEmpty(userId))
                {
                    userId = System.Guid.NewGuid().ToString().Replace("-", "").ToUpper();
                  
                }
                var imageFileName = Path.Combine($"GuestImages\\{userId}.jpg");

                if (File.Exists(imageFileName))
                    File.Delete(imageFileName);
                var img = (Bitmap)image.Clone();
                img.Save(imageFileName, ImageFormat.Jpeg);
                img.Dispose();
                var option = new FaceOption()
                {
                    User_Info = $"姓名: {name} \n身份: {labels}\n桌号: {tableNo} ",
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
                    var entourageText = txtEntourage.Text ?? "";

                    var entourages = entourageText.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    var entourageNum = entourages.Count();
                    var guest = GlobalConfig.Guests.FirstOrDefault(x => x.Id == userId);
                    if (guest == null)
                    {
                        GlobalConfig.Guests.Add(new ee.Models.GuestInfo()
                        {
                            Id = userId,
                            Name = name,
                            Gender = cbbGender.SelectedIndex,
                            GuestType = cbbGuestType.SelectedIndex,
                            Entourage = entourageText,
                            EntourageNum = entourageNum,
                            Labels = labels,
                            TableNo = tableNo,
                            ImagePath = imageFileName,
                            CreateTime = DateTime.Now,
                        });
                        if (entourages != null)
                        {
                            foreach (var item in entourages)
                            {
                                GlobalConfig.Guests.Add(new ee.Models.GuestInfo()
                                {
                                    Id = System.Guid.NewGuid().ToString().Replace("-", "").ToUpper(),
                                    ParentId = userId,
                                    Name = $"{name}_{item}",
                                    Gender = 0,
                                    GuestType = cbbGuestType.SelectedIndex,
                                    Entourage = "",
                                    EntourageNum = 0,
                                    Labels = labels,
                                    TableNo = tableNo,
                                    ImagePath = null,
                                    CreateTime = DateTime.Now,
                                });
                            }
                        }

                    }
                    else
                    {
                        guest.Name = name;
                        guest.Gender = cbbGender.SelectedIndex;
                        guest.GuestType = cbbGuestType.SelectedIndex;
                        guest.Entourage = entourageText;
                        guest.EntourageNum = entourageNum;
                        guest.Labels = labels;
                        guest.TableNo = tableNo;
                        guest.ImagePath = null;
                        guest.CreateTime = DateTime.Now;

                        for (int i = 0; i < GlobalConfig.Guests.Count; i++)
                        {
                            if (GlobalConfig.Guests[i].ParentId == userId)
                                GlobalConfig.Guests.Remove(GlobalConfig.Guests[i]);
                        }

                        if (entourages != null)
                        {
                            foreach (var item in entourages)
                            {
                                GlobalConfig.Guests.Add(new ee.Models.GuestInfo()
                                {
                                    Id = System.Guid.NewGuid().ToString().ToUpper(),
                                    ParentId = userId,
                                    Name = $"{name}_{item}",
                                    Gender = 0,
                                    GuestType = cbbGuestType.SelectedIndex,
                                    Entourage = "",
                                    EntourageNum = 0,
                                    Labels = labels,
                                    TableNo = tableNo,
                                    ImagePath = null,
                                    IsAttend = guest.IsAttend,
                                    AttendTime = guest.AttendTime,
                                    CreateTime = DateTime.Now,
                                });
                            }
                        }
                    }



                    GlobalConfig.SaveGuests();
                }

                return success;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        private void FrmRegister_Load(object sender, EventArgs e)
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
                lbOperationResult.ForeColor = success.Value ? Color.GreenYellow : Color.Red;
                lbOperationResult.Text = message;
            }
            Cursor = Cursors.Default;
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
