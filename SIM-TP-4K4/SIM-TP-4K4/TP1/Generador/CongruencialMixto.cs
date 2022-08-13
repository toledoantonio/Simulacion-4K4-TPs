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
        public int cteA { get; set; }
        public int cteC { get; set; }

        public int xi { get; set; }

        public int moduloM { get; set; }

        public long tamMuestra { get; set; }

        public int cantIntervalos { get; set; }
        public double amplitudIntervalos { get; set; }

        public IntervaloList intervalos { get; set; }

        public bool feRelativa;
        
        public int orden { get; set; }


        public CongruencialMixto(int cteA, int cteC, int semilla, int moduloM, int cantIntervalos, bool feRelativa, int k, int g)
        {
            this.cteA = (cteA == 0) ? 1 + 4 * k : cteA;
            this.cteC = cteC;
            this.xi = semilla;
            this.moduloM = (moduloM == 0) ? (int)Math.Pow(2, g) : moduloM ;
            this.cantIntervalos = cantIntervalos;
            this.amplitudIntervalos = 1 / (double) cantIntervalos;
            this.feRelativa = feRelativa;
            this.orden = 1;
            this.intervalos = new IntervaloList(this.cantIntervalos, this.amplitudIntervalos);
        }


        public List<Iteracion> generarPseudoAleatorios(int cantidad)
        {
            List<Iteracion> result = new List<Iteracion>();

            for (int i = 0; i < cantidad; ++i)
            {
    
                result.Add(siguientePseudoAleatorio());
                
            }

            return result;
        }

        public Iteracion siguientePseudoAleatorio()
        {
            int xiSiguiente = ((xi * this.cteA) + this.cteC) % this.moduloM;
            xi = xiSiguiente;
            double rnd = ((double)xiSiguiente / (double)this.moduloM);
            rnd = Util.truncar(rnd);
            intervalos.actualizarIntervalos(rnd, orden, orden - 1);
            string[] valoresInteracion = (feRelativa) ? intervalos.getValoresRelativa() : intervalos.getValoresAbsoluta();
            Iteracion it =  new Iteracion(xiSiguiente, rnd, orden, valoresInteracion);
            ++orden;
            return it;
        }

        public IntervaloList getVectorIntervalos()
        {
            return this.intervalos;
        }

    }
}
