using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrakYazilimLib.AdoNetHelper
{
    public static class FiSqlUtil
    {
        public static Boolean CheckForSQLInjection(string userInput) {

            bool isSqlInjection = false;

            string[] sqlCheckList = { "--",";--",";","/*","*/","@@","@","char","nchar","varchar","nvarchar","alter","begin",
"cast","create","cursor","declare","delete","drop","end","exec","execute","fetch","insert","kill","select","sys","sysobjects",
"syscolumns","table","update" };

            string checkString = userInput.Replace("'", "''");

            for (int i = 0; i <= sqlCheckList.Length - 1; i++)
            {

                if ((checkString.IndexOf(sqlCheckList[i],StringComparison.OrdinalIgnoreCase) >= 0)) {
                    isSqlInjection = true;
                }
            }

            return isSqlInjection;
        }

        public static string ManipulateSqlInjection(string userInput)
        {
            return CheckForSQLInjection(userInput) ? "-9999999" : userInput;
        }
    }

    
}

