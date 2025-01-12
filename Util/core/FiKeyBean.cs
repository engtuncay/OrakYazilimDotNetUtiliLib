using OrakYazilimLib.DbGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrakYazilimLib.Util.core
{
    public class FiKeybean : Dictionary<string, object>
    {
        // if order is importat, then use SortedSet
        public HashSet<FiCol> setFiCol { get; set; }
        
        public FiKeybean()
        {
        }

        public FiKeybean(IDictionary<string, object> dictionary) : base(dictionary)
        {
        }
        
        public void addByFiCol(FiCol ficol, object objValue)
        {
            getSetFiColInit().Add(ficol);
            Add(ficol.txFieldName,objValue);
        }

        public HashSet<FiCol> getSetFiColInit()
        {
            return setFiCol ?? (setFiCol = new HashSet<FiCol>());
        }

    }
}
