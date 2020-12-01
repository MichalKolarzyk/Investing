﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Settings
{
    public static class SettingsAppManager
    {
        static readonly string AppConfigFilename = "AppConfig.json";
        public static IAppSettings GetAppSettings()
        {
            string jsonString = File.ReadAllText(AppConfigFilename);
            return JsonSerializer.Deserialize<BasicAppSettings>(jsonString);
        }

        public static void SaveAppSettings(IAppSettings appSettings)
        {
            string jsonString = JsonSerializer.Serialize(appSettings);
            File.WriteAllText(AppConfigFilename, jsonString);
        }
    }
}
