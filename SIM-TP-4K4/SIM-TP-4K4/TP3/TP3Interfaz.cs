using SIM_TP_4K4.TP3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TP_4K4.TP2
{
    public partial class TP3Interfaz : Form
    {
        public Controlador controlador { get; set; }
       
        public TP3Interfaz()
        {
            InitializeComponent();
            this.controlador = new Controlador();
           
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<object[]> rnd = this.controlador.generarRnd(Int32.Parse(this.TxtTamañoMuestra.Text));
            this.cargarTabla(rnd, dgvRandoms);
        }

        public void cargarTabla(List<object[]> data, DataGridView tabla) {

            data.ForEach((x) => tabla.Rows.Add(x));
            tabla.FirstDisplayedScrollingRowIndex = tabla.Rows.Count - 1;
        }
    }
}
