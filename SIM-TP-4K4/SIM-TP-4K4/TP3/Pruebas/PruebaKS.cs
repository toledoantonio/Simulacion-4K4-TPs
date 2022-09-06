using SIM_TP_4K4.Model;
using SIM_TP_4K4.TP1.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TP_4K4.TP3.Pruebas
{
    public class PruebaKS
    {
        public IntervaloList intervalos { get; set; }
        public Label lblValorCritico { get; set; }
        public Label lblEstadistico { get; set; }
        public Label lblAjuste { get; set; }

        public double maxCalculado { get; set; }

        public double tabulado { get; set; }

        public static readonly double[] valCriticos = {
            0.9750, 0.8418, 0.7076, 0.6239, 0.5632, 0.5192, 0.4834, 0.4542, 0.4300,
            0.4092, 0.3912, 0.3754, 0.3614, 0.3489 , 0.3375, 0.3273, 0.3179, 0.3093,
            0.3014, 0.2940, 0.2872, 0.2808, 0.2749, 0.2693, 0.2640, 0.2590, 0.2543,
            0.2499, 0.2457, 0.2417, 0.2378, 0.2342, 0.2307, 0.2274, 0.2242, 0.2211, 0.2182, 0.2154, 0.2127, 0.2101, 0.2076, 0.2051, 0.2028, 0.2005, 0.1983, 0.1962, 0.1942, 0.1922, 0.1902, 0.1884
        };


        public PruebaKS(IntervaloList intervalos, Label lblValorCritico, Label lblEstadistico, Label lblAjuste, int tamañoMuestra)
        {
            this.intervalos = intervalos;
            intervalos.contarFR(tamañoMuestra);
            this.lblValorCritico = lblValorCritico;
            this.lblEstadistico = lblEstadistico;
            this.lblAjuste = lblAjuste;
            this.valorTabulado(tamañoMuestra);
        }

        public List<Object[]> calcular()
        {
            List<Object[]> datos = new List<Object[]>();


            double max = 0;

            foreach (Intervalo it in intervalos.intervalos)
            {
                Object[] datosFila = new Object[8];
                datosFila[0] = it.limInf;
                datosFila[1] = it.limSup;
                datosFila[2] = it.frecuenciaAbsoluta;
                datosFila[3] = it.frecuenciaEsperada;
                datosFila[4] = it.frecuenciaRelativa;
                datosFila[5] = it.frecuenciaRelativaEsperada;

                double diferencia = it.frecuenciaRelativa - it.frecuenciaRelativaEsperada;
                max = (Math.Abs(diferencia) > max) ? Math.Abs(diferencia) : max;

                datosFila[6] = diferencia;
                datosFila[7] = max;

                datos.Add(datosFila);
            }

            this.maxCalculado = max;
            this.lblEstadistico.Text = max.ToString();
            validarHipotesis();
            return datos;
        }

        public void valorTabulado(int tamañoMuesta)
        {
            if (tamañoMuesta > 50)
            {
                tabulado = (1.36) / Math.Sqrt(tamañoMuesta);
            }
            else
            {
                tabulado = valCriticos[tamañoMuesta - 1];
            }

            this.lblValorCritico.Text = tabulado.ToString();
        }


        public void validarHipotesis()
        {
            if (this.maxCalculado < this.tabulado)
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
    }
}
