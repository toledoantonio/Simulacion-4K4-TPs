using SIM_TP_4K4.Generador;
using SIM_TP_4K4.Model;
using SIM_TP_4K4.TP1.Model;
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

        public void agregarColumnas(IntervaloList vectorIntervalos) {
            
            for (int i = 0; i < vectorIntervalos.intervalos.Count; ++i)
            {
                gdrSerieAleatoria.Columns.Add($"intervalo {i + 1}", vectorIntervalos.intervalos[i].intervaloTitulo());
            }
  
        }

        public void cargarTabla(List<Iteracion> interaciones)
        {
           
            foreach(Iteracion it in interaciones)
            {
                agregarFilaTabla(it);
            }
            
        }

        public void agregarFilaTabla(Iteracion it) {
            Object[] datos = new Object[3 + this.cantIntervalos];
            datos[0] = it.orden;
            datos[1] = it.entero;
            datos[2] = it.random;


            for (int i = 0; i < it.valoresIteracion.Length; ++i)
            {
                datos[3 + i] = it.valoresIteracion[i];
            }
            gdrSerieAleatoria.Rows.Add(datos);
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
            if (TxtTamañoMuestra.Text.Equals("") || TxtXo.Text.Equals("") || TxtC.Text.Equals("") || (cbxMetodo.SelectedIndex == 3 && TxtSemilla2.Text.Equals("") || (!checkGyK.Checked && TxtM.Text.Equals(""))))
            {
                MessageBox.Show("ERROR! Faltan Campos Por Completar");
            }
            else
            {
                int metodoSeleccionado = cbxMetodo.SelectedIndex;
                int xo = Int32.Parse(TxtXo.Text);
                int x0Anterior = (cbxMetodo.SelectedIndex == 3) ? Int32.Parse(TxtSemilla2.Text) : 0;
                int a = Int32.Parse(TxtA.Text);
                int c = Int32.Parse(TxtC.Text);
                int m = Int32.Parse(TxtM.Text);
                int n = Int32.Parse(TxtTamañoMuestra.Text);
                this.cantIntervalos = Int32.Parse(groupBox4.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
                controller = new GeneradorControlador(xo,c, a, m, n, cantIntervalos, metodoSeleccionado, checkbxFr.Checked, x0Anterior);
                cleanColumns();
                cargarDatos();
                
            }
        }

        private void cargarDatos()
        {
            List<Iteracion> resultado = this.controller.getRandoms();
            IntervaloList intervalos = this.controller.getListaIntervalos();
            this.agregarColumnas(intervalos);
            this.cargarTabla(resultado);
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

            if(indice == 3)
            {
                this.TxtSemilla2.Visible = true;
                this.TxtSemilla2.Enabled = true;
                this.lblSemilla2.Visible = true;
                this.lblSemilla2.Enabled = true;
            } else
            {
                this.TxtSemilla2.Visible = false;
                this.TxtSemilla2.Enabled = false;
                this.lblSemilla2.Visible = false;
                this.lblSemilla2.Enabled = false;
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
            btn_generar.Enabled = false;
        }

        private void btnMas1_Click(object sender, EventArgs e)
        {
            Iteracion siguiente = this.controller.getSiguiente();
            agregarFilaTabla(siguiente);
        }

        private void btnMas20_Click(object sender, EventArgs e)
        {
            List<Iteracion> results = this.controller.getRandoms(20);
            results.ForEach(it => agregarFilaTabla(it));
        }

        private void btnMas10_Click(object sender, EventArgs e)
        {
            List<Iteracion> results = this.controller.getRandoms(10000);
            agregarFilaTabla(results.Last());
        }
    }
}
