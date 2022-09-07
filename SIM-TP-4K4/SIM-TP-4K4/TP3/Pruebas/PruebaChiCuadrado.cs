using SIM_TP_4K4.Model;
using SIM_TP_4K4.TP1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SIM_TP_4K4.TP3.Pruebas
{
    public class PruebaChiCuadrado
    {
        public List<Intervalo> intervalos { get; set; }
        public double valorTabulado { get; set; }
        public double valorCalculado { get; set; }

        public Label lblValorCritico { get; set; }
        public Label lblEstadistico { get; set; }
        public Label lblAjuste { get; set; }


        public PruebaChiCuadrado(List<Intervalo> intervalos, Label lblValorCritico, Label lblEstadistico, Label lblAjuste, int cantidadIntervalos, int distro)
        {
            this.intervalos = intervalos;

            this.lblValorCritico = lblValorCritico;
            this.lblEstadistico = lblEstadistico;
            this.lblAjuste = lblAjuste;
            this.getTabulado(cantidadIntervalos, distro);
        }

        public List<object[]> calcular(int distro)
        {
            Console.WriteLine(distro);

            return (distro < 2) ? this.calcular() : this.calcularPoisson();
        }

        public List<Object[]> calcular()
        {
            List<Object[]> datos = new List<Object[]>();
            double anterior = 0;
            foreach (Intervalo it in intervalos)
            {


                Object[] datosFila = new Object[8];
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
            valorCalculado = (double)datos.Last()[7];
            this.lblEstadistico.Text = valorCalculado.ToString();
            this.validarHipotesis();
            return datos;
        }


        public List<Object[]> calcularPoisson()
        {
            List<Object[]> datos = new List<Object[]>();
            double anterior = 0;
            foreach (Intervalo it in intervalos)
            {


                Object[] datosFila = new Object[8];
                datosFila[0] = ((ValorPoisson)it).intervaloTitulo();
                datosFila[1] = it.frecuenciaAbsoluta;
                datosFila[2] = it.frecuenciaEsperada;
                double[] valores = calcularValoresChiFila(it.frecuenciaEsperada, it.frecuenciaAbsoluta, anterior);
                anterior = valores[3];

                datosFila[3] = valores[0];
                datosFila[4] = valores[1];
                datosFila[5] = valores[2];
                datosFila[6] = valores[3];
                datos.Add(datosFila);
            }
            valorCalculado = (double)datos.Last()[6];
            this.lblEstadistico.Text = valorCalculado.ToString();
            this.validarHipotesis();
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


        public void getTabulado(int cantidadIntervalos, int distro)
        {

            if(distro < 2)
            {
                switch (cantidadIntervalos)
                {
                    case 5:
                        this.valorTabulado = 9.49;
                        this.lblValorCritico.Text = "9.49";
                        break;
                    case 8:
                        this.valorTabulado = 14.1;
                        this.lblValorCritico.Text = "14.1";
                        break;
                    case 10:
                        this.valorTabulado = 16.9;
                        this.lblValorCritico.Text = "16.9";
                        break;
                    case 12:
                        this.valorTabulado = 19.7;
                        this.lblValorCritico.Text = "19.7";
                        break;
                }

            } else
            {
                if (this.intervalos.Count > 40) 
                {
                    this.valorTabulado = chiTabulado[39];
                    this.lblValorCritico.Text = $"{chiTabulado[39]}";
                } else
                {
                    if (this.intervalos.Count == 1)
                    {
                        this.valorTabulado = chiTabulado[0];
                        this.lblValorCritico.Text = $"{chiTabulado[0]}";
                    }
                    else
                    {
                        this.valorTabulado = chiTabulado[this.intervalos.Count - 2];
                        this.lblValorCritico.Text = $"{chiTabulado[this.intervalos.Count - 2]}";
                    }

                }
            }


        }

        public void validarHipotesis()
        {
            if (this.valorCalculado < this.valorTabulado)
            {
                lblAjuste.Text = "No se rechaza la Hipotesis!!";
                lblAjuste.BackColor = Color.FromArgb(0, 0, 0);
                lblAjuste.ForeColor = Color.FromArgb(0, 255, 0);
            }
            else
            {
                lblAjuste.Text = "Rechaza la Hipotesis!!";
                lblAjuste.BackColor = Color.FromArgb(0, 0, 0);
                lblAjuste.ForeColor = Color.FromArgb(255, 0, 0);
            }
        }



        public static readonly double[] chiTabulado = {3.8415,
                                                        5.9915,
                                                        7.8147,
                                                        9.4877,
                                                        11.0705,
                                                        12.5916,
                                                        14.0671,
                                                        15.5073,
                                                        16.9190,
                                                        18.3070,
                                                        19.6752,
                                                        21.0261,
                                                        22.3620,
                                                        23.6848,
                                                        24.9958,
                                                        26.2962,
                                                        27.5871,
                                                        28.8693,
                                                        30.1435,
                                                        31.4104,
                                                        32.6706,
                                                        33.9245,
                                                        35.1725,
                                                        36.4150,
                                                        37.6525,
                                                        38.8851,
                                                        40.1133,
                                                        41.3372,
                                                        42.5569,
                                                        43.7730,
                                                        44.9853,
                                                        46.1942,
                                                        47.3999,
                                                        48.6024,
                                                        49.8018,
                                                        50.9985,
                                                        52.1923,
                                                        53.3835,
                                                        54.5722,
                                                        55.7585};

    }
}
