using SIM_TP_4K4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.Generador
{
    public class CongruencialMultiplicativo : IGenerador
    {
        public int cteA { get; set; }

        public int semilla { get; set; }

        public int moduloM { get; set; }

        public long tamMuestra { get; set; }

        public CongruencialMultiplicativo(int semilla, int g, int k, int tamMuestra)
        {
            this.cteA = 3 + 8 * k;
            this.semilla = semilla;
            this.moduloM = (int) Math.Pow(2, g);
            this.tamMuestra = tamMuestra;
        }

        public CongruencialMultiplicativo(int cteA, int semilla, int moduloM, long tamMuestra)
        {
            this.cteA = cteA;
            this.semilla = semilla;
            this.moduloM = moduloM;
            this.tamMuestra = tamMuestra;
        }
        /*
        public List<Iteracion> generarPseudoAleatorios()
        {
            List<Iteracion> result = new List<Iteracion>();
            int xi = this.semilla;

            for (int i = 0; i < tamMuestra; ++i)
            {
                int xiSiguiente = (this.cteA * xi) % this.moduloM;
                Iteracion pseudoAleatorio = new PseudoAleatorio(xiSiguiente, this.moduloM);
                result.Add(pseudoAleatorio);
                xi = xiSiguiente;
            }

            return result;
        }*/

     

        public List<Iteracion> generarPseudoAleatorios(int n)
        {
            throw new NotImplementedException();
        }

        public Iteracion siguientePseudoAleatorio()
        {
            throw new NotImplementedException();
        }
    }
}
