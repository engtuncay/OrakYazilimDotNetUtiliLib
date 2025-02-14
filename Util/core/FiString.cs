using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OrakYazilimLib.Util
{

    /// <summary>
    ///
    /// </summary>
    public static class FiString
    {
        public static void check()
        {
            //
            //
        }

        public static bool IsEmpty(string value)
        {
            if (value == null || value.Equals("")) return true;
            return false;
        }

        public static bool IsEmpty(object value)
        {
            if (value == null) return true;
            return false;
        }

        public static string OrEmptyElseTos(object p)
        {
            return p == null ? "" : p.ToString();
        }

        public static string OrEmpty(string p)
        {
            return p ?? "";
        }


        public static bool IsEmptyWithTrim(string txValue)
        {
            return txValue == null || IsEmpty(txValue.Trim());
        }


    }
}