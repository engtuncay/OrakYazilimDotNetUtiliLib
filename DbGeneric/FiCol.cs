using OrakYazilimLib;

namespace OrakYazilimLib.DbGeneric
{

    public class FiCol
    {
        public string ofcTxFieldName { get; set; }
        public string ofcTxHeader { get; set; }

        /**
         * Alanın varsayılan veri türü
         * 
         */
        public FiColType fiColType { get; set; }

        public FiCol(string fieldName)
        {
            this.ofcTxFieldName = fieldName;
        }

        public FiCol(string ofcTxFieldName,string ofcTxHeader)
        {
            this.ofcTxFieldName = ofcTxFieldName;
            this.ofcTxHeader = ofcTxHeader;
        }

        public string GetFieldName()
        {
            return this.ofcTxFieldName;
        }

        public FiCol()
        {
        }

        public override string ToString()
        {
            if(this.ofcTxFieldName == null) { return ""; }
            return this.ofcTxFieldName;
        }
    }

}