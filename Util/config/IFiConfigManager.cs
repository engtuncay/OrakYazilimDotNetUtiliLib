using OrakYazilimLib.Util.core;

namespace OrakYazilimLib.Util.config
{
    public interface IFiConfigManager
    {
        string GetConnString(string profile);
    }
}