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

        public static string OrElseEmptyString(object p)
        {
            return p == null ? "" : p.ToString();
        }

        public static bool IsEmptyWithTrim(string txValue)
        {
            return txValue == null || IsEmpty(txValue.Trim());
        }

        public static string ReplaceTemplateParameters(string input, Dictionary<string, object> parameters)
        {
            if (string.IsNullOrEmpty(input) || parameters == null || parameters.Count == 0)
                return input;

            return Regex.Replace(input, @"\{\{(.*?)\}\}", match =>
            {
                string key = match.Groups[1].Value.Trim();
                return parameters.ContainsKey(key) ? parameters[key]?.ToString() : match.Value; // Eğer key varsa değiştir, yoksa olduğu gibi bırak.
            });
        }
    }
}