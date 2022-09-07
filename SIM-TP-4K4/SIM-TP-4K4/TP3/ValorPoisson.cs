using SIM_TP_4K4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.TP3
{
    public class ValorPoisson : Intervalo
    {

        public int valor { get; set; }

        public double prob { get; set; }
       

        public string titulo { get; set; }

        public ValorPoisson(int valor) {
            this.valor = valor;
            this.titulo = $"{valor}";
        }

        public void contarAbsoluta(int obs)
        {
            this.frecuenciaAbsoluta += obs;
        }

        public string intervaloTitulo()
        {
            return this.titulo;
        }

        public void fusionarIntervalo(Intervalo i)
        {
            ValorPoisson valor = (ValorPoisson) i;
            frecuenciaAbsoluta += valor.frecuenciaAbsoluta;
            frecuenciaEsperada += valor.frecuenciaEsperada;

            this.titulo = titulo + ", " + ((ValorPoisson)i).valor;
                
        }

        public bool esValor(int valor)
        {
            return valor == this.valor;
        }

        public void calcularProbabilidad(double lambda)
        {
            double potencia = Math.Pow(lambda, this.valor);
            double exp = Math.Exp(-lambda);
            double factorial = this.factorial(this.valor);

            this.prob = (potencia * exp) / factorial;
        }

        private double factorial(int number)
        {
            if (number == 0)
                return 1;
            else
            {
                return number * factorial(number - 1);
            }
        }

        public void calcularFe(int muestra)
        {
            this.frecuenciaEsperada = Math.Round(this.prob *  muestra, 0);
        }

    }
}
