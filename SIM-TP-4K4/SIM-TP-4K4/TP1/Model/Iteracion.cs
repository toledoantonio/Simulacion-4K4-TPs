using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.Model
{
    public class Iteracion
    {
        
        public double random { get; set; }

        public int entero;

        public int orden { get; set; }

        public int[] valoresIntervalo { get; set; }

        public Iteracion(int xi, double random, int orden, int[] valoresIntervalo)
        {
            this.entero = xi;
            this.random = random;
            this.orden = orden;
            this.valoresIntervalo = valoresIntervalo;
        }

        public Iteracion() { }
    }
}
