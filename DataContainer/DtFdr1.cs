using System;
using System.Data;

namespace OrakYazilimLib.DataContainer
{
    public class DtFdr1
    {
        public bool? boResult { get; set; }
        public Object refValue { get; set; }

        public static DtFdr1 ImportFdr(Fdr<DataTable> fdr)
        {
            DtFdr1 dtFdr1 = new DtFdr1
            {
                boResult = fdr.boResult,
                refValue = fdr.refValue
            };

            if(fdr.obReturn!=null) dtFdr1.refValue = fdr.obReturn;

            return dtFdr1;
        }
    }
}