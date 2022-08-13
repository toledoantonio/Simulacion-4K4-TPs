using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.Model
{
    public class PseudoAleatorio
    {
        static readonly double ajusteCantidadDecimales = Math.Pow(10, 4);
        public double random { get; set; }

        public int entero;

        
        public PseudoAleatorio(int xi, int m)
        {
            double rnd = (double)(xi / m);
            this.random = Math.Truncate(rnd * ajusteCantidadDecimales) / ajusteCantidadDecimales;
        }
    }
}
