using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP1SIM.FrontEnd.Pantallas
{
    public partial class Chi_CuadradoCM : Form
    {
        public Menu ventana { get; set; }

        public Chi_CuadradoCM(Menu ven)
        {
            InitializeComponent();
            ventana = ven;

            
        }

        private void btn_volverMenu_Click(object sender, EventArgs e)
        {
            ventana.Show();
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Chi_CuadradoCM ven = new Chi_CuadradoCM(ventana);
            ven.Show();
            this.Close();
        }

        int tam_n;
        int k;

        private int getK()
        {
            if (radioButton5.Checked)
                k = 5;
            else if (radioButton8.Checked)
                k = 8;
            else if (radioButton10.Checked)
                k = 10;
            else if (radioButton12.Checked)
                k = 12;
            return k;
        }

        private double CalcularValorTab(int k)
        {
            if (k == 5)
                return 9.49;
            else if (k == 8)
                return 14.1;
            else if (k == 10)
                return 16.9;
            else if (k == 12)
                return 19.7;
            return 0;
        }

        private double randomDouble(Random r)
        {
            double random = r.NextDouble();
            random = Math.Truncate(random * 10000) / 10000;

            return random;
        }

        private void cargadorDeGrillaSerie(DataGridView tabla, int n)
        {
            //tabla.RowCount = n;
            Random r = new Random();

            for (int i = 0; i < (n); i++)
            {
                double random = randomDouble(r);
                int indice = i + 1;
                tabla.Rows.Add(indice.ToString(), random.ToString());
            }
        }

        private double[][] vectorIntervalos(int k)
        {
            double[][] intervalo = new double[k][];
            double[] inter = new double[2];
            double m = Convert.ToDouble(k);
            double division = 1 / m;
            double limSuperior = 0;
            for (int i = 0; i < k; i++)
            {
                if(checkIncluir1.Checked == false)
                {
                    limSuperior = (((i + 1) * division));
                }
                else
                {
                    limSuperior = (((i + 1) * division) - 0.01);
                }
                
                double limInferior = (i * division);


                double[] interv = new double[2];
                interv[0] = Math.Truncate(limInferior * 1000) / 1000;
                interv[1] = Math.Truncate(limSuperior * 1000) / 1000;

                intervalo[i] = interv;

            }
            return intervalo;
        }

        private void cargadorDeGrillaIntervalos(int k, DataGridView tabla, double[][] vectorIntervalos)
        {
            tabla.RowCount = k;

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    tabla.Rows[i].Cells[j].Value = vectorIntervalos[i][j].ToString();
                }
            }
        }

        private void marcaClase(DataGridView tabla_serie)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                double li = Convert.ToDouble(tabla.Rows[i].Cells[0].Value);
                double ls = Convert.ToDouble(tabla.Rows[i].Cells[1].Value);

                double MC = (li + ls) / 2;
                MC = Math.Truncate(MC * 1000) / 1000;
                tabla.Rows[i].Cells[2].Value = MC;
            }
        }

        private void frecuenciaObservada(DataGridView tabla_serie, DataGridView tabla)
        {
            for (int i = 1; i < tabla_serie.Rows.Count; i++)
            {
                for (int j = 0; j < tabla.Rows.Count; j++)
                {
                    if (Convert.ToDouble(tabla_serie.Rows[i].Cells[1].Value) >= Convert.ToDouble(tabla.Rows[j].Cells[0].Value) && Convert.ToDouble(tabla_serie.Rows[i].Cells[1].Value) <= Convert.ToDouble(tabla.Rows[j].Cells[1].Value))
                    {
                        tabla.Rows[j].Cells[3].Value = Convert.ToDouble(tabla.Rows[j].Cells[3].Value) + 1;
                    }
                }
            }

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i].Cells[3].Value != null)
                {
                    chrt_graf.Series["Frecuencia Observada"].Points.AddXY(tabla.Rows[i].Cells[1].Value, tabla.Rows[i].Cells[3].Value);
                }
                else
                    tabla.Rows[i].Cells[3].Value = 0;
            }
        }

        private void frecuenciaEsperada(int n, int k, DataGridView tabla)
        {
            double frecuenciaEsperada = n / Convert.ToDouble(k);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                tabla.Rows[i].Cells[4].Value = frecuenciaEsperada;
            }
        }

        private void estadistico(int n, int k, DataGridView tabla)
        {
            double estadisticoAcumulado;

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                int fo = Convert.ToInt32(tabla.Rows[i].Cells[3].Value);
                int fe = Convert.ToInt32(tabla.Rows[i].Cells[4].Value);

                double estadistico = Math.Pow((fo - fe), 2) / fe;
                estadistico = Math.Truncate(estadistico * 1000) / 1000;
                tabla.Rows[i].Cells[5].Value = estadistico;

                if (i == 0)
                {
                    estadisticoAcumulado = Convert.ToDouble(tabla.Rows[i].Cells[5].Value);
                    tabla.Rows[i].Cells[6].Value = estadisticoAcumulado;

                }
                else
                {
                    estadisticoAcumulado = Convert.ToDouble(tabla.Rows[i].Cells[5].Value) + Convert.ToDouble(tabla.Rows[i - 1].Cells[6].Value);
                    tabla.Rows[i].Cells[6].Value = estadisticoAcumulado;
                }

                if ((tabla.Rows.Count - 1) == i)
                    tabla.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(237, 187, 0);
            }
        }

        private void ValidarHipotesis(int k)
        {
            txtValorTabulado.Clear();

            int cantFilas = tabla.Rows.Count;
            double valorCalculado = Convert.ToDouble(tabla.Rows[cantFilas - 1].Cells[6].Value);
            double valorTabulado = CalcularValorTab(k);

            txtValorTabulado.Text = Convert.ToString(valorTabulado);

            if (valorCalculado < valorTabulado)
                lbl_resHipotesis.Text = "No se Rechaza la Hipotesis!";
            else
                lbl_resHipotesis.Text = "Se Rechaza la Hipotesis!";
        }

        private Tuple<int, int, int, double> ObtenerValores()
        {
            //Tomamos todos los valores de los TextBox y los pasamos a variables y esos valores los retornamos en una tupla
            int Xo = Convert.ToInt32(TxtXo.Text);
            int c = Convert.ToInt32(TxtC.Text);

            if (checkGyK.Checked)
            {
                int a = 1 + (4 * (Convert.ToInt32(TxtK.Text)));
                double m = Math.Pow(2, Convert.ToDouble(TxtG.Text));

                return Tuple.Create(Xo, a, c, m);
            }

            if (checkGyK.Checked == false)
            {
                int a = Convert.ToInt32(TxtA.Text);
                double m = Convert.ToDouble(TxtM.Text);

                return Tuple.Create(Xo, a, c, m);
            }

            return Tuple.Create(0, 0, 0, 0.0);
        }

        public void cargadorDeGrilla(int N)
        {
            // La variable "var" va a contener la tupla de valores
            var valores = ObtenerValores();

            int X0 = valores.Item1;
            int A = valores.Item2;
            int C = valores.Item3;
            double M = valores.Item4;

            // Con el evento "generar" debemos verificar cual ejecutar en base a si tenemos filas en la grilla o no

            double Xo = 0;
            if (checkIncluir1.Checked == false)
            {
                Xo = Convert.ToDouble((A * X0 + C) % (M)) / (M - 1);
            }
            else
            {
                Xo = Convert.ToDouble((A * X0 + C) % (M)) / (M);
            }
            double resto = Convert.ToDouble((A * X0 + C) % M);
            //Con el ciclo for vamos generando cada valor y agregandolos a la grilla al mismo tiempo. utilizamos la variable "resto" para poder calcular el siguiente valor al final del ciclo.
            for (int i = 0; i < N; i++)
            {
                gdrSerieAleatoria.Rows.Add(i + 1, (Math.Truncate(Xo * 10000) / 10000));
                double X1 = (A * resto + C) % M;
                if (checkIncluir1.Checked == false)
                {
                    Xo = X1 / (M - 1);
                }
                else
                {
                    Xo = X1 / M;
                }
                resto = X1;
            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            chrt_graf.Series.Clear();
            chrt_graf.Series.Add("Frecuencia Observada");

            int k = getK();

            int validarEntero;

            if (TxtTamañoMuestra.Text.Equals("") || (radioButton5.Checked.Equals(false) && radioButton8.Checked.Equals(false) && radioButton10.Checked.Equals(false) && radioButton12.Checked.Equals(false))
                || TxtXo.Text.Equals("") || TxtC.Text.Equals(""))
            {
                MessageBox.Show("ERROR! Faltan Campos por Completar");
            }

            else
            {
                if (!int.TryParse(TxtTamañoMuestra.Text, out validarEntero) || !int.TryParse(TxtXo.Text, out validarEntero) || !int.TryParse(TxtC.Text, out validarEntero))
                {
                    MessageBox.Show("ERROR! Ingresar un Número Entero!");
                }

                else
                {
                    int N = Convert.ToInt32(TxtTamañoMuestra.Text);
                    cargadorDeGrilla(N);
                    tam_n = Int32.Parse(TxtTamañoMuestra.Text);

                    if (tam_n <= 0)
                    {
                        MessageBox.Show("ERROR! Ingresar un Número Entero Positivo!");
                    }
                    else
                    {
                        tabla.Rows.Clear();
                        gdrSerieAleatoria.Rows.Clear();

                        double[][] vIntervalos = vectorIntervalos(k);
                        cargadorDeGrilla(tam_n);
                        cargadorDeGrillaIntervalos(k, tabla, vIntervalos);
                        marcaClase(tabla);
                        frecuenciaObservada(gdrSerieAleatoria, tabla);
                        frecuenciaEsperada(tam_n, k, tabla);
                        estadistico(tam_n, k, tabla);
                    }

                    ValidarHipotesis(k);
                }
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

        private void Chi_CuadradoCM_Load(object sender, EventArgs e)
        {
            txtNivelSignificancia.Text = "95 %";
            txtNivelSignificancia.Enabled = false;
            txtValorTabulado.Enabled = false;
            TxtG.Enabled = false;
            TxtK.Enabled = false;
        }
    }
}
