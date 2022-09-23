using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.TP3.Distribuciones
{
    public class Uniforme:Distribucion
    {
        public double limInf { get; set; }

        public double limSup { get; set; }

        public List<double>  randoms { get; set; }

        public Uniforme() { 
        }

        public Uniforme(double limInf, double limSup, List<double> Rnd) { 

            this.limInf = limInf;
            this.limSup = limSup;
            this.randoms = Rnd;

        }

        public double generarVariable(double limInf, double limSup, double random) {
            double resta = limSup - limInf;
            double multiplicador = resta * random;
            double variable = limInf + multiplicador;
            return variable;
        }

        public List<double> generarVariables()
        {
            throw new NotImplementedException();
        }

        public List<int> generarVariablesPoisson()
        {
            throw new NotImplementedException();
        }
    }
}
