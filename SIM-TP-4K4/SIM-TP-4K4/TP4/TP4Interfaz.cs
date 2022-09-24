using SIM_TP_4K4.TP1.Model;
using SIM_TP_4K4.TP2;
using SIM_TP_4K4.TP4.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TP_4K4.TP4
{
    public partial class TP4Interfaz : Form
    {

        public ControladorMonteCarlo mountCharly { get; set; }
        public bool prob90 { get; set; }

        public double fecha90 { get; set; }



        public List<double> promedios { get; set; }
        public TP4Interfaz()
        {
            InitializeComponent();
            this.armarGrafico();
        }


        public void iniciarSimulacion()
        {
            this.dgvTp4.Rows.Clear();
            this.eliminarDatosGrafico();
            progressBar.Maximum = ((int)this.numNroMuestra.Value) * 3+ 1; 
            progressBar.Minimum = 1;
            progressBar.Visible = true;


            double[] info1 = new double[2] { (double) this.numLiA1.Value, (double) this.numLsA1.Value};
            double[] info2 = new double[2] { (double) this.numLiA2.Value, (double)this.numLsA2.Value };
            double[] info3 = new double[2] { (double) this.numMediaA3.Value, (double)this.numLambdaA3.Value };
            double[] info4 = new double[2] { (double) this.numLiA4.Value, (double)this.numLsA4.Value };
            double[] info5 = new double[2] { (double) this.numMediaA5.Value, (double)this.numLambdaA5.Value };

            this.mountCharly = new ControladorMonteCarlo((int)this.numNroMuestra.Value, info1, info2, info3, info4, info5, progressBar);
            this.llenarTabla(mountCharly.simular((int)this.numDesde.Value, (int) this.numHasta.Value), mountCharly.fechaConfianza90());
            this.graficar(mountCharly.obtenerPromedios());

            this.cargarResultados(mountCharly.ultimaSimulacion());
            progressBar.Value = 1;
            progressBar.Visible = false;
        }


        public void llenarTabla(List<object[]> dataSimulacion, List<object[]> dataOrdenados)
        {

            dgvTp4.SuspendLayout();

            for (int i = 0; i < dataSimulacion.Count; i++)
            {
                progressBar.Value++;
                object[] valores = dataSimulacion[i];
                object[] valoresOrdenados = dataOrdenados[i];
                object[] tablaSimulacion = new object[] { valores[0], valores[1], valores[2],
                                                valores[3],valores[4], valores[5],
                                                valores[6], valores[7], valores[8],
                                                valores[9], valores[10], valores[11],
                                                valores[12], valores[13], valores[14],
                                                valores[15], valores[16], valores[17], valores[18], valores[19],  valoresOrdenados[0], valoresOrdenados[1] };
                
                dgvTp4.Invoke(new Action(delegate ()
                {
                    dgvTp4.Rows.Add(tablaSimulacion);
                    if (!prob90 && (double)valoresOrdenados[1] > 0.9)
                    {
                        this.fecha90 = (double)valoresOrdenados[0];
                        prob90 = true;
                        dgvTp4.Rows[dgvTp4.Rows.Count - 1].Cells[20].Style.BackColor = Color.Orange;
                        dgvTp4.Rows[dgvTp4.Rows.Count - 1].Cells[21].Style.BackColor = Color.Orange;
                    }
                }
                ));       
            }

            dgvTp4.FirstDisplayedScrollingRowIndex = dgvTp4.Rows.Count - 1;
            prob90 = false;
            dgvTp4.ResumeLayout();
        }




        private void numMediaA3_ValueChanged(object sender, EventArgs e)
        {
            this.numLambdaA3.Value = 1 / this.numMediaA3.Value;
        }

        private void numLambdaA3_ValueChanged(object sender, EventArgs e)
        {
            this.numMediaA3.Value = 1 / this.numLambdaA3.Value;
        }

        private void numMediaA5_ValueChanged(object sender, EventArgs e)
        {
            this.numLambdaA5.Value = 1 / this.numMediaA5.Value;

        }

        private void numLambdaA5_ValueChanged(object sender, EventArgs e)
        {
            this.numMediaA5.Value = 1 / this.numLambdaA5.Value;
        }

        private void chkBoxA3_CheckedChanged(object sender, EventArgs e)
        {
            if(this.chkBoxA3.Checked)
            {
                this.numMediaA3.Enabled = false;
                this.numLambdaA3.Enabled = true;
            } else
            {
                this.numMediaA3.Enabled = true;
                this.numLambdaA3.Enabled = false;
            }
        }

        private void chkBoxA5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkBoxA5.Checked)
            {
                this.numMediaA5.Enabled = false;
                this.numLambdaA5.Enabled = true;
            }
            else
            {
                this.numMediaA5.Enabled = true;
                this.numLambdaA5.Enabled = false;
            }
        }



        public void graficar(List<double> promedio)
        {

            grafico.SuspendLayout();
            for (int i = 0; i < promedio.Count; i++)
            {

                progressBar.Value++;
                if (i <= 700)
                {
                    grafico.Invoke(new Action(delegate ()
                    {
                        grafico.Series["TiempoPromedio"].Points.AddXY(i + 1, promedio[i]);
                    }));
                }
                else if (i % 1500 == 0){
                    grafico.Invoke(new Action(delegate ()
                    {
                        grafico.Series["TiempoPromedio"].Points.AddXY(i + 1, promedio[i]);
                    }));
                }


            }
            grafico.ResumeLayout();
        }


        public void armarGrafico()
        {
            grafico.Titles.Add("Evolución del Tiempo Promedio de la Tarea");
            grafico.ChartAreas["ChartArea1"].AxisY.Title = "Tiempo Promedio";
            grafico.ChartAreas["ChartArea1"].AxisX.Title = "Número de Tarea";
            grafico.ChartAreas["ChartArea1"].AxisX.IsMarginVisible = false;
        }

        public void eliminarDatosGrafico()
        {
            grafico.Series["TiempoPromedio"].Points.Clear();
        }


        private void btnGenerarSimulacion_Click(object sender, EventArgs e)
        {
            string resultadoValidacion = validarCampos();
            if (string.IsNullOrEmpty(resultadoValidacion))
            {
                this.iniciarSimulacion();
            } else
            {
                MessageBox.Show(resultadoValidacion);
            }

        }

        public void cargarResultados(object[] data)
        {
            this.lblDuracionTotalAcumulada.Text = Util.truncar((double)data[15]).ToString();
            this.lblDuracionTotalPromedio.Text = Util.truncar((double)data[16]).ToString();
            this.lblMinDuracion.Text = Util.truncar((double)data[17]).ToString();
            this.lblMaxDuracion.Text = Util.truncar((double)data[18]).ToString();
            this.lbl45.Text = Util.truncar((double)data[19]).ToString();
            this.lblFecha.Text = Util.truncar((double)this.fecha90).ToString();
        }

        private string validarCampos()
        {
            StringBuilder sb = new StringBuilder();
            
            if (this.numLiA1.Value < 0 || this.numLsA1.Value < 0 || this.numLiA2.Value < 0 || this.numLsA2.Value < 0 || this.numLiA4.Value < 0 || this.numLsA4.Value < 0) sb.Append("Los valores de los limites no pueden ser negativos \n");
            if (this.numLiA1.Value > this.numLsA1.Value) sb.Append("El Limite Inferior de la Actividad 1 es mayor al Limite Superior \n");
            if (this.numLiA2.Value > this.numLsA2.Value) sb.Append("El Limite Inferior de la Actividad 2 es mayor al Limite Superior \n");
            if (this.numLiA4.Value > this.numLsA4.Value) sb.Append("El Limite Inferior de la Actividad 4 es mayor al Limite Superior \n");
            if (this.numHasta.Value > this.numNroMuestra.Value) sb.Append("El numero de simulaciones que se quieren mostrar excede numero de simulaciones realizadas \n");
            if (this.numDesde.Value > this.numHasta.Value) sb.Append("El valor desde el cual se quiere mostrar las simulaciones es mayor al valor hasta\n");
            if (this.numDesde.Value < 0 || this.numHasta.Value < 0) sb.Append("El numero de simulaciones a mostrar debe ser positivo \n");
            return sb.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal ven = new MenuPrincipal();
            ven.Show();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TP4Interfaz ven = new TP4Interfaz();
            ven.Show();
            this.Close();
        }



    }
}
