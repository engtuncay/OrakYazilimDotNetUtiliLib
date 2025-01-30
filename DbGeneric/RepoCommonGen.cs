using OrakYazilimLib.DbUtil;
using OrakYazilimLib.Util.config;

namespace OrakYazilimLib.DbGeneric
{
    public class RepoCommonGen<T>
    {
        public string connProfile { get; set; }
        public string connString{ get; set; }

        //public FiConnConfig fiConnConfig { get; set; }

        public FiMssqlu getDbHelper()
        {
            return FiMssqlu.BuiWitProfile(connProfile);
        }

        public void checkAndSetConnProfile()
        {
            // TODO metod yaz
        }

    }
}