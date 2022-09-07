using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.TP3.Distribuciones
{
    public class Poisson : Distribucion
    {
        public double lambda { get; set; }                                                                                                                                                                                      
        public List<double> random { get; set; }

        public List<int> variables { get; set; }

        public Random generador { get; set; }

        public int muestra { get; set; }

        public Poisson(int muestra, double lambda)
        {
            this.lambda = lambda;
            this.random = random;
            this.generador = new Random();
            this.muestra = muestra;
        }

        public List<double> generarVariables()
        {
            throw new NotImplementedException();
        }


        public List<int> generarVariablesPoisson()
        {
            this.variables = new List<int>();
            for(int i = 0; i < muestra; i++)
            {
         
                variables.Add(this.generarValorPoisson(this.lambda));
            }

            return this.variables;
        }


        public int generarValorPoisson(double lambda) {
            double p = 1;
            int x = -1;

            double a = Math.Pow(Math.E, -lambda);
            do {
                double u = this.generador.NextDouble();
                p *= u ;
                x++;
            } while (p >= a);

            return x;
        }
    }



}
