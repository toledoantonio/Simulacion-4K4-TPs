using SIM_TP_4K4.Model;
using SIM_TP_4K4.TP1.Model;
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

        public int xi { get; set; }

        public int moduloM { get; set; }

        public long tamMuestra { get; set; }
        
        public int cantIntervalos { get; set; }

        public double amplitudIntervalos { get; set; }

        public VectorEstado vector { get; set; }

        public bool feRelativa;

        public int orden { get; set; }

        public CongruencialMultiplicativo(int cteA, int semilla, int moduloM, int cantIntervalos, bool feRelativa, int k, int g)
        {
            this.cteA = (cteA == 0) ? 3 + 8 * k : cteA;
            this.xi = semilla;
            this.moduloM = (moduloM == 0) ? (int)Math.Pow(2, g) : moduloM;
            this.cantIntervalos = cantIntervalos;
            this.amplitudIntervalos = 1 / (double)cantIntervalos;
            this.feRelativa = feRelativa;
            this.orden = 1;
            this.vector = new VectorEstado(this.xi, this.cantIntervalos, this.amplitudIntervalos);
        }

        public List<object[]> generarPseudoAleatorios(int cantidad)
        {
            List<object[]> result = new List<object[]>();

            for (int i = 0; i < cantidad; ++i)
            {
                result.Add(siguientePseudoAleatorio());
            }

            return result;
        }

        public object[] siguientePseudoAleatorio()
        {
            int xiSiguiente = ((vector.xi * this.cteA)) % this.moduloM;
            vector.xi = xiSiguiente;

            double rnd = ((double)xiSiguiente / (double)this.moduloM);
            rnd = Util.truncar(rnd);

            vector.rnd = rnd;

            vector.actualizar(orden);

            object[] data = vector.getDatos(orden, feRelativa);
            ++orden;
            return data;
        }

        public IntervaloList getVectorIntervalos()
        {
            return this.vector.intervalos;
        }
    }
}
