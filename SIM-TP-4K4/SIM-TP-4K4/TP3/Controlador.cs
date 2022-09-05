
using SIM_TP_4K4.TP1.Model;
using SIM_TP_4K4.TP3.Distribuciones;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SIM_TP_4K4.TP3
{
    public class Controlador
    {
        public List<double> listaRnd { get; set; }

        public List<double> variables { get; set; }
        public int muestra { get; set; }

        public double desviacion { get; set; }
        public double media { get; set; }

        public Distribucion distribucion { get; set; }


        public Controlador()
        {
            this.setDistribucion(0);
        }

        public Controlador(int muestra, double desviacion, double media)
        {
            this.muestra = muestra;
            this.desviacion = desviacion;
            this.media = media;
            this.listaRnd = new List<double>();
            this.generarRnd(muestra);
            this.setDistribucion(0);
            this.generarVariables();
        }


        public void generarRnd(int tamañoMuestra)
        {
            Random random = new Random();
            for (int i=0; i < tamañoMuestra; i++)
            {
                this.listaRnd.Add(random.NextDouble());

            }

        }

        public void generarVariables()
        {
            this.variables = this.distribucion.generarVariables();
        }


        public void setDistribucion(int dist) {
            switch(dist)
            {
                case 0:
                    this.distribucion = new Normal(this.muestra, this.media, this.desviacion, this.listaRnd) ;
                    break;
            }
        }
    }
}
