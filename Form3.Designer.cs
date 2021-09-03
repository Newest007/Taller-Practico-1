
namespace Taller_Practico_1
{
    partial class frmejercicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnregresar = new System.Windows.Forms.Button();
            this.btnresultados = new System.Windows.Forms.Button();
            this.cmbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvotar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnregresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregresar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnregresar.Location = new System.Drawing.Point(426, 288);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(125, 43);
            this.btnregresar.TabIndex = 15;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btnresultados
            // 
            this.btnresultados.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresultados.Location = new System.Drawing.Point(268, 288);
            this.btnresultados.Name = "btnresultados";
            this.btnresultados.Size = new System.Drawing.Size(152, 43);
            this.btnresultados.TabIndex = 16;
            this.btnresultados.Text = "Ver resultados";
            this.btnresultados.UseVisualStyleBackColor = true;
            // 
            // cmbox
            // 
            this.cmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox.FormattingEnabled = true;
            this.cmbox.Location = new System.Drawing.Point(330, 93);
            this.cmbox.Name = "cmbox";
            this.cmbox.Size = new System.Drawing.Size(121, 21);
            this.cmbox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ver resultado de:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(115, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "Realizar Voto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Escriba el numero del candidato para votar por él:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 39);
            this.label3.TabIndex = 21;
            this.label3.Text = "Candidato nº1: 1\r\n\r\nCandidato nº2: 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 39);
            this.label4.TabIndex = 22;
            this.label4.Text = "Candidato nº3: 3\r\n\r\nCandidato nº4: 4";
            // 
            // txtvotar
            // 
            this.txtvotar.Location = new System.Drawing.Point(24, 93);
            this.txtvotar.Name = "txtvotar";
            this.txtvotar.Size = new System.Drawing.Size(238, 20);
            this.txtvotar.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sistema de Votación";
            // 
            // frmejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 343);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtvotar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbox);
            this.Controls.Add(this.btnresultados);
            this.Controls.Add(this.btnregresar);
            this.Name = "frmejercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.Load += new System.EventHandler(this.frmejercicio2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btnresultados;
        private System.Windows.Forms.ComboBox cmbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtvotar;
        private System.Windows.Forms.Label label5;
    }
}