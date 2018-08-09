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
        private static string ConfigFile = System.Environment.CurrentDirectory + @"\data.json";
        public static List<GuestInfo> Guests { get; set; }

        public static string GroupId = "EE";
        public static double Threshold = 50d;

        public static void LoadGuests()
        {
            if (!File.Exists(ConfigFile))
            {
                var fs = new FileStream(ConfigFile, FileMode.Create, FileAccess.ReadWrite);
                fs.Close();
            }

            var json = File.ReadAllText(ConfigFile);

            Guests = JsonConvert.DeserializeObject<List<GuestInfo>>(json);


            if (Guests == null)
            {
                Guests = new List<GuestInfo>();
            }

        }

        public static void SaveGuests()
        {
            var jsonSetting = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };
            var json = JsonConvert.SerializeObject(Guests, jsonSetting);

            File.WriteAllText(ConfigFile, json);
        }

    }
}
