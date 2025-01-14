using OrakYazilimLib.Util.Collection;

namespace OrakYazilimLib.Util.ColStruct
{
    public interface IFiTableMeta
    {
        string GetITxTableName();

        FiColList GenITableCols();

        FiColList GenITableColsTrans();
    }
}