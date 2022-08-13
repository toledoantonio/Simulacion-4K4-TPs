using SIM_TP_4K4.TP1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TP_4K4
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_menuPrincipal_Click(object sender, EventArgs e)
        {
            TP1_Interfaz tp1 = new TP1_Interfaz();
            tp1.Show();
        }
    }
}
