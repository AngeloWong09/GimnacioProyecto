namespace Proyecto1
{
    partial class formAdministrador
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btncambiarHorario = new System.Windows.Forms.Button();
            this.btnPuntoFuerteForm = new System.Windows.Forms.Button();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido Administrador";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 54);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Cerrar sesión";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btncambiarHorario
            // 
            this.btncambiarHorario.Location = new System.Drawing.Point(547, 235);
            this.btncambiarHorario.Name = "btncambiarHorario";
            this.btncambiarHorario.Size = new System.Drawing.Size(188, 46);
            this.btncambiarHorario.TabIndex = 21;
            this.btncambiarHorario.Text = "Cambiar horario de entrenador";
            this.btncambiarHorario.UseVisualStyleBackColor = true;
            this.btncambiarHorario.Click += new System.EventHandler(this.btncambiarHorario_Click);
            // 
            // btnPuntoFuerteForm
            // 
            this.btnPuntoFuerteForm.Location = new System.Drawing.Point(311, 235);
            this.btnPuntoFuerteForm.Name = "btnPuntoFuerteForm";
            this.btnPuntoFuerteForm.Size = new System.Drawing.Size(188, 43);
            this.btnPuntoFuerteForm.TabIndex = 22;
            this.btnPuntoFuerteForm.Text = "Cambiar punto fuerte de entrenador";
            this.btnPuntoFuerteForm.UseVisualStyleBackColor = true;
            this.btnPuntoFuerteForm.Click += new System.EventHandler(this.btnPuntoFuerteForm_Click);
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Location = new System.Drawing.Point(105, 235);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(168, 38);
            this.btnCambiarContraseña.TabIndex = 23;
            this.btnCambiarContraseña.Text = "Cambiar Contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // formAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1.Properties.Resources.Altafit_web_800x600;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.btnPuntoFuerteForm);
            this.Controls.Add(this.btncambiarHorario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Name = "formAdministrador";
            this.Text = "formAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btncambiarHorario;
        private System.Windows.Forms.Button btnPuntoFuerteForm;
        private System.Windows.Forms.Button btnCambiarContraseña;
    }
}