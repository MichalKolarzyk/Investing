using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Settings
{
    public class SettingsAppManager
    {
        public IAppSettings GetAppSettings()
        {
            string jsonString = File.ReadAllText("AppConfig.json");
            return JsonSerializer.Deserialize<IAppSettings>(jsonString);
        }

        public void SaveAppSettings(IAppSettings appSettings)
        {
            JsonSerializer.Serialize(appSettings);
        }
    }
}
