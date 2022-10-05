using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.TP4.Model
{
    public class Intervalo
    {
        public double limInf { get; set; }
        public double limSup { get; set; }

        public double frecuenciaRelativa { get; set; }

        public Intervalo() { }

        public Intervalo(double limInf, double limSup)
        {
            this.limInf = limInf;
            this.limSup = limSup;
            this.frecuenciaRelativa = 0;
        }

        public Intervalo( double liminf): this(liminf, 0)
        {
        }

        public Boolean contieneNum(double num)
        {
            return (limSup == 0) ? (num >= limInf):(num >= limInf && num < limSup);
        }

        public void contarFrecuencia(int orden, int ordenAnterior, int obs)
        {
            this.frecuenciaRelativa = ((this.frecuenciaRelativa * ordenAnterior) + obs) / ((double)orden);
        }

        public string intervaloTitulo()
        {
            return (limSup == 0) ? $"Mayores a {(limInf)}":$"[{(limInf)} - {(limSup)})";
        }
    }
}
