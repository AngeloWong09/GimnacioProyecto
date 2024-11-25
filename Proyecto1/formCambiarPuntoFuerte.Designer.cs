namespace Proyecto1
{
    partial class formCambiarPuntoFuerte
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
            this.btnCambiarPuntoFuerte = new System.Windows.Forms.Button();
            this.comboBoxPuntoFuerte = new System.Windows.Forms.ComboBox();
            this.txtPuntoFuerte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolveraMenu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCambiarPuntoFuerte
            // 
            this.btnCambiarPuntoFuerte.Location = new System.Drawing.Point(466, 308);
            this.btnCambiarPuntoFuerte.Name = "btnCambiarPuntoFuerte";
            this.btnCambiarPuntoFuerte.Size = new System.Drawing.Size(146, 23);
            this.btnCambiarPuntoFuerte.TabIndex = 23;
            this.btnCambiarPuntoFuerte.Text = "Realizar cambio";
            this.btnCambiarPuntoFuerte.UseVisualStyleBackColor = true;
            this.btnCambiarPuntoFuerte.Click += new System.EventHandler(this.btnCambiarPuntoFuerte_Click);
            // 
            // comboBoxPuntoFuerte
            // 
            this.comboBoxPuntoFuerte.FormattingEnabled = true;
            this.comboBoxPuntoFuerte.Location = new System.Drawing.Point(423, 259);
            this.comboBoxPuntoFuerte.Name = "comboBoxPuntoFuerte";
            this.comboBoxPuntoFuerte.Size = new System.Drawing.Size(210, 24);
            this.comboBoxPuntoFuerte.TabIndex = 22;
            // 
            // txtPuntoFuerte
            // 
            this.txtPuntoFuerte.Location = new System.Drawing.Point(414, 180);
            this.txtPuntoFuerte.Name = "txtPuntoFuerte";
            this.txtPuntoFuerte.Size = new System.Drawing.Size(210, 22);
            this.txtPuntoFuerte.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Punto fuerte del entrenador actual";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(209, 289);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(151, 261);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(203, 22);
            this.txtIDUsuario.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(163, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Escribe la ID del Entrenador:";
            // 
            // btnVolveraMenu
            // 
            this.btnVolveraMenu.Location = new System.Drawing.Point(12, 12);
            this.btnVolveraMenu.Name = "btnVolveraMenu";
            this.btnVolveraMenu.Size = new System.Drawing.Size(100, 54);
            this.btnVolveraMenu.TabIndex = 24;
            this.btnVolveraMenu.Text = "< Volver al Menú";
            this.btnVolveraMenu.UseVisualStyleBackColor = true;
            this.btnVolveraMenu.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nombre del Entrenador";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(151, 180);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(210, 22);
            this.txtNombreUsuario.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Punto fuerte del entrenador actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 32);
            this.label3.TabIndex = 28;
            this.label3.Text = "Gimnacio FastForce";
            // 
            // formCambiarPuntoFuerte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1.Properties.Resources.Altafit_web_800x600;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.btnVolveraMenu);
            this.Controls.Add(this.btnCambiarPuntoFuerte);
            this.Controls.Add(this.comboBoxPuntoFuerte);
            this.Controls.Add(this.txtPuntoFuerte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.label2);
            this.Name = "formCambiarPuntoFuerte";
            this.Text = "formCambiarPuntoFuerte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambiarPuntoFuerte;
        private System.Windows.Forms.ComboBox comboBoxPuntoFuerte;
        private System.Windows.Forms.TextBox txtPuntoFuerte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolveraMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}