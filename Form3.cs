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
    public partial class frmejercicio2 : Form
    {
        public frmejercicio2()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form frmprincipal = new frminicial();
            this.Close();
            frmprincipal.Visible = true;
        }

        private void frmejercicio2_Load(object sender, EventArgs e)
        {
            //Agregamos las opciones al combo
            cmbox.Items.Clear();
            cmbox.Items.Add("Candidato nº1");
            cmbox.Items.Add("Candidato nº2");
            cmbox.Items.Add("Candidato nº3");
            cmbox.Items.Add("Candidato nº4");

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
