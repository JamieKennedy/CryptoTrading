using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoTrading.Common.Models.Config;
using Microsoft.Extensions.Configuration;

namespace CryptoTrading.Common.Classes {
    public class ConfigHandler {
        private string _filename;
        private ConfigSettings _configSettings;
        private bool isDebug = false;

        public ConfigHandler(string filename) {
            _filename = filename;
            _configSettings = GetConfigSettings();

            // Check if Debug or Release
            IsDebugCheck(ref isDebug);
        }

        public ConfigSettings GetConfigSettings() {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(_filename, false, true)
                .Build();

            if (isDebug) {
                return config.GetSection("Debug").Get<ConfigSettings>();
            }
            else {
                return config.GetSection("Release").Get<ConfigSettings>();
            }
        }

        [Conditional("DEBUG")]
        private static void IsDebugCheck(ref bool isDebug) {
            isDebug = true;
        }
    }
}
