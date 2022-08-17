using SIM_TP_4K4.Model;
using SIM_TP_4K4.TP1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.Generador
{
    public class Aditivo : IGenerador
    {
        public int xi { get; set; }
        public int xiAnterior { get; set; }
        public int moduloM { get; set; }
        public bool feRelativa { get; set; }
        public int cantidadIntervalos { get; set; }
        public VectorEstado vector { get; set; }
        public int orden { get; set; }
        public double amplitudIntervalos { get; set; }
        private object[] primer { get; set; }

        public Aditivo(int semilla, int semillaAnterior, int moduloM, bool feRelativa, int cantidadIntervalos)
        {
            this.xi = semilla;
            this.xiAnterior = semillaAnterior;
            this.moduloM = moduloM;
            this.feRelativa = feRelativa;
            this.cantidadIntervalos = cantidadIntervalos;
            this.amplitudIntervalos = 1 / (double) cantidadIntervalos;
            this.orden = 1;
            this.vector = new VectorEstado(xi, xiAnterior, cantidadIntervalos, amplitudIntervalos);
            this.primer = this.siguientePseudoAleatorio();
        }

        public List<object[]> generarPseudoAleatorios(int n)
        {
            List<object[]> result = new List<object[]>();
            result.Add(this.primer);
            for (int i = 0; i < n; ++i)
            {
                result.Add(siguientePseudoAleatorio());
            }

            return result;
        }

        public IntervaloList getVectorIntervalos()
        {
            return this.vector.intervalos;
        }

        public object[] siguientePseudoAleatorio()
        {
            int suma = vector.xi + vector.xi_1;

            
            double rnd = ((double) (suma % moduloM) / (double) (this.moduloM));
            rnd = Util.truncar(rnd);
            
            vector.rnd = rnd;
            vector.actualizar(orden);

            object[] data = vector.getDatosAditivo(orden, feRelativa);

            vector.xi_1 = vector.xi;
            vector.xi = (suma) % moduloM;

            ++orden;
            return data;
        }
    }
}
