using SIM_TP_4K4.TP3.Distribuciones;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TP_4K4.TP4.Controlador
{
    public class ControladorMonteCarlo
    {
        public List<double> randoms1 { get; set; }
        public List<double> randoms2 { get; set; }
        public List<double> randoms3 { get; set; }
        public List<double> randoms4 { get; set; }
        public List<double> randoms5 { get; set; }
        public List<object[]> intervalos { get; set; }

        public Random generador { get; set; }

        public Dictionary<int, Distribucion> distribuciones { get; set; }

        public VectorEstado vectorEstado { get; set; }

        public int simulaciones { get; set; }

        public ToolStripProgressBar pbar { get; set; }

        public ControladorMonteCarlo(int simulaciones, double[] infoT1, double[] infoT2, double[] infoT3, double[] infoT4, double[] infot5, ToolStripProgressBar progressBar)
        {
            this.distribuciones = new Dictionary<int, Distribucion>() {
                { 0, new Exponencial() },
                { 1, new Uniforme() }
            };

            this.vectorEstado = new VectorEstado(this.distribuciones, infoT1, infoT2, infoT3, infoT4, infot5);
            this.generador = new Random();
            this.intervalos = new List<object[]>();
            this.randoms1 = generarRandoms(simulaciones);
            this.randoms2 = generarRandoms(simulaciones);
            this.randoms3 = generarRandoms(simulaciones);
            this.randoms4 = generarRandoms(simulaciones);
            this.randoms5 = generarRandoms(simulaciones);
            this.simulaciones = simulaciones;

            this.pbar = progressBar;
        }

        public  List<double> generarRandoms(int simulaciones)
        {
           
            List<double> rnd = new List<double>();
            for (int i = 0; i < simulaciones; i++) { 
                rnd.Add(generador.NextDouble());;
            }
            return rnd;
        }

        public List<object[]> simular(int desde, int hasta)
        {
            List<object[]> datosSimulacion = new List<object[]>();
            for(int i = 0; i < simulaciones; i++)
            {
                vectorEstado.siguienteSimulacion(randoms1[i], randoms2[i], randoms3[i], randoms4[i], randoms5[i]);

                if ((i >= desde - 1 && i <= hasta) || i == simulaciones - 1)
                {
                    datosSimulacion.Add(vectorEstado.getActualVectorAsObject());
                    if (i > 15 || i == simulaciones - 1)
                    {
                     this.intervalos.Add(vectorEstado.getValoresIntervalos());
                    }
                }
                this.pbar.Value++;
            }
            return datosSimulacion;
        }

        public List<object[]> fechaConfianza90()
        {
            return vectorEstado.calcularFechaConfianza90();
        }

        public List<double> obtenerPromedios()
        {
            return vectorEstado.tiemposPromedio;
        }

        public object[] ultimaSimulacion()
        {
            return vectorEstado.getActualVectorAsObject();
        }

        public string[] getTitulosIntervalos()
        {
            return vectorEstado.getTitulosIntervalos();
        }

        public object[] getResultados()
        {
            bool bandera = false;
            object[] resultados = new object[17];
            resultados[0] = "Acumulados: ";
            double result = 0;
            object[] ultimos = this.intervalos.Last();
            for(int i = 1; i <  ultimos.Length; i++)
            {
                result += (double)ultimos[i];
                resultados[i] = result;
                if (result > 0.9 && !bandera)
                {
                    resultados[16] = i;
                    bandera = true;
                }
            }
            return resultados;
        }
    }
}