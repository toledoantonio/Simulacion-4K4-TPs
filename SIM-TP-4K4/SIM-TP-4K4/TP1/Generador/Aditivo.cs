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
        public IntervaloList intervalos { get; set; }
        public int orden { get; set; }
        public double amplitudIntervalos { get; set; }

        public Aditivo(int semilla, int semillaAnterior, int moduloM, bool feRelativa, int cantidadIntervalos)
        {
            this.xi = semilla;
            this.xiAnterior = semillaAnterior;
            this.moduloM = moduloM;
            this.feRelativa = feRelativa;
            this.cantidadIntervalos = cantidadIntervalos;
            this.amplitudIntervalos = 1 / (double) cantidadIntervalos;
            this.orden = 1;
            this.intervalos = new IntervaloList(this.cantidadIntervalos, this.amplitudIntervalos);
        }

        public List<Iteracion> generarPseudoAleatorios(int n)
        {
            List<Iteracion> result = new List<Iteracion>();

            for (int i = 0; i < n; ++i)
            {

                result.Add(siguientePseudoAleatorio());

            }

            return result;
        }

        public IntervaloList getVectorIntervalos()
        {
            return this.intervalos;
        }

        public Iteracion siguientePseudoAleatorio()
        {
            int suma = xi + xiAnterior;
            xiAnterior = xi;
            xi = (suma) % moduloM;
            double rnd = ((double) xi / (double) this.moduloM);
            rnd = Util.truncar(rnd);
            intervalos.actualizarIntervalos(rnd, orden, orden - 1);
            string[] valoresInteracion = (feRelativa) ? intervalos.getValoresRelativa() : intervalos.getValoresAbsoluta();
            Iteracion it = new Iteracion(xi, rnd, orden, valoresInteracion);
            ++orden;
            return it;
        }
    }
}
