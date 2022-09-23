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

        public TP4Interfaz()
        {
            InitializeComponent();
        }


        public void iniciarSimulacion()
        {
            this.dgvTp4.Rows.Clear();

            double[] info1 = new double[2] { (double)this.numLiA1.Value, (double) this.numLsA1.Value};
            double[] info2 = new double[2] { (double)this.numLiA2.Value, (double)this.numLsA2.Value };
            double[] info3 = new double[2] { (double)this.numMediaA3.Value, (double)this.numLambdaA3.Value };
            double[] info4 = new double[2] { (double)this.numLiA4.Value, (double)this.numLsA4.Value };
            double[] info5 = new double[2] { (double)this.numMediaA5.Value, (double)this.numLambdaA5.Value };

            this.mountCharly = new ControladorMonteCarlo((int)this.numNroMuestra.Value, info1, info2, info3, info4, info5);
            this.llenarTabla(mountCharly.simular((int)this.numDesde.Value, (int) this.numHasta.Value));
        }


        public void llenarTabla(List<object[]> data)
        {
            data.ForEach((x) => dgvTp4.Rows.Add(x));
            dgvTp4.FirstDisplayedScrollingRowIndex = dgvTp4.Rows.Count - 1;
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

        private void btnGenerarSimulacion_Click(object sender, EventArgs e)
        {
            this.iniciarSimulacion();
        }
    }
}
