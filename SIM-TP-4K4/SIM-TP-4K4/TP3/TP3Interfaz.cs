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
using IntervaloList = SIM_TP_4K4.TP3.IntervaloList;

namespace SIM_TP_4K4.TP2
{
    public partial class TP3Interfaz : Form
    {
        public Controlador controlador { get; set; }

        public TP3Interfaz()
        {
            InitializeComponent();
            this.radioButtonNormal.CheckedChanged += new EventHandler(this.cambioDistribuciones);
            this.radioButtonPoisson.CheckedChanged += new EventHandler(this.cambioDistribuciones);
            this.radioButtonExpo.CheckedChanged += new EventHandler(this.cambioDistribuciones);

            this.radioButtonCHI.CheckedChanged += new EventHandler(this.cambioDePrueba);
            this.radioButtonKS.CheckedChanged += new EventHandler(this.cambioDePrueba);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //if (TxtTamañoMuestra.Text.Equals("") || txtParametro1.Text.Equals(""))
            //{
            //    MessageBox.Show("¡Complete los campos necesarios!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

                
            
                this.limpiarTabla(dvgRandoms);
                this.limpiarTabla(dvgPrueba);
                this.limpiarTabla(dvgVariable);


                this.controlador = new Controlador(Int32.Parse(this.TxtTamañoMuestra.Text), Double.Parse(this.txtParametro2.Text), Double.Parse(this.txtParametro1.Text));
                this.cargarTablaRandoms(this.controlador.listaRnd);
                this.cargarTablaVariables(this.controlador.variables);

                IntervaloList prueba = new IntervaloList(this.controlador.variables, 10);
                prueba.contarFE(0, Double.Parse(this.txtParametro1.Text), Double.Parse(this.txtParametro2.Text), 0);

                PruebaChiCuadrado prueba1 = new PruebaChiCuadrado(prueba);

                this.cargarTablaChi(prueba1.calcular());

                this.dvgRandoms.Visible = true;
                this.dvgVariable.Visible = true;
        }

        public void cargarTablaChi(List<object[]> data)
        {
            data.ForEach((x) => dvgPrueba.Rows.Add(x));
            dvgRandoms.FirstDisplayedScrollingRowIndex = dvgPrueba.Rows.Count - 1;
        }

        public void cargarTablaRandoms(List<double> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                dvgRandoms.Rows.Add(new object[] { i + 1, Util.truncar(data[i]) });
            }
            dvgRandoms.FirstDisplayedScrollingRowIndex = dvgRandoms.Rows.Count - 1;
        }

        public void cargarTablaVariables(List<double> data)
        {
            data.ForEach((x) => dvgVariable.Rows.Add(x));
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
                this.lblParametro1.Text = "Media";
                this.lblParametro2.Text = "Varianza";

                this.radioButtonKS.Visible = true;
                this.lblParametro1.Visible = true;
                this.lblParametro2.Visible = true;
                this.txtParametro1.Visible = true;
                this.txtParametro2.Visible = true;
            }
            else if (radioButtonExpo.Checked)
            {
                this.lblParametro1.Text = "Media";
                this.lblParametro2.Text = "Lambda";
                this.radioButtonKS.Visible = true;
                this.lblParametro1.Visible = true;
                this.lblParametro2.Visible = true;
                this.txtParametro1.Visible = true;
                this.txtParametro2.Visible = true;
            }
            else
            {
                this.lblParametro1.Text = "Lambda";
                this.radioButtonKS.Visible = false;
                this.lblParametro1.Visible = true;
                this.lblParametro2.Visible = false;
                this.txtParametro1.Visible = true;
                this.txtParametro2.Visible = false;
            }
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
            }
            else
            {
                dvgPrueba.Columns.Add("prob", "PO");
                dvgPrueba.Columns.Add("probe", "PE");
                dvgPrueba.Columns.Add("dif", "Diferencia");
                dvgPrueba.Columns.Add("max", "Maximo");
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
    }
}
