using OrakYazilimLib.DbUtil;

namespace OrakYazilimLib.DbGeneric
{
    public class RepoGeneric<T>
    {
        public string connProfile { get; set; }

        public FiMssqlu GetDbHelper()
        {
            return FiMssqlu.BuiWitProfile(connProfile);
        }

        public void CheckAndSetConnProfile()
        {
            // TODO metod yaz
        }

    }
}