using ee.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingGreeting
{
    public static class GlobalConfig
    {
        /// <summary>
        /// 明文配置文件路径
        /// </summary>
        private static string DataFile = System.Environment.CurrentDirectory + @"\data.json";
        private static string ConfigFile = System.Environment.CurrentDirectory + @"\config.json";
        public static List<GuestInfo> Guests { get; set; }
        public static Configuration Configurations { get; set; }

        public static void LoadGuests()
        {
            if (!File.Exists(DataFile))
            {
                var fs = new FileStream(DataFile, FileMode.Create, FileAccess.ReadWrite);
                fs.Close();
            }

            var json = File.ReadAllText(DataFile);

            Guests = JsonConvert.DeserializeObject<List<GuestInfo>>(json);


            if (Guests == null)
            {
                Guests = new List<GuestInfo>();
            }

        }
        public static void LoadConfig()
        {
            if (!File.Exists(ConfigFile))
            {
                var fs = new FileStream(ConfigFile, FileMode.Create, FileAccess.ReadWrite);
                fs.Close();
            }

            var json = File.ReadAllText(ConfigFile);

            Configurations = JsonConvert.DeserializeObject<Configuration>(json);


            if (Configurations == null)
            {
                Configurations = new Configuration();
            }

        }

        public static void Load()
        {
            LoadConfig();
            LoadGuests();
        }
        public static void SaveGuests()
        {
            var jsonSetting = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };
            var json = JsonConvert.SerializeObject(Guests, jsonSetting);

            File.WriteAllText(DataFile, json);
        }

        public static void SaveConfig()
        {
            var jsonSetting = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };
            var json = JsonConvert.SerializeObject(Configurations, jsonSetting);

            File.WriteAllText(ConfigFile, json);
        }

    }

    public class Configuration
    {
        /// <summary>
        /// 
        /// </summary>
        public string GroupId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float Threshold { get; set; }
        public float Speed { get; set; }
        /// <summary>
        /// 是否朗读
        /// </summary>
        public bool IsSpeechable { get; set; }
        /// <summary>
        /// 问候语格式
        /// </summary>
        public string GreetFormat { get; set; }


        public Configuration()
        {
            GroupId = "EE";
            Threshold = 50f;
            Speed = 20f;
            IsSpeechable = true;
            GreetFormat = "{0},{1},欢迎光临黄广毅/高小娜夫妇的婚礼,请就坐 {2} 号桌.谢谢!";
        }





    }
}
