﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrakYazilimLib.Util.core
{
    public class FiNumber
    {
        public static double ordZero(object value)
        {
            if (value == null) return 0d;
            return (double)value;
        }

        public static string formatEbelge(double value)
        {
            return value.ToString("0.######", CultureInfo.InvariantCulture);
        }

    }
}
