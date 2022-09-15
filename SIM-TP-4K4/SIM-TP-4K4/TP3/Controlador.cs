
using SIM_TP_4K4.Model;
using SIM_TP_4K4.TP1.Model;
using SIM_TP_4K4.TP3.Distribuciones;
using SIM_TP_4K4.TP3.Pruebas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Windows.Forms;

namespace SIM_TP_4K4.TP3
{
    public class Controlador
    {
        public List<double> listaRnd { get; set; }

        public List<double> variables { get; set; }

        public List<int> variablesPoisson { get; set; }

        public IntervaloList intervalos { get; set; }
        public int muestra { get; set; }

        public double desviacion { get; set; }
        public double media { get; set; }

        public double lambda { get; set; }

        public Distribucion distribucion { get; set; }

        public int cantidadIntervalos { get; set; }

        public int distro { get; set; }

        public Controlador(int muestra,  double media, double desviacion, double lambda, int cantidadIntervalos, int distro)
        {
            this.muestra = muestra;
            this.desviacion = desviacion;
            this.media = media;
            this.lambda = lambda;
            this.listaRnd = new List<double>();
            this.generarRnd(muestra);
            this.setDistribucion(distro);
            this.generarVariables(distro);
            this.intervalos = (distro < 2) ? new IntervaloList(this.variables, cantidadIntervalos) : new IntervaloList(this.variablesPoisson, cantidadIntervalos);
            this.intervalos.contarFE(distro, media, desviacion, lambda, muestra);
            this.cantidadIntervalos = cantidadIntervalos;
            this.distro = distro;
        }


        public void generarRnd(int tamañoMuestra)
        {
            Random random = new Random();
            for (int i=0; i < tamañoMuestra; i++)
            {
                this.listaRnd.Add(random.NextDouble());

            }

        }

        public void generarVariables(int distro)
        {
            if (distro < 2) {
                this.variables = this.distribucion.generarVariables();
            } else
            {
                Console.WriteLine("HA");
                this.variablesPoisson = this.distribucion.generarVariablesPoisson();
            }
            
        }


        public void setDistribucion(int dist) {
            switch(dist)
            {
                case 0:
                    this.distribucion = new Normal(this.muestra, this.media, this.desviacion, this.listaRnd) ;
                    break;
                case 1:
                    this.distribucion = new Exponencial(this.muestra, this.media ,this.lambda, this.listaRnd);
                    break;
                case 2:
                    this.distribucion = new Poisson(this.muestra, this.lambda);
                    break;
            }
        }

        public List<object[]> realizarPrueba(int idPrueba, Label lblValorCriticoResultado, Label lblValorEstadisticoResultado, Label lblPruebaAjusteResultado)
        {
            List<object[]> resultado = new List<object[]>();

            switch (idPrueba)
            {
                case 0:
                    resultado = (new PruebaChiCuadrado(this.intervalos.reducir(distro), lblValorCriticoResultado, lblValorEstadisticoResultado, lblPruebaAjusteResultado, cantidadIntervalos, distro)).calcular(distro);
                    break;

                case 1:
                    resultado = (new PruebaKS(this.intervalos, lblValorCriticoResultado, lblValorEstadisticoResultado, lblPruebaAjusteResultado, muestra)).calcular();
                    break;
            }

            return resultado;
        }


        public List<object[]> getIntervalos()
        {
            if(distro < 2)
            {
                return this.intervalos.intervalos.Select((x) => new object[] { x.limInf, x.limSup, x.frecuenciaAbsoluta, x.frecuenciaEsperada }).ToList();
            } else
            {
                return this.intervalos.intervalos.Select((x) => new object[] { ((ValorPoisson)x).valor, x.frecuenciaAbsoluta, x.frecuenciaEsperada }).OrderBy((x) => x[0]).ToList();

            }
        }


        public List<object[]> obtenerDatosGrafica()
        {
            List<object[]> datosGrafica = new List<object[]>();
            intervalos.intervalos.ForEach((x) => datosGrafica.Add( new object[3] { x.frecuenciaAbsoluta, x.frecuenciaEsperada, x.marcaClase } )); 
            return datosGrafica;
        }
        
        public void generarIntervalos()
        {
            
        }

    }
}
