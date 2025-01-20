using OrakYazilimLib.Util.config;

namespace OrakYazilimLib.DbUtil
{
    public class FiDbConnFactoryByConf: IFiDbConnFactory
    {

        public string getConnString(string connProfile)
        {
            return FiAppConfig.GetConnectionString(connProfile);
        }
    }
}