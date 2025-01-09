namespace OrakYazilimLib.DbUtil
{
    public interface IFiDbConnFactory
    {
        string getConnString(string connProfile);
    }
}