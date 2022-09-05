using SIM_TP_4K4.Model;
using SIM_TP_4K4.TP1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.TP3.Pruebas
{
    public class PruebaChiCuadrado
    {
        public IntervaloList intervalos { get; set; }


        public PruebaChiCuadrado(IntervaloList intervalos)
        {
            this.intervalos = intervalos;
        }

        public List<Object[]> calcular()
        {
            List<Object[]> datos = new List<Object[]>();
            double anterior = 0;
            foreach (Intervalo it in intervalos.intervalos)
            {
                Object[] datosFila = new Object[8];
                Console.WriteLine(it.intervaloTitulo());
                datosFila[0] = it.limInf;
                datosFila[1] = it.limSup;
                datosFila[2] = it.frecuenciaAbsoluta;
                datosFila[3] = it.frecuenciaEsperada;
                double[] valores = calcularValoresChiFila(it.frecuenciaEsperada, it.frecuenciaAbsoluta, anterior);
                anterior = valores[3];

                datosFila[4] = valores[0];
                datosFila[5] = valores[1];
                datosFila[6] = valores[2];
                datosFila[7] = valores[3];
                datos.Add(datosFila);
            }

            return datos;
        }

        public double[] calcularValoresChiFila(double fe, double fo, double anterior)
        {
            double resta = fe - fo;
            double potencia = Math.Pow(resta, 2);
            double estadistico = Util.truncar(potencia / fe);

            double acumulado = estadistico + anterior;

            double[] valores = new double[4] { resta, potencia, estadistico, acumulado };
            return valores;
        }
    }
}
