using OrakYazilimLib.AdoNetHelper;
using OrakYazilimLib.Util.core;
using System.Collections.Generic;

namespace OrakYazilimLib.Util.Collection
{
    public class ListFkb: List<FiKeybean>
    {
        public ListFkb()
        {
        }

        public ListFkb(int capacity) : base(capacity)
        {
        }
        
        public ListFkb(IEnumerable<FiKeybean> collection) : base(collection)
        {
        }
        
        
    }
}