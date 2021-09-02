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
    public partial class frmejercicio3 : Form
    {
        public frmejercicio3()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form frmprincipal = new frminicial();
            this.Close();
            frmprincipal.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, num3, num4, sum, may, men;

            num1 = Convert.ToInt16(txtboxnum1.Text);
            num2 = Convert.ToInt16(txtboxnum2.Text);
            num3 = Convert.ToInt16(txtboxnum3.Text);
            num4 = Convert.ToInt16(txtboxnum4.Text);

            if (num1 > 0 && num2 > 0 && num3 > 0 && num4 > 0 )
            {

            }
            else
            {
                MessageBox.Show("Los números tiene que ser mayores que 0");
            }

        }
    }
}
