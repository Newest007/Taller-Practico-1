
namespace Taller_Practico_1
{
    partial class frmejercicio1
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
            this.btnejercicio1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnejercicio1
            // 
            this.btnejercicio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnejercicio1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnejercicio1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnejercicio1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnejercicio1.Location = new System.Drawing.Point(377, 247);
            this.btnejercicio1.Name = "btnejercicio1";
            this.btnejercicio1.Size = new System.Drawing.Size(125, 43);
            this.btnejercicio1.TabIndex = 14;
            this.btnejercicio1.Text = "Regresar";
            this.btnejercicio1.UseVisualStyleBackColor = false;
            this.btnejercicio1.Click += new System.EventHandler(this.btnejercicio1_Click);
            // 
            // frmejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 302);
            this.Controls.Add(this.btnejercicio1);
            this.Name = "frmejercicio1";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnejercicio1;
    }
}