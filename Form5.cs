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
            double sueldo1, sueldot1, s1ISS, s1AFP, s1RENTA, sueldo2, sueldot2, sueldo3, sueldot3;
            string cargo1, cargo2, cargo3;

            horast1 = Convert.ToInt32(txthoras1.Text);
            horast2 = Convert.ToInt32(txthoras2.Text);
            horast3 = Convert.ToInt32(txthoras3.Text);


            cargo1 = Convert.ToString(cmbcargo1.Text);
            cargo2 = Convert.ToString(cmbcargo2.Text);
            cargo3 = Convert.ToString(cmbcargo3.Text);


            //Restricción si las horas son negativas o cero
            if (horast1 <= 0 || horast2 <= 0 || horast3 <= 0)
            {
                MessageBox.Show("Las horas no pueden ser cero o negativas, intenta de nuevo!", "Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

                //Gerente 10%
                //Asistente 5%
                //Secretaria 3%
                //Otros 2%


            //Si el orden de los cargos es 1.Gerente, 2.Asistente, 3.Secretaria/0
            if(cargo1 == "Gerente" && cargo2 == "Asistente" && cargo3 == "Secretaria/o")
            {

                MessageBox.Show("No hay bono para ningún empleado", "Sin Bono", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

            //Operaciones para calcular el sueldo del empleado 1

            //Gerente
            if ( cargo1 == "Gerente")
            {

                if(horast1 > 160)
                {
                    sueldo1 = horast1 - 160;
                    sueldot1 = 160 * 9.75 + (sueldo1* 11.50);
                    sueldot1 = (sueldot1 * 0.1) + sueldot1;

                    s1ISS = sueldot1 * 0.0525;
                    s1AFP = sueldot1 * 0.0688;
                    s1RENTA = sueldot1 * 0.1;

                    sueldot1 = sueldot1 - s1AFP - s1ISS - s1RENTA;

                    MessageBox.Show("El sueldo de " + txtnombre1.Text + " " + txtapellido1.Text + " es: " + sueldot1);

                }

                else
                {

                    sueldo1 = 9.75 * horast1;
                    sueldot1 = (sueldo1 * 0.1) + sueldo1;

                    s1ISS = sueldot1 * 0.0525;
                    s1AFP = sueldot1 * 0.0688;
                    s1RENTA = sueldot1 * 0.1;

                    sueldot1 = sueldot1 - s1AFP - s1ISS - s1RENTA;

                    MessageBox.Show("El sueldo de " + txtnombre1.Text + " " + txtapellido1.Text + " es: " + sueldot1);
                }
            }

            //Asistente
            if( cargo1 == "Asistente")
            {
                if (horast1 > 160)
                {
                    sueldo1 = horast1 - 160;
                    sueldot1 = 160 * 9.75 + (sueldo1 * 11.50);
                    sueldot1 = (sueldot1 * 0.05) + sueldot1;

                    s1ISS = sueldot1 * 0.0525;
                    s1AFP = sueldot1 * 0.0688;
                    s1RENTA = sueldot1 * 0.1;

                    sueldot1 = sueldot1 - s1AFP - s1ISS - s1RENTA;

                    MessageBox.Show("El sueldo de " + txtnombre1.Text + " " + txtapellido1.Text + " es: " + sueldot1);

                }

                else
                {

                    sueldo1 = horast1 * 1 * 9.75;
                    sueldot1 =  sueldo1 + (sueldo1 * 0.05);

                    s1ISS = sueldot1 * 0.0525;
                    s1AFP = sueldot1 * 0.0688;
                    s1RENTA = sueldot1 * 0.1;

                    sueldot1 = sueldot1 - s1AFP - s1ISS - s1RENTA;

                    MessageBox.Show("El sueldo de " + txtnombre1.Text + " " + txtapellido1.Text + " es: " + sueldot1);
                }
            }
            
            //Secretaria/o
           if( cargo1 == "Secretaria/o")
           {
                if (horast1 > 160)
                {
                    sueldo1 = horast1 - 160;
                    sueldot1 = 160 * 9.75 + (sueldo1 * 11.50);
                    sueldot1 = (sueldot1 * 0.03) + sueldot1;

                    s1ISS = sueldot1 * 0.0525;
                    s1AFP = sueldot1 * 0.0688;
                    s1RENTA = sueldot1 * 0.1;

                    sueldot1 = sueldot1 - s1AFP - s1ISS - s1RENTA;

                    MessageBox.Show("El sueldo de " + txtnombre1.Text + " " + txtapellido1.Text + " es: " + sueldot1);

                }

                else
                {

                    sueldo1 = horast1 * 1 * 9.75;
                    sueldot1 = sueldo1 + (sueldo1 * 0.03);

                    s1ISS = sueldot1 * 0.0525;
                    s1AFP = sueldot1 * 0.0688;
                    s1RENTA = sueldot1 * 0.1;

                    sueldot1 = sueldot1 - s1AFP - s1ISS - s1RENTA;

                    MessageBox.Show("El sueldo de " + txtnombre1.Text + " " + txtapellido1.Text + " es: " + sueldot1);
                }


           }

           //Si posee otro cargo
           if( cargo1 == "Otros")
           {

                if (horast1 > 160)
                {
                    sueldo1 = horast1 - 160;
                    sueldot1 = 160 * 9.75 + (sueldo1 * 11.50);
                    sueldot1 = (sueldot1 * 0.02) + sueldot1;

                    s1ISS = sueldot1 * 0.0525;
                    s1AFP = sueldot1 * 0.0688;
                    s1RENTA = sueldot1 * 0.1;

                    sueldot1 = sueldot1 - s1AFP - s1ISS - s1RENTA;

                    MessageBox.Show("El sueldo de " + txtnombre1.Text + " " + txtapellido1.Text + " es: " + sueldot1);

                }

                else
                {

                    sueldo1 = horast1 * 1 * 9.75;
                    sueldot1 = sueldo1 + (sueldo1 * 0.02);

                    s1ISS = sueldot1 * 0.0525;
                    s1AFP = sueldot1 * 0.0688;
                    s1RENTA = sueldot1 * 0.1;

                    sueldot1 = sueldot1 - s1AFP - s1ISS - s1RENTA;

                    MessageBox.Show("El sueldo de " + txtnombre1.Text + " " + txtapellido1.Text + " es: " + sueldot1);
                }

            }






        }
    }
}
