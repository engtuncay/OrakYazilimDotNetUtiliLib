using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OrakYazilimLib.Util.core
{
    public class FiTemplate
    {
        public string txValue { get; set; }

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