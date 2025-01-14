using OrakYazilimLib.Util.Collection;
using OrakYazilimLib.Util.ColStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrakYazilimLib.DbUtil
{
    /// <summary>
    /// FiCols Query Generator - Sorgu oluşturma yardımcı metodlar
    /// </summary>
    public static class FicQugen
    {

        public static string Select(FiColList list,IFiTableMeta iFiTableMeta)
        {
            return null;            
        }
        
        public static string Insert(FiColList list,IFiTableMeta iFiTableMeta)
        {
                       //String template = "INSERT INTO {{tableName}} ( {{csvFields}} ) \n"
                       // + " VALUES ( {{paramFields}} )";
                       //
                       // StringBuilder queryFields = new StringBuilder();
                       // StringBuilder queryParams = new StringBuilder();
                       //
                       // int indexFields = 1;
                       // int indexParams = 1;
                       //
                       // for (FiCol fiCol : listFields) {
                       //
                       //     if (indexFields != 1) queryFields.append(", ");
                       //     queryFields.append(fiCol.getOfcTxFieldName());
                       //
                       //     if (indexParams != 1) queryParams.append(", ");
                       //     queryParams.append("@").append(fiCol.getOfcTxFieldName());
                       //
                       //     indexFields++;
                       //     indexParams++;
                       // }
                       //
                       // FiKeyBean fkbTemplate = new FiKeyBean();
                       // fkbTemplate.add("tableName", getTableName(clazz));
                       // fkbTemplate.add("csvFields", queryFields.toString());
                       // fkbTemplate.add("paramFields", queryParams.toString());
                       //
                       // return FiString.substitutor(template, fkbTemplate);
                       return null;
        }
    }


}
