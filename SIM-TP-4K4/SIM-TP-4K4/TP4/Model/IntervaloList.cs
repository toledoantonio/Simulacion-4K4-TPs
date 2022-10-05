using SIM_TP_4K4.TP1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.TP4.Model
{
    public class IntervaloList
    {
        public List<Intervalo> intervalos { get; set; }

        public double frecuenciaEsperada { get; set; }

        public IntervaloList(List<double> valores)
        {
            intervalos = new List<Intervalo>();
            this.construirIntervalos(valores);
            this.sumarPrimeros(valores);
        }

        public void construirIntervalos(List<double> valores)
        {

            double limInf = 0;

            for (int i = 0; i < valores.Count; i++)
            {
               
                double limSup = Util.truncar(valores[i]) - 0.0001;
                Intervalo intervalo = new Intervalo(limInf, limSup);
                intervalos.Add(intervalo);
                limInf = Util.truncar(valores[i]);
            }

            Intervalo ultime = new Intervalo(valores.Last());
            intervalos.Add(ultime);
        }

        public void sumarPrimeros(List<double> valores)
        {
            int count = 1;
            valores.ForEach((x) => this.actualizarIntervalos(x, count, count-1));
        }

        public void actualizarIntervalos(double random, int orden, int ordenAnterior)
        {
            foreach (Intervalo i in intervalos)
            {
                if (i.contieneNum(random))
                {
                    i.contarFrecuencia(orden, ordenAnterior, 1);
                }
                else
                {
                    i.contarFrecuencia(orden, ordenAnterior, 0);
                }
            }
        }

        public object[] getValores(int orden)
        {
            object[] data = new object[17];
            data[0] = orden;
            for(int i=0; i < intervalos.Count(); i++)
            {
                data[i + 1] = Util.truncar(intervalos[i].frecuenciaRelativa);
            }
            return data;
        }

        public string[] getTitulos()
        {
            return intervalos.Select(intervalo => intervalo.intervaloTitulo()).ToArray();
        } 

        public void setFrecuenciaEsperada(double fEsperada)
        {
            this.frecuenciaEsperada = Util.truncar(fEsperada);
        }

    }
}
