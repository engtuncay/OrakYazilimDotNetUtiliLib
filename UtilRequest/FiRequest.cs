using OrakYazilimLib.Util.core;

namespace OrakYazilimLib.UtilRequest
{
    /// <summary>
    /// Request yapılırken gönderilen temel bilgiler : kullanıcı vs.
    /// </summary>
    public class FiRequest
    {
        public string frTxProfile { get; set; }
        public string frTxUser { get; set; }
        public string frTxPass { get; set; }
        public string frTxToken { get; set; }
        public FiKeybean frFkbParams { get; set; }
    }
}