using OrakYazilimLib.Util.core;

namespace OrakYazilimLib.UtilRequest
{
    /// <summary>
    /// Request yapılırken gönderilen temel bilgiler : kullanıcı vs.
    /// </summary>
    public class FiRequest
    {
        public string firTxProfile { get; set; }
        public string firTxUser { get; set; }
        public string firTxPass { get; set; }
        public FiKeybean firFkbParams { get; set; }
    }
}