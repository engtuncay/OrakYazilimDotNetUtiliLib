using OrakYazilimLib.DbGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrakYazilimLib.Util.core
{
    public class FiKeyString : Dictionary<string, string>
    {
        
        //public HashSet<FiCol> setFiCol { get; set; }
        
        public FiKeyString()
        {
        }

        public FiKeyString(IDictionary<string, string> dictionary) : base(dictionary)
        {
        }
        
        // public void AddByFiCol(FiCol ficol, object objValue)
        // {
        //     GetSetFiColInit().Add(ficol);
        //     Add(ficol.ofcTxFieldName,objValue);
        // }

        // public HashSet<FiCol> GetSetFiColInit()
        // {
        //     return setFiCol ?? (setFiCol = new HashSet<FiCol>());
        // }

    }
}
