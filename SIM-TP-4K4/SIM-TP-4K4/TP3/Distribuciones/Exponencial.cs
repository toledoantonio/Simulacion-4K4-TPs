using SIM_TP_4K4.TP1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.TP3.Distribuciones
{
    public class Exponencial: Distribucion
    {
        public double media { get; set; }
        public double lambda { get; set; }
        public int muestra { get; set; }
        public List<double> randoms { get; set; }
        public List<double> variables { get; set; }

        public double max { get; set; }
        public double min { get; set; }


        public Exponencial() { 
        
        }

        public Exponencial(int muestra, double media, double lambda, List<double> randoms)
        {
            this.muestra = muestra;
            this.media = media;
            this.lambda = lambda;
            this.randoms = randoms;

        }

        public List<double> generarVariables()
        {
            double multiplicador = (media == 0) ? 1 / lambda : media;

            this.variables = new List<double>();
            for (int i = 0; i < this.muestra; i ++)
            {
                double variable = calcularVariable(randoms[i], multiplicador);
                variables.Add(variable);
            }

            return variables;
        }

        public double calcularVariable(double random, double multiplicador) {
            double log = Math.Log(1 - random);
            double variable = - multiplicador * log;

            return Util.truncar(variable);
        }

        public double generarVariable(double media, double lambda, double random) {
            double multiplicador = (media == 0) ? 1 / lambda : media; 
            return calcularVariable(random, multiplicador); ;
        }

        public List<int> generarVariablesPoisson()
        {
            throw new NotImplementedException();
        }
    }
}
