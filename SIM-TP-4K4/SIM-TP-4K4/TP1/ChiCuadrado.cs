using SIM_TP_4K4.Generador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SIM_TP_4K4.TP1
{
    public partial class ChiCuadrado : Form
    {
        public GeneradorControlador controlador { get; set; }
        public List<Object[]> dataResult { get; set; }
        public double valorTabulado { get; set; }
        public double valorCalculado { get; set; }

        public ChiCuadrado(GeneradorControlador controlador, int cantidadIntervalos)
        {
            InitializeComponent();
            this.controlador = controlador;
            chart1.Series.Clear();
            chart1.Series.Add("Frecuencia observada");
            chart1.Series.Add("Frecuencia esperada");
            cargarTabla();
            dibujar();
            getTabulado(cantidadIntervalos);
            getCalculado();
            validarHipotesis();
        }

        public void cargarTabla()
        {
            this.dataResult = this.controlador.getDatosChiCuadrado();
            foreach(Object[] data in dataResult)
            {
                dgvChiCuadrado.Rows.Add(data);
            }
        }

        public void dibujar()
        {
            chart1.Titles.Add(new Title("Graficos de frecuencias"));
            chart1.Legends.Add(new Legend("FO"));
            chart1.Legends["FO"].Docking = Docking.Bottom;
            chart1.Series["Frecuencia observada"].Legend = "FO";
            chart1.Series["Frecuencia observada"].IsVisibleInLegend = true;

            chart1.Legends.Add(new Legend("FE"));
            chart1.Legends["FE"].Docking = Docking.Bottom;
            chart1.Series["Frecuencia esperada"].Legend = "FE";
            chart1.Series["Frecuencia esperada"].IsVisibleInLegend = true;


            int numIntervalo = 1;
            foreach(Object[] data in dataResult)
            {
                chart1.Series["Frecuencia observada"].Points.AddXY(numIntervalo, data[2]);
                chart1.Series["Frecuencia esperada"].Points.AddXY(numIntervalo, data[3]);
                ++numIntervalo;
            }
        }

        public void getTabulado(int cantidadIntervalos)
        {
            switch(cantidadIntervalos)
            {
                case 5:
                    this.valorTabulado = 9.49;
                    this.lblVtabulado.Text = "9.49";
                    break;
                case 8:
                    this.valorTabulado = 14.1;
                    this.lblVtabulado.Text = "14.1";
                    break;
                case 10:
                    this.valorTabulado = 16.9;
                    this.lblVtabulado.Text = "16.9";
                    break;
                case 12:
                    this.valorTabulado = 19.7;
                    this.lblVtabulado.Text = "19.7";
                    break;
            }
        }

        public void getCalculado()
        {
            int count = dgvChiCuadrado.RowCount;
            dgvChiCuadrado.Rows[count - 2].Cells[7].Style.BackColor = Color.FromArgb(237, 187, 0);
            this.valorCalculado = (double) dgvChiCuadrado.Rows[count - 2].Cells[7].Value;
            this.lblVCalculado.Text = $"{this.valorCalculado}";
        }

        public void validarHipotesis()
        {
            if(this.valorCalculado < this.valorTabulado)
            {
                lblResultado.Text = "No se rechaza la Hipotesis!!";
                lblResultado.BackColor = Color.FromArgb(0, 0, 0);
                lblResultado.ForeColor = Color.FromArgb(0, 255, 0);
            } else
            {
                lblResultado.Text = "Rechaza la Hipotesis!!";
                lblResultado.BackColor = Color.FromArgb(0, 0, 0);
                lblResultado.ForeColor = Color.FromArgb(255, 0, 0);
            }
        }
    }
}
