using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.TP1.Model
{
    internal class Util
    {
        static readonly double ajusteCantidadDecimales = Math.Pow(10, 4);


        public static double truncar(double aTruncar)
        {
            return Math.Truncate(aTruncar * ajusteCantidadDecimales) / ajusteCantidadDecimales;
        }
    }
}
