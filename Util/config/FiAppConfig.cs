using OrakYazilimLib.Util.core;
using System;
using System.Configuration;
using System.Drawing;

namespace OrakYazilimLib.Util.config
{
    public static class FiAppConfig
    {
        public static bool BoTestMode = false;
        public static bool BoUseConfigManager = false; // { get; set; }  //= false;
        public static IConfigManager ConfigManager;

        public static void ConvertTestModeTrue()
        {
            BoTestMode = true;
        }

        public static string GetConnectionString(string key)
        {
            // config dosyasından key'den sonra test ile geleni alması için.
            if (BoTestMode == true) key = key + "Test";

            if (BoUseConfigManager)
            {
                return ConfigManager.GetConnString(key); // GetFksConfigsInit()[key];
            }

            string connString = ConfigurationManager.ConnectionStrings[key].ConnectionString;

            FiLogWeb.logWeb("Active GetConnectionString (FiAppConfig) : " + connString);
            //FiLogWeb.logWeb("FiAppConfig ConnString Key : " + key);
            //FiLogWeb.logWeb("FiAppConfig ConnString : " + connString);
            return connString;
        }

    }
}