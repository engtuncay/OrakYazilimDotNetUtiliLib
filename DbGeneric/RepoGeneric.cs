using OrakYazilimLib.DbUtil;
using System;

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
            Console.WriteLine($"dbhelper: {connProfile}");
            return FiMssqlu.BuiWitProfile(connProfile);
        }

        public void CheckAndSetConnProfile()
        {
            // TODO metod yaz
        }

    }
}