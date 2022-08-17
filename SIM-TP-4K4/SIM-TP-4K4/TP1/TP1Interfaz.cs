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

        public void cargarTabla(List<object[]> interaciones)
        {
           
            foreach(object[] it in interaciones)
            {
                agregarFilaTabla(it);
            }   
        }

        public void agregarFilaTabla(object[] datos) {

            gdrSerieAleatoria.Rows.Add(datos);
        }

        public void cleanColumns()
        {
            gdrSerieAleatoria.Columns.Clear();
            gdrSerieAleatoria.Columns.Add("orden", "Orden");
            gdrSerieAleatoria.Columns.Add("entero", "X");
            if(cbxMetodo.SelectedIndex == 3)
            {
                gdrSerieAleatoria.Columns.Add("entero_1", "X-1");
            }
            gdrSerieAleatoria.Columns.Add("random", "RND");
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            int validarEntero;
            
            if (TxtTamañoMuestra.Text.Equals("") || TxtXo.Text.Equals("") || (TxtC.Text.Equals("") && cbxMetodo.SelectedIndex !=3) || (cbxMetodo.SelectedIndex == 3 && TxtSemilla2.Text.Equals("") || (!checkGyK.Checked && TxtM.Text.Equals(""))))
            {
                MessageBox.Show("ERROR! Faltan Campos Por Completar");
            } else if(checkGyK.Checked && (TxtG.Text.Equals("") || TxtK.Equals(""))){
                MessageBox.Show("ERROR! Faltan Campos Por Completar");
            }
            else
            {
                if (!int.TryParse(TxtTamañoMuestra.Text, out validarEntero) || !int.TryParse(TxtXo.Text, out validarEntero) || (!int.TryParse(TxtC.Text, out validarEntero) && cbxMetodo.SelectedIndex != 3))
                {
                    MessageBox.Show("ERROR! Ingresar un Número Entero");
                }
                else
                {
                    int metodoSeleccionado = cbxMetodo.SelectedIndex;
                    int xo = Int32.Parse(TxtXo.Text);

                    int a = (!checkGyK.Checked && (cbxMetodo.SelectedIndex != 3)) ? Int32.Parse(TxtA.Text) : 0;
                    a = (cbxMetodo.SelectedIndex != 3) ? a : 0;
                    int c = (cbxMetodo.SelectedIndex != 3) ? Int32.Parse(TxtC.Text) : 0;
                    int m = (!checkGyK.Checked) ? Int32.Parse(TxtM.Text) : 0;
                    int n = Int32.Parse(TxtTamañoMuestra.Text);

                    int x0Anterior = (cbxMetodo.SelectedIndex == 3) ? Int32.Parse(TxtSemilla2.Text) : 0;
                    int k = (checkGyK.Checked) ? Int32.Parse(TxtK.Text) : 0;
                    int g = (checkGyK.Checked) ? Int32.Parse(TxtG.Text) : 0;

                    this.cantIntervalos = Int32.Parse(groupBox4.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
                    controller = new GeneradorControlador(xo, c, a, m, n, cantIntervalos, metodoSeleccionado, checkbxFr.Checked, x0Anterior, k, g);
                    cleanColumns();
                    cargarDatos();

                    
                    this.habilitarBotones();
                }
            }
        }

        private void cargarDatos()
        {
            List<object[]> resultado = this.controller.getRandoms();
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
                this.TxtA.Enabled = false;
                this.TxtC.Enabled = false;
                this.TxtA.Text = ""; 
                this.TxtC.Text = "";

            }
            else
            {
                this.TxtSemilla2.Visible = false;
                this.TxtSemilla2.Enabled = false;
                this.lblSemilla2.Visible = false;
                this.lblSemilla2.Enabled = false;
                this.TxtA.Enabled = (checkBoxDefecto.Checked) ? false : true;
                this.TxtC.Enabled = (checkBoxDefecto.Checked) ? false : true;
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

            if (!this.controller.superaMuestra(1))
            {
                object[] siguiente = this.controller.getSiguiente();
                agregarFilaTabla(siguiente);
            } else
            {
                MessageBox.Show("ERROR! + 1 superara el tamaño de la muestra");
            }

        }

        private void btnMas20_Click(object sender, EventArgs e)
        {

            if (!this.controller.superaMuestra(20))
            {
                List<object[]> results = this.controller.getRandoms(20);
                gdrSerieAleatoria.Rows.Clear();
                results.ForEach(it => agregarFilaTabla(it));
            } else
            {
                MessageBox.Show("ERROR! + 20 superara el tamaño de la muestra");
            }
        }

        private void btnMas10_Click(object sender, EventArgs e)
        {
            if (!this.controller.superaMuestra(10000))
            {
                List<object[]> results = this.controller.ultimosDos(10000);
                gdrSerieAleatoria.Rows.Clear();
                results.ForEach(x => agregarFilaTabla(x));
            } else
            {
                MessageBox.Show("ERROR! + 10.000 superara el tamaño de la muestra");
            }
        }

        private void checkBoxDefecto_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxDefecto.Checked)
            {
                TxtTamañoMuestra.Text = "20";
                TxtXo.Text = "37";
                TxtC.Text = "7";
                TxtA.Text = "19";
                TxtM.Text = "53";
                cantIntervalos = 10;
                radioButton10.Checked = true;
                TxtTamañoMuestra.Enabled = false;
                TxtXo.Enabled = false;
                TxtC.Enabled = false;
                TxtA.Enabled = false;
                TxtM.Enabled = false;
                
                radioButton10.Enabled = false;
                radioButton12.Enabled = false;
                radioButton8.Enabled = false;
                radioButton5.Enabled = false;
                checkGyK.Enabled = false;

            } else
            {
                TxtTamañoMuestra.Text = "";
                TxtXo.Text = "";
                TxtC.Text = "";
                TxtA.Text = "";
                TxtM.Text = "";
                cantIntervalos = 10;
                radioButton10.Checked = true;
                TxtTamañoMuestra.Enabled = true;
                TxtXo.Enabled = true;
                TxtC.Enabled = true;
                TxtA.Enabled = true;
                TxtM.Enabled = true;

                radioButton10.Enabled = true;
                radioButton12.Enabled = true;
                radioButton8.Enabled = true;
                radioButton5.Enabled = true;
                checkGyK.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChiCuadrado chiCuadrado = new ChiCuadrado(this.controller, this.cantIntervalos);
            chiCuadrado.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<object[]> result = this.controller.hastaN();
            if(result.Count > 0)
            {
                gdrSerieAleatoria.Rows.Clear();
                result.ForEach(x => agregarFilaTabla(x));
            } else
            {
                MessageBox.Show("ERROR! Ya supero N anteriormente");
            }
        }

        private void habilitarBotones()
        {
            btnMas1.Enabled = true;
            btnMas20.Enabled = true;
            btnMas10.Enabled = true;
            btnN.Enabled = true;
            btnChi.Enabled = true;
        }
    }
}
