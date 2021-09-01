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
    public partial class frmejercicio1 : Form
    {
        public frmejercicio1()
        {
            InitializeComponent();
        }

        private void btnejercicio1_Click(object sender, EventArgs e)
        {
            Form frmprincipal = new frminicial();
            this.Close();
            frmprincipal.Visible = true;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmejercicio1_Load(object sender, EventArgs e)
        {
            txtresp1.Enabled = false;
            txtresp2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
