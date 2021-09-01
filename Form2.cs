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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {

            double valora, valorb, valorc, x1, x2, primeraparteformula;

            valora = Convert.ToDouble(txtA.Text);
            valorb = Convert.ToDouble(txtB.Text);
            valorc = Convert.ToDouble(txtC.Text);
            primeraparteformula = valorb * valorb - 4.0 * valora * valorc;

            if (primeraparteformula < 0)
            {
                MessageBox.Show("El resultado es Imaginario", "");
            }

            else
            {
                x1 = (-valorb + Math.Sqrt(primeraparteformula)) / (2 * valora);
                txtresp1.Text = x1.ToString();
                x2 = (-valorb - Math.Sqrt(primeraparteformula)) / (2 * valora);
                txtresp2.Text = x2.ToString();
            }


        }

        private void txtrespuesta2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrespuesta1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmejercicio1_Load(object sender, EventArgs e)
        {
            txtresp1.Enabled = false;
            txtresp2.Enabled = false;

        }
    }
}
