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
    public class GuestMgr
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
                var entourageText = info.Entourage ?? "";
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


                var guest = GlobalConfigs.Guests.FirstOrDefault(x => x.Name == name);
                BaseResponse<FaceRegisterResult> jObj;
                jObj = FaceApi.FaceSaveOrUpdate(new Bitmap(img), GlobalConfigs.Configurations.GroupId, guest != null ? guest.Id : userId, option);
                success = (jObj != null && jObj.error_code == 0);
                if (success)
                {
                    var entourages = entourageText.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    var entourageNum = entourages.Count();

                    if (guest == null)//新增
                    {
                        GlobalConfigs.Guests.Add(new ee.Models.GuestInfo()
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
                            CashGift = info.CashGift,
                            CreateTime = DateTime.Now,
                        });
                        if (entourages != null)
                        {
                            foreach (var item in entourages)
                            {
                                GlobalConfigs.Guests.Add(new ee.Models.GuestInfo()
                                {
                                    Id = System.Guid.NewGuid().ToString().Replace("-", "").ToUpper(),
                                    ParentId = userId,
                                    Name = $"{name}_{item}",
                                    Gender = 0,
                                    GuestType = guestType,
                                    Entourage = "",
                                    EntourageNum = 0,
                                    Labels = $"{name} 随行人员",
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
                        guest.Gender = gender;
                        guest.GuestType = guestType;
                        guest.Entourage = entourageText;
                        guest.EntourageNum = entourageNum;
                        guest.Labels = labels;
                        guest.TableNo = tableNo;
                        guest.ImagePath = imageFileName;
                        guest.CashGift = info.CashGift;
                        guest.CreateTime = DateTime.Now;

                        for (int i = 0; i < GlobalConfigs.Guests.Count; i++)
                        {
                            if (GlobalConfigs.Guests[i].ParentId == userId)
                                GlobalConfigs.Guests.Remove(GlobalConfigs.Guests[i]);
                        }

                        if (entourages != null)
                        {
                            foreach (var item in entourages)
                            {
                                GlobalConfigs.Guests.Add(new ee.Models.GuestInfo()
                                {
                                    Id = System.Guid.NewGuid().ToString().Replace("-", "").ToUpper(),
                                    ParentId = userId,
                                    Name = $"{name}_{item}",
                                    Gender = 0,
                                    GuestType = guestType,
                                    Entourage = "",
                                    EntourageNum = 0,
                                    Labels = $"{name} 随行人员",
                                    TableNo = tableNo,
                                    ImagePath = null,
                                    IsAttend = guest.IsAttend,
                                    AttendTime = guest.AttendTime,
                                    CreateTime = DateTime.Now,
                                });
                            }
                        }
                    }
                    GlobalConfigMgr.SaveGuests();
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

        public static bool UpdateGusetInfo(GuestInfo info)
        {
            try
            {
                var guest = GlobalConfigs.Guests.FirstOrDefault(x => x.Name == info.Name);
                guest.Name = info.Name;
                guest.Gender = info.Gender;
                guest.GuestType = info.GuestType;
                guest.Entourage = info.Entourage;
                guest.EntourageNum = info.EntourageNum;
                guest.Labels = info.Labels;
                guest.TableNo = info.TableNo;
                guest.ImagePath = info.ImagePath;
                guest.CashGift = info.CashGift;
                guest.CreateTime = DateTime.Now;
                guest.IsAttend = info.IsAttend;
                guest.AttendTime = info.AttendTime;

                for (int i = 0; i < GlobalConfigs.Guests.Count; i++)
                {
                    if (GlobalConfigs.Guests[i].ParentId == info.Id)
                        GlobalConfigs.Guests.Remove(GlobalConfigs.Guests[i]);
                }
                var entourages = info.Entourage.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                var entourageNum = entourages.Count();
                if (entourages != null)
                {
                    foreach (var item in entourages)
                    {
                        GlobalConfigs.Guests.Add(new ee.Models.GuestInfo()
                        {
                            Id = System.Guid.NewGuid().ToString().Replace("-", "").ToUpper(),
                            ParentId = info.Id,
                            Name = $"{info.Name}_{item}",
                            Gender = 0,
                            GuestType = info.GuestType,
                            Entourage = "",
                            EntourageNum = 0,
                            Labels = info.Labels,
                            TableNo = info.TableNo,
                            ImagePath = null,
                            IsAttend = guest.IsAttend,
                            AttendTime = guest.AttendTime,
                            CreateTime = DateTime.Now,
                        });
                    }
                }
                GlobalConfigMgr.SaveGuests();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
