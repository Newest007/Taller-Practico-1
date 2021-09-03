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


        private void btnresultados_Click_1(object sender, EventArgs e)
        {
            char delimitador = ',';
            int voto1 = 0, voto2 = 0, voto3 = 0, voto4 = 0;
            StreamReader lector = null;
            lector = File.OpenText("Votos.txt");
            string contenido = lector.ReadToEnd();
            string[] valores = contenido.Split(delimitador);
            int tpalabras = valores.Length;
            double porcen1, porcen2, porcen3, porcen4;

            for (int x = 0; x < valores.Length; x++)
            {
                if (valores[x] == "1")
                {
                    voto1++;

                }
                if (valores[x] == "2")
                {
                    voto2++;


                }
                if (valores[x] == "3")
                {
                    voto3++;


                }
                if (valores[x] == "4")
                {
                    voto4++;

                }

            }
            porcen1 = (voto1 * 100) / tpalabras;
            porcen2 = (voto2 * 100) / tpalabras;
            porcen3 = (voto3 * 100) / tpalabras;
            porcen4 = (voto4 * 100) / tpalabras;

            if (cmbox.SelectedItem.ToString() == "Candidato nº1")
            {
                MessageBox.Show("Candidato nº1:  votos: " + voto1 + " porcentaje: " + porcen1.ToString() + " %");
            }

            if (cmbox.SelectedItem.ToString() == "Candidato nº2")
            {
                MessageBox.Show("Candidato nº2:  votos: " + voto2 + " porcentaje: " + porcen2.ToString() + " %");
            }
            if (cmbox.SelectedItem.ToString() == "Candidato nº3")
            {
                MessageBox.Show("Candidato nº3:  votos: " + voto3 + " porcentaje: " + porcen3.ToString() + " %");
            }
            if (cmbox.SelectedItem.ToString() == "Candidato nº4")
            {
                MessageBox.Show("Candidato nº4:  votos: " + voto4 + " porcentaje: " + porcen4.ToString() + " %");
            }
            lector.Close();
        }
    }
}
