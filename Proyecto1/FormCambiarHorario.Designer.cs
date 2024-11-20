namespace Proyecto1
{
    partial class FormCambiarHorario
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
            this.btnVolveraMenu = new System.Windows.Forms.Button();
            this.comboBoxNuevoDia = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxNuevaHora = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaActual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoraActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIDClase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEntrenadorDesignado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroClase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolveraMenu
            // 
            this.btnVolveraMenu.Location = new System.Drawing.Point(13, 13);
            this.btnVolveraMenu.Name = "btnVolveraMenu";
            this.btnVolveraMenu.Size = new System.Drawing.Size(95, 47);
            this.btnVolveraMenu.TabIndex = 0;
            this.btnVolveraMenu.Text = "< Volver al menú";
            this.btnVolveraMenu.UseVisualStyleBackColor = true;
            this.btnVolveraMenu.Click += new System.EventHandler(this.btnVolveraMenu_Click);
            // 
            // comboBoxNuevoDia
            // 
            this.comboBoxNuevoDia.FormattingEnabled = true;
            this.comboBoxNuevoDia.Location = new System.Drawing.Point(572, 224);
            this.comboBoxNuevoDia.Name = "comboBoxNuevoDia";
            this.comboBoxNuevoDia.Size = new System.Drawing.Size(188, 24);
            this.comboBoxNuevoDia.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(569, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Nuevo dia";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Cambiar horario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxNuevaHora
            // 
            this.comboBoxNuevaHora.FormattingEnabled = true;
            this.comboBoxNuevaHora.Location = new System.Drawing.Point(572, 292);
            this.comboBoxNuevaHora.Name = "comboBoxNuevaHora";
            this.comboBoxNuevaHora.Size = new System.Drawing.Size(188, 24);
            this.comboBoxNuevaHora.TabIndex = 27;
            this.comboBoxNuevaHora.SelectedIndexChanged += new System.EventHandler(this.comboBoxNuevaHora_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nueva Hora";
            // 
            // txtDiaActual
            // 
            this.txtDiaActual.Location = new System.Drawing.Point(313, 224);
            this.txtDiaActual.Name = "txtDiaActual";
            this.txtDiaActual.Size = new System.Drawing.Size(188, 22);
            this.txtDiaActual.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Dia actual";
            // 
            // txtHoraActual
            // 
            this.txtHoraActual.Location = new System.Drawing.Point(313, 298);
            this.txtHoraActual.Name = "txtHoraActual";
            this.txtHoraActual.Size = new System.Drawing.Size(188, 22);
            this.txtHoraActual.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Hora actual";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(342, 125);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtIDClase
            // 
            this.txtIDClase.Location = new System.Drawing.Point(313, 97);
            this.txtIDClase.Name = "txtIDClase";
            this.txtIDClase.Size = new System.Drawing.Size(155, 22);
            this.txtIDClase.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Escribe la ID de la Clase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cambio de horario";
            // 
            // txtEntrenadorDesignado
            // 
            this.txtEntrenadorDesignado.Location = new System.Drawing.Point(52, 298);
            this.txtEntrenadorDesignado.Name = "txtEntrenadorDesignado";
            this.txtEntrenadorDesignado.Size = new System.Drawing.Size(188, 22);
            this.txtEntrenadorDesignado.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Entrenador designado";
            // 
            // txtNumeroClase
            // 
            this.txtNumeroClase.Location = new System.Drawing.Point(52, 224);
            this.txtNumeroClase.Name = "txtNumeroClase";
            this.txtNumeroClase.Size = new System.Drawing.Size(188, 22);
            this.txtNumeroClase.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Numero de clase";
            // 
            // FormCambiarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1.Properties.Resources.Altafit_web_800x600;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumeroClase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEntrenadorDesignado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIDClase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoraActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNuevoDia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxNuevaHora);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDiaActual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVolveraMenu);
            this.Name = "FormCambiarHorario";
            this.Text = "FormCambiarHorario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolveraMenu;
        private System.Windows.Forms.ComboBox comboBoxNuevoDia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxNuevaHora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaActual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoraActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIDClase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEntrenadorDesignado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroClase;
        private System.Windows.Forms.Label label5;
    }
}