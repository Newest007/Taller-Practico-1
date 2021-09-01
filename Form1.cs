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
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
