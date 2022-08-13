using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SIM_TP_4K4.Model;

namespace SIM_TP_4K4.Generador
{
    public class CongruencialMixto : IGenerador
    {
        public int cteA { get; set; }
        public int cteC { get; set; }

        public int semilla { get; set; }

        public int moduloM { get; set; }

        public long tamMuestra { get; set; }

        public CongruencialMixto(int cteC, int semilla, int g, int k, long tamMuestra)
        {
            this.cteA = 1 + 4 * k;
            this.cteC = cteC;
            this.semilla = semilla;
            this.moduloM = (int) Math.Pow(2, g);
            this.tamMuestra = tamMuestra;
        }

        public CongruencialMixto(int cteA, int cteC, int semilla, int moduloM)
        {
            this.cteA = cteA;
            this.cteC = cteC;
            this.semilla = semilla;
            this.moduloM = moduloM;
        }


        public List<PseudoAleatorio> generarPseudoAleatorios(int cantidad)
        {
            List<PseudoAleatorio> result = new List<PseudoAleatorio>();
            int xi = this.semilla;

            for (int i = 0; i < cantidad; ++i)
            {
                int xiSiguiente = ((xi * this.cteA) + this.cteC) % this.moduloM;
                PseudoAleatorio pseudoAleatorio = new PseudoAleatorio(xiSiguiente, this.moduloM);
                result.Add(pseudoAleatorio);
                xi = xiSiguiente;
            }

            return result;
        }

        public PseudoAleatorio siguientePseudoAleatorio()
        {

        }

    }
}
