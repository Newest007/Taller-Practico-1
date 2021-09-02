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
    public partial class frmejercicio4 : Form
    {
        public frmejercicio4()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form frmprincipal = new frminicial();
            this.Close();
            frmprincipal.Visible = true;
        }

        private void frmejercicio4_Load(object sender, EventArgs e)
        {
            cmbcargo1.Items.Clear();
            cmbcargo2.Items.Clear();
            cmbcargo3.Items.Clear();
            cmbcargo1.Items.Add("Gerente");
            cmbcargo1.Items.Add("Asistente");
            cmbcargo1.Items.Add("Secretaria/o");
            cmbcargo1.Items.Add("Otros");
            cmbcargo2.Items.Add("Gerente");
            cmbcargo2.Items.Add("Asistente");
            cmbcargo2.Items.Add("Secretaria/o");
            cmbcargo2.Items.Add("Otros");
            cmbcargo3.Items.Add("Gerente");
            cmbcargo3.Items.Add("Asistente");
            cmbcargo3.Items.Add("Secretaria/o");
            cmbcargo3.Items.Add("Otros");
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            int horast1, horast2, horast3;
            double sueldo1, sueldo2, sueldo3;
            string cargo1, cargo2, cargo3;

            horast1 = Convert.ToInt32(txthoras1.Text);
            horast2 = Convert.ToInt32(txthoras2.Text);
            horast3 = Convert.ToInt32(txthoras3.Text);


            cargo1 = Convert.ToString(cmbcargo1.Text);
            cargo2 = Convert.ToString(cmbcargo2.Text);
            cargo3 = Convert.ToString(cmbcargo3.Text);


            if (horast1 <= 0 || horast2 <= 0 || horast3 <= 0)
            {
                MessageBox.Show("Las horas no pueden ser cero o negativas, intenta de nuevo!", "Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

                //Gerente 10%
                //Asistente 5%
                //Secretaria 3%
                //Otros 2%

            if(cargo1 == "Gerente" && cargo2 == "Asistente" && cargo3 == "Secretaria/o")
            {

                MessageBox.Show("No hay bono para ningún empleado", "Sin Bono", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

            if( horast1 <= 160)
            {

            }
            
            

        }
    }
}
