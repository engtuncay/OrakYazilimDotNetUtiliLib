using OrakYazilimLib.DbUtil;

namespace OrakYazilimLib.DbGeneric
{
    public class RepoGeneric<T>
    {
        public string connProfile { get; set; }

        public RepoGeneric()
        {
        }

        public RepoGeneric(string connProfile)
        {
            this.connProfile = connProfile;
        }

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