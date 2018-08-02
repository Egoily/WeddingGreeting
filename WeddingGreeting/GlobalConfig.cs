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



        /// <summary>
        /// 加载系统配置
        /// </summary>
        public static void Load()
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
        /// <summary>
        /// 保存配置数据到文件
        /// </summary>
        public static void Save()
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
