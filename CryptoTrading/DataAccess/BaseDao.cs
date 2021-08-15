using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoTrading.Common.Classes;
using CryptoTrading.Common.Models.Config;

namespace CryptoTrading.DataAccess {
    public class BaseDao {
        protected readonly IDbConnection _connection;

        public BaseDao() {
            _connection = InitialiseDapper();
        }

        private static IDbConnection InitialiseDapper() {
            IDbConnection connection;
            ConfigSettings configSettings;

            try {
                configSettings = GetConfigSettings("config.json");

                connection = new System.Data.SqlClient.SqlConnection(configSettings.SqlConnection);
            } catch (Exception) {
                throw;
            }

            return connection;
        }

        private static ConfigSettings GetConfigSettings(string filename) {
            ConfigHandler configHandler = new(filename);
            ConfigSettings configSettings = configHandler.GetConfigSettings();

            return configSettings;
        }
    }

    
}
