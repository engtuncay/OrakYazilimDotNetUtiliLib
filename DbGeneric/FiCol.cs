using OrakYazilimLib;

namespace OrakYazilimLib.DbGeneric
{

    public class FiCol
    {
        public string ofcTxFieldName { get; set; }
        public string ofcTxHeader { get; set; }
        public FiColType ofcFiColType { get; set; }

        /**
         * Alanın varsayılan veri türü
         *
         */
        public FiColType fiColType { get; set; }

        public FiCol(string fieldName)
        {
            this.ofcTxFieldName = fieldName;
        }

        public FiCol(string ofcTxFieldName, string ofcTxHeader)
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
            return this.ofcTxFieldName ?? "";
        }
        
        public FiCol BuiColType(FiColType fiColType)
        {
            this.fiColType = fiColType;
            return this;
        }
    }

}