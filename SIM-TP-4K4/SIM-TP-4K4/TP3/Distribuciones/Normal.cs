using SIM_TP_4K4.TP1.Model;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TP_4K4.TP3.Distribuciones
{
    public class Normal : Distribucion
    {
        public double media { get; set; }
        public double desviacion { get; set; }
        public int muestra { get; set; }
        public List<double> randoms { get; set; }
        public List<double> variables { get; set; }

        public double max { get; set; }
        public double min { get; set; }
        public bool isImpar { get; set; }
        public Normal(int muestra, double media, double desviacion, List<double> randoms)
        {
            this.isImpar = false;
            this.muestra = muestra;
            this.media = media;
            this.desviacion = desviacion;
            this.randoms = randoms;
            this.esImpar();
        }


        public List<Double> generarVariables()
        {
            this.variables = new List<double>();
            for (int i = 0; i < this.muestra; i += 2)
            {
                double variable1 = Util.truncar(((this.calcualrFormula1((double)randoms[i], (double)randoms[i + 1])) * desviacion + media));
                double variable2 = Util.truncar(((this.calcularFormula2((double)randoms[i], (double)randoms[i + 1])) * desviacion + media));
                this.variables.Add(variable1);
                this.variables.Add(variable2);
            }

            if (this.isImpar)
            {
                this.variables.RemoveAt(this.muestra - 1);
                this.randoms.RemoveAt(this.muestra - 1);
            }

            return this.variables;
        }


        public double calcualrFormula1(double random1, double random2)
        {

            double logaritmo = Math.Log(random1);
            double raiz = Math.Sqrt((-2) * logaritmo);
            double seno = Math.Sin(2 * Math.PI * random2);

            double variable = raiz * seno;
            return variable;
        }

        public double calcularFormula2(double random1, double random2)

        {
            double logaritmo = Math.Log(random1);
            double raiz = Math.Sqrt((-2) * logaritmo);
            double cos = Math.Cos(2 * Math.PI * random2);

            double variable = raiz * cos;
            return variable;
        }

        public void esImpar()
        {
            if (this.muestra % 2 != 0)
            {
                this.isImpar = true;
                this.muestra = this.muestra++;
                this.randoms.Add((new Random()).NextDouble());
            }
        }

        public List<int> generarVariablesPoisson()
        {
            throw new NotImplementedException();
        }

       
    }
}
