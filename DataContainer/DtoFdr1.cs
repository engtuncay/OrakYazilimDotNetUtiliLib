using System;
using System.Data;

namespace OrakYazilimLib.DataContainer
{
    public class DtoFdr1
    {
        public bool? boResult { get; set; }
        public Object refValue { get; set; }

        public static DtoFdr1 ImportFdr(Fdr<DataTable> fdr)
        {
            DtoFdr1 dtoFdr1 = new DtoFdr1
            {
                boResult = fdr.boResult,
                refValue = fdr.refValue
            };

            if(fdr.obReturn!=null) dtoFdr1.refValue = fdr.obReturn;

            return dtoFdr1;
        }
    }
}