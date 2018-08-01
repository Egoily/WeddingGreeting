using Baidu.AI.Face;
using Baidu.AI.Face.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Drawing;

namespace AI.Face.Tests
{
    [TestClass()]
    public class ServiceTests
    {
        [TestInitialize()]
        public void Initialize()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        [TestMethod()]
        public void GetGroupsTest()
        {
            var options = new GetActionOption()
            {
                Start = 0,
                Length = 100,
            };
            var jObj = APIBase.GetGroups(options);
        }

        [TestMethod()]
        public void GetUsersTest()
        {
            var groupId = "EE";
            var jObj = APIBase.GetUsers(groupId);
        }

        [TestMethod()]
        public void SearchFaceTest()
        {
            var image = Bitmap.FromFile(@"Ego.jpg");
            var groupIds = new string[] { "EE" };
            var option = new SearchFaceOption()
            {
                Max_User_Num = 10,
            };
            var jObj = APIBase.FaceSearch(new Bitmap(image), groupIds, option);
            image.Dispose();
        }

        [TestMethod()]
        public void FaceRegisterTest()
        {
            var image = Bitmap.FromFile(@"Ego.jpg");
            var groupId = "EE";
            var userId = "HuangGuangyi3";
            var option = new FaceOption()
            {
                User_Info = "hhhhhhhhhhhhhhh"
            };
            var jObj = APIBase.FaceRegister(new Bitmap(image), groupId, userId, option);
            image.Dispose();
        }

        [TestMethod()]
        public void GetUserInfoTest()
        {
            var groupId = "EE";
            var userId = "HuangGuangyi2";

            var jObj = APIBase.GetUserInfo(userId, groupId);
        }

        [TestMethod()]
        public void FaceUpdateTest()
        {
            var image = Bitmap.FromFile(@"Ego.jpg");
            var groupId = "EE";
            var userId = "Ego";
            var option = new FaceOption()
            {
                User_Info = "黄广毅  新郎  请就坐1号桌."
            };
            var jObj = APIBase.FaceUpdate(new Bitmap(image), groupId, userId, option);
            image.Dispose();
        }

        [TestMethod()]
        public void FaceUpdat2eTest()
        {
            var image = Bitmap.FromFile(@"Elise.jpg");
            var groupId = "EE";
            var userId = "Elise";
            var option = new FaceOption()
            {
                User_Info = "高小娜  新娘  请就坐1号桌."
            };
            var jObj = APIBase.FaceUpdate(new Bitmap(image), groupId, userId, option);
            image.Dispose();
        }

        [TestMethod()]
        public void FaceDeleteTest()
        {
            var groupId = "EE";
            var userId = "HuangGuangyi2";

            var jObj = APIBase.FaceDelete(userId, groupId);
        }

        [TestMethod()]
        public void FaceDetectTest()
        {
            var image = Bitmap.FromFile(@"Ego.jpg");

            var options = new List<FaceDetectOptions>()
            {
            };

            var jObj = APIBase.FaceDetect(new Bitmap(image), options, 1);
            image.Dispose();
        }
    }
}