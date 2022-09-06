using SIM_TP_4K4.Model;
using SIM_TP_4K4.TP1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SIM_TP_4K4.TP3
{
    public class IntervaloList
    {
        public List<Intervalo> intervalos { get; set; }
        public int cantidadIntervalos { get; set; }
        public List<double> variables { get; set; }

        public IntervaloList(List<double> variables, int cantidadIntervalos)
        {
            this.cantidadIntervalos = cantidadIntervalos;
            this.variables = variables;
            this.intervalos = new List<Intervalo>();
            this.construirIntervalos(variables);
            this.contarFO();
        }

        public void construirIntervalos(List<double> variables)
        {
            Intervalo intervalo;

            double min = variables.Min();
            double max = variables.Max();



            double limInf = min;

            double amplitud = (max - min) / this.cantidadIntervalos;
            for (int i = 0; i < cantidadIntervalos - 1; i++)
            {
                double limSup = ((limInf) + amplitud);
                limSup = Util.truncar(limSup);
                limInf = Util.truncar(limInf);

                intervalo = new Intervalo(limInf, limSup, i);
                intervalos.Add(intervalo);

                limInf = limSup;
            }
            intervalo = new Intervalo(limInf, max + 0.0001);
            intervalos.Add(intervalo);

        }


        public void contarFO()
        {
            foreach (double num in variables)
            {
                foreach (Intervalo i in intervalos)
                {
                    if (i.contieneRnd(num))
                    {
                        i.contarAbsoluta(1);
                        break;
                    }
                }
            }
        }

        public void contarFR(int tamañoMuestra)
        {
            foreach (Intervalo i in intervalos)
            {
                i.frecuenciaRelativa = ((double)i.frecuenciaAbsoluta) / tamañoMuestra;
                i.frecuenciaRelativaEsperada = i.frecuenciaEsperada / tamañoMuestra;
            }
        }




        public void contarFE(int distribucion, double media, double desviacion, double lambda, int tamañoMuestra)
        {
            switch (distribucion)
            {
                case 0:
                    contarFENormal(media, desviacion);
                    break;
                case 1:
                    contarFEEXP(media, lambda, tamañoMuestra);
                    break;
            }
        }

        private void contarFENormal(double media, double desviacion)
        {
            foreach (Intervalo i in intervalos)
            {
                double mc = (i.limSup + i.limInf) / 2;
                double part1 = Math.Pow((mc - media) / desviacion, 2);
                double part2 = -0.5 * part1;
                double part3 = Math.Pow(Math.E, part2);
                double part4 = desviacion * Math.Sqrt(2 * Math.PI);
                double fe = (part3 / part4) * (i.limSup - i.limInf) * variables.Count;
                i.frecuenciaEsperada = Util.truncar(fe);
            }
        }

        private void contarFEEXP(double media, double lambda, int tamañoMuestra)
        {
            lambda = (lambda == 0) ? 1 / media : lambda;

            foreach (Intervalo i in intervalos)
            {
                i.frecuenciaEsperada = Math.Round(((1 - Math.Pow(Math.E, (-lambda * i.limSup))) - (1 - Math.Pow(Math.E, (-lambda * i.limInf)))) * tamañoMuestra);
            }
        }


        public List<Intervalo> reducir()
        {
            List<Intervalo> aux = new List<Intervalo>(this.intervalos);
            List<Intervalo> reducidos = new List<Intervalo>();
            int prueba = 0;
            for (int i = 0; i < intervalos.Count; i++)
            {


                if (intervalos[i].frecuenciaEsperada > 5)
                {
                    reducidos.Add(aux[i]);
                    prueba++;
                }
                else
                {
                    if (i + 1 != intervalos.Count)
                    {
                        int cantidadPruebas = 0;
                        for (int j = i + 1; j < intervalos.Count; j++)
                        {
                            aux[i].fucionarIntervalo(aux[j]);
                            if (aux[i].frecuenciaEsperada > 5)
                            {
                                reducidos.Add(aux[i]);
                                cantidadPruebas += 2;

                                prueba += cantidadPruebas;
                                i = j;
                                break;
                            }
                            else
                            {
                                cantidadPruebas++;
                            }
                        }
                    }
                }
            }


            int faltantes = (this.intervalos.Count - prueba);

            
            
            if (faltantes > 0)
            { 
                reducidos[reducidos.Count - 1].fucionarIntervalo(aux[intervalos.Count - faltantes]);
            }

            return reducidos;
        }
    }
}
