using OrakYazilimLib.Util.core;
using System;
using System.Configuration;
using System.Drawing;

namespace OrakYazilimLib.Util.config
{
    public static class FiAppConfig
    {
        public static bool boTestMode = false;
        public static bool boUseConfigManager = false; // { get; set; }  //= false;
        public static IConfigManager configManager;

        public static void ConvertTestModeTrue()
        {
            boTestMode = true;
        }

        public static string GetConnectionString(string key)
        {
            // config dosyasından key'den sonra test ile geleni alması için.
            if (boTestMode == true) key = key + "Test";

            if (boUseConfigManager)
            {
                return configManager.GetConnString(key); // GetFksConfigsInit()[key];
            }

            string connString = ConfigurationManager.ConnectionStrings[key].ConnectionString;

            FiLogWeb.logWeb("Active GetConnectionString (FiAppConfig) : " + connString);
            //FiLogWeb.logWeb("FiAppConfig ConnString Key : " + key);
            //FiLogWeb.logWeb("FiAppConfig ConnString : " + connString);
            return connString;
        }

    }
}