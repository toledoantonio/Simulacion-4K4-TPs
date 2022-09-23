using SIM_TP_4K4.TP3.Distribuciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.TP4.Controlador
{
    public class ControladorMonteCarlo
    {


        public List<double> randoms1 { get; set; }
        public List<double> randoms2 { get; set; }
        public List<double> randoms3 { get; set; }
        public List<double> randoms4 { get; set; }
        public List<double> randoms5 { get; set; }

        public Random generador { get; set; }

        public Dictionary<int, Distribucion> distribuciones { get; set; }

        public VectorEstado vectorEstado { get; set; }

        public int simulaciones { get; set; }

        public ControladorMonteCarlo(int simulaciones, double[] infoT1, double[] infoT2, double[] infoT3, double[] infoT4, double[] infot5)
        {
            this.distribuciones = new Dictionary<int, Distribucion>() {
                { 0, new Exponencial() },
                { 1, new Uniforme() }
            };

            this.vectorEstado = new VectorEstado(this.distribuciones, infoT1, infoT2, infoT3, infoT4, infot5);
            this.generador = new Random();
                
            this.randoms1 = generarRandoms(simulaciones);
            this.randoms2 = generarRandoms(simulaciones);
            this.randoms3 = generarRandoms(simulaciones);
            this.randoms4 = generarRandoms(simulaciones);
            this.randoms5 = generarRandoms(simulaciones);
            this.simulaciones = simulaciones;
        }

        public  List<double> generarRandoms(int simulaciones)
        {
           
            List<double> rnd = new List<double>();
            for (int i = 0; i < simulaciones; i++) { 
                rnd.Add(generador.NextDouble());
            }

            return rnd;
        }

        public List<object[]> simular(int desde, int hasta)
        {
            List<object[]> datosFacheros = new List<object[]>();
            for(int i = 0; i < simulaciones; i++)
            {
                if (i >= desde && i <= hasta)
                {
                    datosFacheros.Add(vectorEstado.getActualVectorAsObject());
                }

                vectorEstado.siguienteSimulacion(randoms1[i], randoms2[i], randoms3[i], randoms4[i], randoms5[i]);

            }

            return datosFacheros;
        }
        
    }
}