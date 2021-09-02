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
            int num1, num2, num3, num4, sum, may, men, maysum, mensum;

            num1 = Convert.ToInt16(txtboxnum1.Text);
            num2 = Convert.ToInt16(txtboxnum2.Text);
            num3 = Convert.ToInt16(txtboxnum3.Text);
            num4 = Convert.ToInt16(txtboxnum4.Text);

            //Hacemos la restricción que los numeros tiene que ser positivos y mayores a 0
            if (num1 > 0 && num2 > 0 && num3 > 0 && num4 > 0)
            {
                //Hacemos la sumatoria de los numeros
                sum = num1 + num2 + num3 + num4;
                if (sum >= 200)
                {
                    //Si la sumatoria es mayor a 200, se ejecutará lo siguiente:
                    MessageBox.Show("La sumatoria de los números es de " + Convert.ToString(sum) + " no puede continuar con el programa");

                    //Limpiamos las cajas de texto
                    txtboxnum1.Clear();
                    txtboxnum2.Clear();
                    txtboxnum3.Clear();
                    txtboxnum4.Clear();
                }
                else
                {
                    if (num1 >= num2 && num1 >= num3 && num1 >= num4)
                    {
                        may = num1;
                        maysum = may + 10;

                        if (num2 >= num3 && num2 >= num4)
                        {
                            if (num3 >= num4)
                            {
                                men = num4;
                                mensum = men - 5;
                                if (men > 10)
                                {
                                    if (may < 50)
                                    {
                                        //MessageBox.Show("El numero mayor es: " + maysum.ToString() + " y el número menor es: " + mensum.ToString());
                                        txtboxmay.Text = maysum.ToString();
                                        txtboxmen.Text = mensum.ToString();
                                        txtboxnum1.Clear();
                                        txtboxnum2.Clear();
                                        txtboxnum3.Clear();
                                        txtboxnum4.Clear();
                                    }
                                    else
                                    {
                                        //MessageBox.Show("El numero mayor es: " + maysum.ToString() + " y el número menor es: " + men.ToString());
                                        txtboxmay.Text = maysum.ToString();
                                        txtboxmen.Text = men.ToString();
                                        txtboxnum1.Clear();
                                        txtboxnum2.Clear();
                                        txtboxnum3.Clear();
                                        txtboxnum4.Clear();

                                    }
                                }
                                else
                                {
                                    if (may < 50)
                                    {
                                        //MessageBox.Show("El numero mayor es: " + may.ToString() + " y el número menor es: " + mensum.ToString() );
                                        txtboxmay.Text = may.ToString();
                                        txtboxmen.Text = mensum.ToString();
                                        txtboxnum1.Clear();
                                        txtboxnum2.Clear();
                                        txtboxnum3.Clear();
                                        txtboxnum4.Clear();

                                    }
                                    else
                                    {
                                        //MessageBox.Show("El numero mayor es: " + may.ToString() + " y el número menor es: " + men.ToString() );
                                        txtboxmay.Text = may.ToString();
                                        txtboxmen.Text = men.ToString();
                                        txtboxnum1.Clear();
                                        txtboxnum2.Clear();
                                        txtboxnum3.Clear();
                                        txtboxnum4.Clear();
                                    }
                                }
                            }
                            else
                            {
                                men = num3;
                                mensum = men - 5; 
                                if (men > 10)
                                {
                                    if (may < 50)
                                    {
                                        //MessageBox.Show("El numero mayor es: " + maysum.ToString() + " y el número menor es: " + mensum.ToString());
                                        txtboxmay.Text = maysum.ToString();
                                        txtboxmen.Text = mensum.ToString();
                                        txtboxnum1.Clear();
                                        txtboxnum2.Clear();
                                        txtboxnum3.Clear();
                                        txtboxnum4.Clear();
                                    }
                                    else
                                    {
                                        //MessageBox.Show("El numero mayor es: " + maysum.ToString() + " y el número menor es: " + men.ToString());
                                        txtboxmay.Text = maysum.ToString();
                                        txtboxmen.Text = men.ToString();
                                        txtboxnum1.Clear();
                                        txtboxnum2.Clear();
                                        txtboxnum3.Clear();
                                        txtboxnum4.Clear();
                                    }
                                }
                                else
                                {
                                    if (may< 50)
                                    {
                                        //MessageBox.Show("El numero mayor es: " + may.ToString() + " y el número menor es: " + mensum.ToString());
                                        txtboxmay.Text = may.ToString();
                                        txtboxmen.Text = mensum.ToString();
                                        txtboxnum1.Clear();
                                        txtboxnum2.Clear();
                                        txtboxnum3.Clear();
                                        txtboxnum4.Clear();

                                    }
                                    else
                                    {
                                        //MessageBox.Show("El numero mayor es: " + may.ToString() + " y el número menor es: " + men.ToString());
                                        txtboxmay.Text = may.ToString();
                                        txtboxmen.Text = men.ToString();
                                        txtboxnum1.Clear();
                                        txtboxnum2.Clear();
                                        txtboxnum3.Clear();
                                        txtboxnum4.Clear();

                                    }
                                }
                            }
                        }
                        else
                        {
                            men = num2;
                            mensum = men - 5;
                            if (men > 10)
                            {
                                if (may < 50)
                                {
                                    //MessageBox.Show("El numero mayor es: " + maysum.ToString() + " y el número menor es: " + mensum.ToString());
                                    txtboxmay.Text = maysum.ToString();
                                    txtboxmen.Text = mensum.ToString();
                                    txtboxnum1.Clear();
                                    txtboxnum2.Clear();
                                    txtboxnum3.Clear();
                                    txtboxnum4.Clear();
                                }
                                else
                                {
                                    //MessageBox.Show("El numero mayor es: " + maysum.ToString() + " y el número menor es: " + men.ToString());
                                    txtboxmay.Text = maysum.ToString();
                                    txtboxmen.Text = men.ToString();
                                    txtboxnum1.Clear();
                                    txtboxnum2.Clear();
                                    txtboxnum3.Clear();
                                    txtboxnum4.Clear();

                                }
                            }
                            else
                            {
                                if (may < 50)
                                {
                                    //MessageBox.Show("El numero mayor es: " + may.ToString() + " y el número menor es: " + mensum.ToString());
                                    txtboxmay.Text = may.ToString();
                                    txtboxmen.Text = mensum.ToString();
                                    txtboxnum1.Clear();
                                    txtboxnum2.Clear();
                                    txtboxnum3.Clear();
                                    txtboxnum4.Clear();

                                }
                                else
                                {
                                    //MessageBox.Show("El numero mayor es: " + may.ToString() + " y el número menor es: " + men.ToString());
                                    txtboxmay.Text = may.ToString();
                                    txtboxmen.Text = men.ToString();
                                    txtboxnum1.Clear();
                                    txtboxnum2.Clear();
                                    txtboxnum3.Clear();
                                    txtboxnum4.Clear();
                                }
                            }
                        }
                    }

                    else
                    {
                        men = num1;
                        mensum = men - 5;
                        if (num2 <= num3 && num2 <= num4)
                        {
                            if (num3 <= num4)
                            {
                                may = num4;
                                maysum = may + 10;
                                if (men > 10)
                                {
                                    if (may < 50)
                                    {
                                        //MessageBox.Show("El numero mayor es: " + maysum.ToString() + " y el número menor es: " + mensum.ToString());
                                        txtboxmay.Text = maysum.ToString();
                                        txtboxmen.Text = mensum.ToString();
                                        txtboxnum1.Clear();
                                        txtboxnum2.Clear();
                                        txtboxnum3.Clear();
                                        txtboxnum4.Clear();
                                    }
                                    else
                                    {
                                        //MessageBox.Show("El numero mayor es: " + maysum.ToString() + " y el número menor es: " + men.ToString());
                                        txtboxmay.Text = maysum.ToString();
                                        txtboxmen.Text = men.ToString();
                                        txtboxnum1.Clear();
                                        txtboxnum2.Clear();
                                        txtboxnum3.Clear();
                                        txtboxnum4.Clear();

                                    }
                                }
                                else
                                {
                                    if (may < 50)
                                    {
                                        //MessageBox.Show("El numero mayor es: " + may.ToString() + " y el número menor es: " + mensum.ToString());
                                        txtboxmay.Text = may.ToString();
                                        txtboxmen.Text = mensum.ToString();
                                        txtboxnum1.Clear();
                                        txtboxnum2.Clear();
                                        txtboxnum3.Clear();
                                        txtboxnum4.Clear();

                                    }
                                    else
                                    {
                                        //MessageBox.Show("El numero mayor es: " + may.ToString() + " y el número menor es: " + men.ToString());
                                        txtboxmay.Text = may.ToString();
                                        txtboxmen.Text = men.ToString();
                                        txtboxnum1.Clear();
                                        txtboxnum2.Clear();
                                        txtboxnum3.Clear();
                                        txtboxnum4.Clear();
                                    }
                                }
                            }
                            else
                            {
                                may = num3;
                                maysum = may + 10;
                                if (men > 10)
                                {
                                    if (may < 50)
                                    {
                                        //MessageBox.Show("El numero mayor es: " + maysum.ToString() + " y el número menor es: " + mensum.ToString());
                                        txtboxmay.Text = maysum.ToString();
                                        txtboxmen.Text = mensum.ToString();
                                        txtboxnum1.Clear();
                                        txtboxnum2.Clear();
                                        txtboxnum3.Clear();
                                        txtboxnum4.Clear();
                                    }
                                    else
                                    {
                                        //MessageBox.Show("El numero mayor es: " + maysum.ToString() + " y el número menor es: " + men.ToString());
                                        txtboxmay.Text = maysum.ToString();
                                        txtboxmen.Text = men.ToString();
                                        txtboxnum1.Clear();
                                        txtboxnum2.Clear();
                                        txtboxnum3.Clear();
                                        txtboxnum4.Clear();

                                    }
                                }
                                else
                                {
                                    if (may < 50)
                                    {
                                        //MessageBox.Show("El numero mayor es: " + may.ToString() + " y el número menor es: " + mensum.ToString());
                                        txtboxmay.Text = may.ToString();
                                        txtboxmen.Text = mensum.ToString();
                                        txtboxnum1.Clear();
                                        txtboxnum2.Clear();
                                        txtboxnum3.Clear();
                                        txtboxnum4.Clear();

                                    }
                                    else
                                    {
                                        //MessageBox.Show("El numero mayor es: " + may.ToString() + " y el número menor es: " + men.ToString());
                                        txtboxmay.Text = may.ToString();
                                        txtboxmen.Text = mensum.ToString();
                                        txtboxnum1.Clear();
                                        txtboxnum2.Clear();
                                        txtboxnum3.Clear();
                                        txtboxnum4.Clear();
                                    }
                                }
                            }
                        }
                        else
                        {
                            may = num2;
                            maysum = may + 10;
                            if (men > 10)
                            {
                                if (may < 50)
                                {
                                    //MessageBox.Show("El numero mayor es: " + maysum.ToString() + " y el número menor es: " + mensum.ToString());
                                    txtboxmay.Text = maysum.ToString();
                                    txtboxmen.Text = mensum.ToString();
                                    txtboxnum1.Clear();
                                    txtboxnum2.Clear();
                                    txtboxnum3.Clear();
                                    txtboxnum4.Clear();
                                }
                                else
                                {
                                    //MessageBox.Show("El numero mayor es: " + maysum.ToString() + " y el número menor es: " + men.ToString());
                                    txtboxmay.Text = maysum.ToString();
                                    txtboxmen.Text = men.ToString();
                                    txtboxnum1.Clear();
                                    txtboxnum2.Clear();
                                    txtboxnum3.Clear();
                                    txtboxnum4.Clear();

                                }
                            }
                            else
                            {
                                if (may < 50)
                                {
                                    //MessageBox.Show("El numero mayor es: " + may.ToString() + " y el número menor es: " + mensum.ToString());
                                    txtboxmay.Text = may.ToString();
                                    txtboxmen.Text = mensum.ToString();
                                    txtboxnum1.Clear();
                                    txtboxnum2.Clear();
                                    txtboxnum3.Clear();
                                    txtboxnum4.Clear();

                                }
                                else
                                {
                                    //MessageBox.Show("El numero mayor es: " + may.ToString() + " y el número menor es: " + men.ToString());
                                    txtboxmay.Text = may.ToString();
                                    txtboxmen.Text = men.ToString();
                                    txtboxnum1.Clear();
                                    txtboxnum2.Clear();
                                    txtboxnum3.Clear();
                                    txtboxnum4.Clear();
                                }
                            }
                        }
                    }
                }

            }
            else
            {

                MessageBox.Show("Los números tiene que ser mayores que 0, ingrese nuevos valores");
                txtboxnum1.Clear();
                txtboxnum2.Clear();
                txtboxnum3.Clear();
                txtboxnum4.Clear();
            }


        }
    }
        } 




