namespace Proyecto1
{
    partial class formEntrenador
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnReportesClase = new System.Windows.Forms.Button();
            this.btnGanaciasMaquinas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReportesClase
            // 
            this.btnReportesClase.Location = new System.Drawing.Point(276, 152);
            this.btnReportesClase.Name = "btnReportesClase";
            this.btnReportesClase.Size = new System.Drawing.Size(259, 55);
            this.btnReportesClase.TabIndex = 1;
            this.btnReportesClase.Text = "Ver reportes de clases";
            this.btnReportesClase.UseVisualStyleBackColor = true;
            this.btnReportesClase.Click += new System.EventHandler(this.btnReportesClase_Click);
            // 
            // btnGanaciasMaquinas
            // 
            this.btnGanaciasMaquinas.Location = new System.Drawing.Point(276, 228);
            this.btnGanaciasMaquinas.Name = "btnGanaciasMaquinas";
            this.btnGanaciasMaquinas.Size = new System.Drawing.Size(259, 47);
            this.btnGanaciasMaquinas.TabIndex = 2;
            this.btnGanaciasMaquinas.Text = "Ganacias por maquinas";
            this.btnGanaciasMaquinas.UseVisualStyleBackColor = true;
            this.btnGanaciasMaquinas.Click += new System.EventHandler(this.btnGanaciasMaquinas_Click);
            // 
            // formEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1.Properties.Resources.Altafit_web_800x600;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGanaciasMaquinas);
            this.Controls.Add(this.btnReportesClase);
            this.Controls.Add(this.button1);
            this.Name = "formEntrenador";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReportesClase;
        private System.Windows.Forms.Button btnGanaciasMaquinas;
    }
}