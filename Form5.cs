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
            cmbcargo2.Items.Add("Gerente");
            cmbcargo2.Items.Add("Asistente");
            cmbcargo2.Items.Add("Secretaria/o");
            cmbcargo3.Items.Add("Gerente");
            cmbcargo3.Items.Add("Asistente");
            cmbcargo3.Items.Add("Secretaria/o");
        }
    }
}
