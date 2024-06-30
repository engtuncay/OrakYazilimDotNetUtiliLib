﻿using OrakYazilimLib.DbGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrakYazilimLib.Util.core
{
    public class FiKeyBean : Dictionary<string, object>
    {
        public FiKeyBean()
        {
        }

        public FiKeyBean(IDictionary<string, object> dictionary) : base(dictionary)
        {
        }
        public void AddByFiCol(FiCol ficol, object objValue)
        {
            Add(ficol.txFieldName,objValue);
        }



    }
}