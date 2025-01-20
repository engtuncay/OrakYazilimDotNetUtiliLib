using OrakYazilimLib.Util.core;

namespace OrakYazilimLib.Util.config
{
    public interface IConfigManager
    {
        string GetConnString(string profile);
    }
}