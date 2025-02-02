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
        public static IFiConfigManager fiConfigManager;
        public static IFiLogManager fiLogManager;

        public static void ConvertTestModeTrue()
        {
            boTestMode = true;
        }

        public static string GetConnectionString(string txProfile)
        {
            // config dosyasından key'den sonra test ile geleni alması için.
            if (boTestMode == true) txProfile = txProfile + "Test";

            if (boUseConfigManager)
            {
                return fiConfigManager?.GetConnString(txProfile); // GetFksConfigsInit()[key];
            }

            string connString = ConfigurationManager.ConnectionStrings[txProfile].ConnectionString;

            FiLogWeb.logWeb("Active GetConnectionString (FiAppConfig) : " + connString);
            //FiLogWeb.logWeb("FiAppConfig ConnString Key : " + key);
            //FiLogWeb.logWeb("FiAppConfig ConnString : " + connString);
            return connString;
        }

        public static void LogMessage(string message)
        {
            fiLogManager?.LogMessage(message);
        }

    }
}