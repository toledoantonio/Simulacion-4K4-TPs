using SIM_TP_4K4.TP1;
using SIM_TP_4K4.TP1.Model;
using SIM_TP_4K4.TP3;
using SIM_TP_4K4.TP3.Pruebas;
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
using IntervaloList = SIM_TP_4K4.TP3.IntervaloList;

namespace SIM_TP_4K4.TP2
{
    public partial class TP3Interfaz : Form
    {
        public bool seleccionDistro { get; set; }
        public bool seleccionPrueba { get; set; }

        public int prueba { get; set; }
        public int distro { get; set; }
        public Controlador controlador { get; set; }

        public TP3Interfaz()
        {
            InitializeComponent();
            this.radioButtonNormal.CheckedChanged += new EventHandler(this.cambioDistribuciones);
            this.radioButtonPoisson.CheckedChanged += new EventHandler(this.cambioDistribuciones);
            this.radioButtonExpo.CheckedChanged += new EventHandler(this.cambioDistribuciones);

            this.radioButtonCHI.CheckedChanged += new EventHandler(this.cambioDePrueba);
            this.radioButtonKS.CheckedChanged += new EventHandler(this.cambioDePrueba);
            construirGrafico();



            this.seleccionDistro = false;
            this.seleccionPrueba = false;
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {

            string resultadoValidacion = validarData();

            if (string.IsNullOrEmpty(resultadoValidacion))
            {
                this.limpiarTabla(dvgRandoms);
                this.limpiarTabla(dvgPrueba);
                this.limpiarTabla(dvgVariable);
                this.limpiarTabla(dgvIntervalos);
                this.construirGrafico();
                int tamañoMuestra = Int32.Parse(this.TxtTamañoMuestra.Text);
                double media = Double.Parse(this.txtMedia.Text);
                double lambda = Double.Parse(this.txtLambda.Text);
                double desviacion = Double.Parse(this.txtDesviacion.Text);
                int cantIntervalos = Int32.Parse(Cmb_intervalos.SelectedItem.ToString());


                this.controlador = new Controlador(tamañoMuestra, media, desviacion, lambda, cantIntervalos,  distro);
                this.cargarTablaRandoms(this.controlador.listaRnd);
                this.cargarTablaVariables();
                this.cargarTablaIntervalos(this.controlador.getIntervalos());
                this.dibujar(this.controlador.obtenerDatosGrafica());
                this.cargarTablaPrueba(this.controlador.realizarPrueba(this.prueba, this.lblValorCriticoResultado, this.lblEstadisticoPruebaResultado, this.lblPruebaAjusteResultado));

                this.dvgRandoms.Visible = true;
                this.dvgVariable.Visible = true;

                this.controlador.intervalos.reducir(distro);
            }
            else
            {
                MessageBox.Show("ERROR! Faltan Campos Por Completar \n" + resultadoValidacion);
            }

        }

        public void cargarTablaPrueba(List<object[]> data)
        {

            if( distro < 2)
            {
                data.ForEach((x) => dvgPrueba.Rows.Add(x));
                dvgPrueba.FirstDisplayedScrollingRowIndex = dvgPrueba.Rows.Count - 1;
            } else
            {
                this.tablaPruebaPoisson();
                data.ForEach((x) => dvgPrueba.Rows.Add(x));
                dvgPrueba.FirstDisplayedScrollingRowIndex = dvgPrueba.Rows.Count - 1;
            }

        }

        public void cargarTablaRandoms(List<double> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                dvgRandoms.Rows.Add(new object[] { i + 1, Util.truncar(data[i]) });
            }
            dvgRandoms.FirstDisplayedScrollingRowIndex = dvgRandoms.Rows.Count - 1;
        }


        public void cargarTablaIntervalos(List<object[]> data)
        {
            if(distro < 2) {
                data.ForEach((x) => dgvIntervalos.Rows.Add(x));
                dgvIntervalos.FirstDisplayedScrollingRowIndex = dgvIntervalos.Rows.Count - 1;
            } else
            {
                this.tablaVariablesPoisson();
                data.ForEach((x) => dgvIntervalos.Rows.Add(x));
                dgvIntervalos.FirstDisplayedScrollingRowIndex = dgvIntervalos.Rows.Count - 1;
            }

        }

        public void cargarTablaVariables()
        {

            if(distro < 2)
            {
                this.controlador.variables.ForEach((x) => dvgVariable.Rows.Add(x));

            } else
            {
                this.controlador.variablesPoisson.ForEach((x) => dvgVariable.Rows.Add((object) x));
            }
            dvgVariable.FirstDisplayedScrollingRowIndex = dvgVariable.Rows.Count - 1;
        }

        public void limpiarTabla(DataGridView tabla)
        {
            tabla.Rows.Clear();
        }

        public void cambioDistribuciones(object sender, EventArgs e)
        {
            if (radioButtonNormal.Checked)
            {
                this.radioButtonKS.Visible = true;
                this.lblMedia.Visible = true;
                this.lblDesv.Visible = true;
                this.txtMedia.Visible = true;
                this.txtDesviacion.Visible = true;
                this.cbxMediaExp.Enabled = false;
                this.cbxMediaExp.Visible = false;

                this.lblLamda.Visible = false;
                this.txtLambda.Visible = false;

                this.txtLambda.Text = "0";
                distro = 0;
            }
            else if (radioButtonExpo.Checked)
            {
                this.cbxMediaExp.Enabled = true;
                this.cbxMediaExp.Visible = true;
                this.radioButtonKS.Visible = true;
                this.txtLambda.Visible = true;
                this.txtMedia.Visible = false;
                this.lblMedia.Visible = false;
                this.txtDesviacion.Visible = false;
                this.lblDesv.Visible = false;
                this.lblLamda.Visible = true;

                this.txtDesviacion.Text = "0";
                this.txtMedia.Text = "0";
                distro = 1;
            }
            else
            {
                this.lblLamda.Visible = true;
                this.txtLambda.Visible = true;


                this.radioButtonKS.Visible = false;
                this.lblMedia.Visible = false;
                this.lblDesv.Visible = false;
                this.txtMedia.Visible = false;
                this.txtDesviacion.Visible = false;

                this.cbxMediaExp.Enabled = false;
                this.cbxMediaExp.Visible = false;

                this.txtMedia.Text = "0";
                this.txtDesviacion.Text = "0";
                distro = 2;
            }

            this.seleccionDistro = true;
        }
        public void cambioDePrueba(object sender, EventArgs e)
        {
            this.limpiarColumnas();

            if (radioButtonCHI.Checked)
            {
                dvgPrueba.Columns.Add("resta", "FE - FO");
                dvgPrueba.Columns.Add("Cuadrado", "(FE - FO) ^ 2");
                dvgPrueba.Columns.Add("div", "(FE - FO) ^ 2 / FE");
                dvgPrueba.Columns.Add("acum", "Acumlado");

                prueba = 0;
            }
            else
            {
                dvgPrueba.Columns.Add("prob", "PO");
                dvgPrueba.Columns.Add("probe", "PE");
                dvgPrueba.Columns.Add("dif", "Diferencia");
                dvgPrueba.Columns.Add("max", "Maximo");

                prueba = 1;
            }

            this.seleccionPrueba = true;
        }


        private void usarMediaExp(object sender, EventArgs e)
        {
            if (cbxMediaExp.Checked)
            {
                this.lblMedia.Visible = true;
                this.txtMedia.Visible = true;

                this.lblLamda.Visible = false;
                this.txtLambda.Visible = false;

                this.txtDesviacion.Text = "0";
                this.txtLambda.Text = "0";
            }
            else
            {
                this.lblLamda.Visible = true;
                this.txtLambda.Visible = true;

                this.lblMedia.Visible = false;
                this.txtMedia.Visible = false;
                this.txtDesviacion.Text = "0";
                this.txtMedia.Text = "0";
            }
        }


        public void limpiarColumnas()
        {
            dvgPrueba.Columns.Clear();
            dvgPrueba.Columns.Add("lf", "Lim inf");
            dvgPrueba.Columns.Add("ls", "Lim sup");
            dvgPrueba.Columns.Add("fo", "FO");
            dvgPrueba.Columns.Add("fe", "FE");
        }

        private void btn_volverMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal ven = new MenuPrincipal();
            ven.Show();
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            TP3Interfaz ven = new TP3Interfaz();
            ven.Show();
            this.Close();
        }


        public void dibujar(List<object[]> dataResult)
        {
            int numIntervalo = 1;
            foreach (Object[] data in dataResult)
            {
                chart1.Series["Frecuencia observada"].Points.AddXY(numIntervalo, data[0]);
                chart1.Series["Frecuencia esperada"].Points.AddXY(numIntervalo, data[1]);
                ++numIntervalo;
            }
        }

        public void construirGrafico()
        {
            chart1.Legends.Clear();
            chart1.Series.Clear();
            chart1.Series.Add("Frecuencia observada");
            chart1.Series.Add("Frecuencia esperada");

            chart1.Titles.Add(new Title("Graficos de frecuencias"));
            chart1.Legends.Add(new Legend("FO"));
            chart1.Legends["FO"].Docking = Docking.Bottom;
            chart1.Series["Frecuencia observada"].Legend = "FO";
            chart1.Series["Frecuencia observada"].IsVisibleInLegend = true;

            chart1.Legends.Add(new Legend("FE"));
            chart1.Legends["FE"].Docking = Docking.Bottom;
            chart1.Series["Frecuencia esperada"].Legend = "FE";
            chart1.Series["Frecuencia esperada"].IsVisibleInLegend = true;

        }

        public void tablaVariablesPoisson() {
            dgvIntervalos.Columns.Clear();
            dgvIntervalos.Columns.Add("valor", "Valor");
            dgvIntervalos.Columns.Add("fo", "FO");
            dgvIntervalos.Columns.Add("fe", "FE");
        }

        public void tablaPruebaPoisson()
        {
            dvgPrueba.Columns.Clear();
            dvgPrueba.Columns.Add("valor", "Valor");
            dvgPrueba.Columns.Add("fo", "FO");
            dvgPrueba.Columns.Add("fe", "FE");
            dvgPrueba.Columns.Add("resta", "FE - FO");
            dvgPrueba.Columns.Add("Cuadrado", "(FE - FO) ^ 2");
            dvgPrueba.Columns.Add("div", "(FE - FO) ^ 2 / FE");
            dvgPrueba.Columns.Add("acum", "Acumlado");
        }

        public string validarData()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(this.TxtTamañoMuestra.Text)) sb.Append("Ingrese Tamaño de la muestra \n");


            if (string.IsNullOrEmpty(this.txtMedia.Text)) sb.Append("Ingrese " + this.lblMedia.Text + "\n");

            if (string.IsNullOrEmpty(this.txtDesviacion.Text)) sb.Append("Ingrese " + this.lblDesv.Text + "\n");

            if (!Double.TryParse(this.txtMedia.Text, out double result)) sb.Append(this.lblMedia.Text + " Debe ser un numero\n");

            if (!(Double.TryParse(this.txtDesviacion.Text, out double result2)) && this.radioButtonPoisson.Checked == false) sb.Append(this.lblDesv.Text + " Debe ser un numero\n");

            if (!this.seleccionDistro) sb.Append("Debe seleccionar una distibucion \n");

            if (!this.seleccionPrueba) sb.Append("Debe seleccionar una prueba \n");

            return sb.ToString();
        }
    }
}
