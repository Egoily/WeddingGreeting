using Baidu.AI.Face;
using Baidu.AI.Face.Models;
using ee.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingGreeting
{
    public class GuestManagement
    {
        public static bool SaveOrUpdate(GuestInfo info)
        {
            bool success = false;
            try
            {
                var name = info.Name;
                var gender = info.Gender;
                var labels = info.Labels;
                var tableNo = info.TableNo;
                var imagePath = info.ImagePath;
                var entourageText = info.Entourage;
                var guestType = info.GuestType;
                var userId = info.Id;
                if (string.IsNullOrEmpty(userId))
                {
                    userId = System.Guid.NewGuid().ToString().Replace("-", "").ToUpper();
                }

                var imageFileName = Path.Combine($"GuestImages\\{userId}.jpg");


                var img = Bitmap.FromFile(imagePath);


                var option = new FaceOption()
                {
                    User_Info = $"姓名: {name} \n身份: {labels}\n桌号: {tableNo} ",
                };


                var guest = GlobalConfig.Guests.FirstOrDefault(x => x.Name == name);
                BaseResponse<FaceRegisterResult> jObj;
                if (guest == null)//新增
                {

                    jObj = APIBase.FaceSaveOrUpdate(new Bitmap(img), GlobalConfig.GroupId, userId, option);

                    success = (jObj != null && jObj.error_code == 0);

                    if (success)
                    {

                        var entourages = entourageText.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                        var entourageNum = entourages.Count();

                        GlobalConfig.Guests.Add(new ee.Models.GuestInfo()
                        {
                            Id = userId,
                            Name = name,
                            Gender = gender,
                            GuestType = guestType,
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
                                    GuestType = guestType,
                                    Entourage = "",
                                    EntourageNum = 0,
                                    Labels = labels,
                                    TableNo = tableNo,
                                    ImagePath = null,
                                    CreateTime = DateTime.Now,
                                });
                            }
                        }

                        GlobalConfig.SaveGuests();
                    }

                }
                else
                {
                    jObj = APIBase.FaceSaveOrUpdate(new Bitmap(img), GlobalConfig.GroupId, guest.Id, option);
                    success = (jObj != null && jObj.error_code == 0);

                    if (success)
                    {

                        var entourages = entourageText.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                        var entourageNum = entourages.Count();

                        guest.Name = name;
                        guest.Gender = gender;
                        guest.GuestType = guestType;
                        guest.Entourage = entourageText;
                        guest.EntourageNum = entourageNum;
                        guest.Labels = labels;
                        guest.TableNo = tableNo;
                        guest.ImagePath = imageFileName;
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
                                    GuestType = guestType,
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



                        GlobalConfig.SaveGuests();
                    }
                }
                var newImage = new Bitmap(img);
                img.Dispose();
                if (File.Exists(imageFileName))
                    File.Delete(imageFileName);

                newImage.Save(imageFileName, ImageFormat.Jpeg);
                newImage.Dispose();

                return success;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
