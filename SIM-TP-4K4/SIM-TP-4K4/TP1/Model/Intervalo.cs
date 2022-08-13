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

        public int frecuencia { get; set; }

        public Intervalo(double limInf, double limSup)
        {
            this.limInf = limInf;
            this.limSup = limSup;
            this.frecuencia = 0;
        }


        public Boolean contieneRnd(double random) {
            return (random >= limInf && random < limSup);
        }

        public void contar(int orden, int ordenAnterior, int obs)
        {
            frecuencia = ((frecuencia * ordenAnterior) + obs) / (orden);
        }

        public string intervaloTitulo()
        {
            return $"[{nameof(limInf)};{nameof(limSup)})";
        }
    }

}
