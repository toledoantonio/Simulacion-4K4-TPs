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
            if (TxtTamañoMuestra.Text.Equals("") || TxtXo.Text.Equals("") || TxtC.Text.Equals(""))
            {
                MessageBox.Show("ERROR! Faltan Campos Por Completar");
            }
            else
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
        }

        private void cargarDatos()
        {
            controller.probando();
        }

        private void btn_volverMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal ven = new MenuPrincipal();
            ven.Show();
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            TP1_Interfaz ven = new TP1_Interfaz();
            ven.Show();
            this.Close();
        }

        private void chequearMetodo(object sender, EventArgs e)
        {
            //Validacion para iniciar la simulacion si se cuenta con un metodo seleccionado
            int indice = cbxMetodo.SelectedIndex;
            
            if (indice > 0)
            {
                btn_generar.Enabled = true;
            }
            else
            {
                btn_generar.Enabled = false;
            }
        }

        private void checkGyK_CheckedChanged(object sender, EventArgs e)
        {
            //Estan son validaciones para que si el usuario selecciona periodo maximo no pueda ingresar
            //valores de "a" y "m" manuales ya que se calculan en base a "k" y "g"
            if (checkGyK.Checked == true)
            {
                TxtA.Text = "";
                TxtM.Text = "";
                TxtA.Enabled = false;
                TxtM.Enabled = false;
                TxtG.Enabled = true;
                TxtK.Enabled = true;
            }
            else
            {
                TxtA.Enabled = true;
                TxtM.Enabled = true;
                TxtG.Enabled = false;
                TxtK.Enabled = false;
                TxtK.Text = "";
                TxtG.Text = "";
            }
        }

        private void TP1_Interfaz_Load(object sender, EventArgs e)
        {
            TxtG.Enabled = false;
            TxtK.Enabled = false;
            //btn_generar.Enabled = false;
        }
    }
}
