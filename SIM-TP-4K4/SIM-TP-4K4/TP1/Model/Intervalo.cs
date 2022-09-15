using SIM_TP_4K4.TP1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TP_4K4.Model
{
    public class Intervalo
    {

        public int intervaloId { get; set; }
        public double limInf { get; set; }
        public double limSup { get; set; }

        public double marcaClase { get; set; }
        public double frecuenciaRelativa { get; set; }

        public double frecuenciaRelativaEsperada { get; set; }

        public int frecuenciaAbsoluta { get; set; }

        public double frecuenciaEsperada { get; set; }

        public int valor { get; set; }

        public Intervalo() { }

        public Intervalo(double limInf, double limSup)
        {
            this.limInf = limInf;
            this.limSup = limSup;
            this.marcaClase = (limInf + limSup) / 2;
            this.frecuenciaRelativa = 0;
            this.frecuenciaAbsoluta = 0;
            this.valor = 0;
        }


        public Intervalo(double limInf, double limSup, int id) : this(limInf, limSup)
        {
            this.intervaloId = id;
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

        public void fucionarIntervalo(Intervalo i)
        {

            this.limInf = (this.limInf < i.limInf) ? this.limInf : i.limInf;
            this.limSup = (this.limSup > i.limSup) ? this.limSup : i.limSup;

            
            this.frecuenciaAbsoluta += i.frecuenciaAbsoluta;
            this.frecuenciaEsperada += i.frecuenciaEsperada;   
        }
    }
}
