using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SIM_TP_4K4.Model;
using SIM_TP_4K4.TP1.Model;

namespace SIM_TP_4K4.Generador
{
    public class CongruencialMixto : IGenerador
    {
        static readonly double ajusteCantidadDecimales = Math.Pow(10, 4);
        public int cteA { get; set; }
        public int cteC { get; set; }

        public int semilla { get; set; }

        public int moduloM { get; set; }

        public long tamMuestra { get; set; }

        public int cantIntervalos { get; set; }
        public double amplitudIntervalos { get; set; }

        public CongruencialMixto(int cteC, int semilla, int g, int k, long tamMuestra, int cantIntervalos)
        {
            this.cteA = 1 + 4 * k;
            this.cteC = cteC;
            this.semilla = semilla;
            this.moduloM = (int) Math.Pow(2, g);
            this.tamMuestra = tamMuestra;
            this.cantIntervalos = cantIntervalos;
            this.amplitudIntervalos = 1 / cantIntervalos;

        }

        public CongruencialMixto(int cteA, int cteC, int semilla, int moduloM, int cantIntervalos)
        {
            this.cteA = cteA;
            this.cteC = cteC;
            this.semilla = semilla;
            this.moduloM = moduloM;
            this.cantIntervalos = cantIntervalos;
            this.amplitudIntervalos = 1 / cantIntervalos;
        }


        public List<Iteracion> generarPseudoAleatorios(int cantidad)
        {
            List<Iteracion> result = new List<Iteracion>();
            int xi = this.semilla;
            IntervaloList intervalos = new IntervaloList(this.cantIntervalos, this.amplitudIntervalos);

            for (int i = 0; i < cantidad; ++i)
            {


                int xiSiguiente = ((xi * this.cteA) + this.cteC) % this.moduloM;
                double rnd =((double)xiSiguiente / (double) this.moduloM);
                rnd = Math.Truncate(rnd * ajusteCantidadDecimales) / ajusteCantidadDecimales;
               
                intervalos.actualizarIntervalos(rnd, i + 1, i);
                int[]  intervalosValue = intervalos.getValores();


                Iteracion pseudoAleatorio = new Iteracion(xiSiguiente, rnd, i + 1, intervalos.getValores());
                result.Add(pseudoAleatorio);
                xi = xiSiguiente;
            }

            return result;
        }

        public Iteracion siguientePseudoAleatorio()
        {
            return new Iteracion();
        }

    }
}
