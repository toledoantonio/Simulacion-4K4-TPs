using SIM_TP_4K4.TP1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.Model
{
    public class Intervalo
    {
        public double limInf { get; set; }
        public double limSup { get; set; }

        public double frecuenciaRelativa { get; set; }
        public int frecuenciaAbsoluta { get; set; }

        public Intervalo(double limInf, double limSup)
        {
            this.limInf = limInf;
            this.limSup = limSup;
            this.frecuenciaRelativa = 0;
            this.frecuenciaAbsoluta = 0;
        }


        public Boolean contieneRnd(double random) {
            return (random >= limInf && random < limSup);
        }

        public void contarRelativa(int orden, int ordenAnterior, int obs)
        {
            this.frecuenciaRelativa = ((this.frecuenciaRelativa * ordenAnterior) + obs) / ((double) orden);
        }

        public void contarAbsoluta(int obs)
        {
            this.frecuenciaAbsoluta += obs;
        }

        public string intervaloTitulo()
        {
            return $"[{(limInf)} - {(limSup)})";
        }
    }
}
