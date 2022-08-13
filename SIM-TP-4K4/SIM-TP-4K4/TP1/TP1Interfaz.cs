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

namespace SIM_TP_4K4.TP1
{
    public partial class TP1_Interfaz : Form
    {
        private int cantIntervalos { get; set; }
        private GeneradorControlador controller { get; set; }

        public TP1_Interfaz()
        {
            InitializeComponent();
        }

        public void agregarColumnas() {
            this.cantIntervalos = Int32.Parse(groupBox4.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
            for (int i = 0; i < cantIntervalos; ++i)
            {
                gdrSerieAleatoria.Columns.Add("xd", i.ToString());
            }
  
        }

        public void cleanColumns()
        {
            gdrSerieAleatoria.Columns.Clear();
            gdrSerieAleatoria.Columns.Add("orden", "Orden");
            gdrSerieAleatoria.Columns.Add("entero", "X");
            gdrSerieAleatoria.Columns.Add("random", "RND");
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            int metodoSeleccionado = cbxMetodo.SelectedIndex;
            int xo = Int32.Parse(TxtXo.Text);
            int a = Int32.Parse(TxtA.Text);
            int c = Int32.Parse(TxtC.Text);
            int m = Int32.Parse(TxtM.Text);
            int n = Int32.Parse(TxtTamañoMuestra.Text);
            this.agregarColumnas();
            controller = new GeneradorControlador(xo, c, a, m, n, cantIntervalos, metodoSeleccionado);
            cargarDatos();
        }

        private void cargarDatos()
        {
            controller.probando();
        }
    }
}
