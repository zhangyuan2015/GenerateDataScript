using GenerateDataScript.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace GenerateDataScript.Helper
{
    public class ConfigHelper
    {
        public static List<DataBaseConfigModel> ConfigList { get; set; }

        public static List<DataBaseConfigModel> GetConfig()
        {
            string basePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            var filePath = basePath + "Config.json";

            var configModelList = new List<DataBaseConfigModel>();
            if (File.Exists(filePath))
            {
                var jsonStr = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(jsonStr))
                    configModelList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DataBaseConfigModel>>(jsonStr);
            }

            return configModelList;
        }

        public static void SaveConfig(List<DataBaseConfigModel> configModelList)
        {
            string basePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            var filePath = basePath + "Config.json";
            string jsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(configModelList);
            File.WriteAllText(filePath, jsonStr);
        }
    }
}