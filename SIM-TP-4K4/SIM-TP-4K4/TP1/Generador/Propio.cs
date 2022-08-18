using SIM_TP_4K4.Generador;
using SIM_TP_4K4.TP1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.TP1.Generador
{
    public class Propio: IGenerador
    {
        public long tamMuestra { get; set; }

        public int cantIntervalos { get; set; }

        public double amplitudIntervalos { get; set; }


        public bool feRelativa;

        public int orden { get; set; }

        public VectorEstado vector { get; set; }
        public Random generador { get; set; }

        public Propio(int muestra, int cantIntervalos, bool feRelativa)
        {
            this.tamMuestra = muestra;
            this.cantIntervalos = cantIntervalos;
            this.amplitudIntervalos = 1 / (double)cantIntervalos;
            this.feRelativa = feRelativa;
            this.orden = 1;
            this.vector = new VectorEstado(0, this.cantIntervalos, this.amplitudIntervalos);
            this.generador = new Random();
        }

        public List<object[]> generarPseudoAleatorios(int n)
        {
            List<object[]> result = new List<object[]>();
            
            for (int i = 0; i < n; ++i)
            {
                result.Add(siguientePseudoAleatorio());
            }

            return result;
        }

        public object[] siguientePseudoAleatorio()
        {
            double rnd = generador.NextDouble();
            rnd = Util.truncar(rnd);
            this.vector.rnd = rnd;
            this.vector.actualizar(orden);
            object[] result = this.vector.getDatosC(orden, feRelativa);
            ++orden;
            return result;
        }

        public IntervaloList getVectorIntervalos()
        {
            return this.vector.intervalos;
        }
    }
}
