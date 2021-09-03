using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            Form frmprincipal = new frmprincipal();
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

            StreamWriter escritor = null;
            escritor = File.CreateText("Votos.txt");
            string voto = txtvotar.Text;
            escritor.WriteLine(voto);
            escritor.Flush();
            escritor.Close();
            txtvotar.Clear();


        }

        private void cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnresultados_Click(object sender, EventArgs e)
        {
            char delimitador = ',';
            int voto1, voto2, voto3, voto4;
            StreamReader lector = null;
            lector = File.OpenText("Votos.txt");
            string contenido = lector.ReadToEnd();
            string[] valores = contenido.Split(delimitador);
            int tpalabras = valores.Length;

            for (int x = 0; x < valores.Length; x++)
            {
                for (int y = 0; y < valores.Length; y++)
                {
                    if (valores[y] == "1")
                    {
                    }
                }
            }


            lector.Close();

        }
    }
}
