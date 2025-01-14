using OrakYazilimLib.DbGeneric;
using System.Collections.Generic;

namespace OrakYazilimLib.Util.Collection
{
    public class FiColList: List<FiCol>
    {
        public FiColList()
        {
        }
        public FiColList(int capacity) : base(capacity)
        {
        }
        public FiColList(IEnumerable<FiCol> collection) : base(collection)
        {
        }
    }
}