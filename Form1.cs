using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Practico_1
{
    public partial class frminicial : Form
    {
        public frminicial()
        {
            InitializeComponent();
        }

        private void btnejercicio1_Click(object sender, EventArgs e)
        {
            Form formejercicio1 = new frmejercicio1();
            this.Visible = false;
            formejercicio1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formejercicio2 = new frmejercicio2();
            this.Visible = false;
            formejercicio2.Visible = true;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnejercicio3_Click(object sender, EventArgs e)
        {
            Form formejercicio3 = new frmejercicio3();
            this.Visible = false;
            formejercicio3.Visible = true;
        }

        private void btnejercicio4_Click(object sender, EventArgs e)
        {
            Form formejercicio4 = new frmejercicio4();
            this.Visible = false;
            formejercicio4.Visible = true;
        }
    }
}
