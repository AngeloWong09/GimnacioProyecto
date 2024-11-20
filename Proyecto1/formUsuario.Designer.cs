namespace Proyecto1
{
    partial class formUsuario
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
            this.btnActualizarMenbresia = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxClases = new System.Windows.Forms.ComboBox();
            this.listBoxReservas = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizarMenbresia
            // 
            this.btnActualizarMenbresia.Location = new System.Drawing.Point(629, 76);
            this.btnActualizarMenbresia.Name = "btnActualizarMenbresia";
            this.btnActualizarMenbresia.Size = new System.Drawing.Size(126, 53);
            this.btnActualizarMenbresia.TabIndex = 1;
            this.btnActualizarMenbresia.Text = "Actualizar Membresia";
            this.btnActualizarMenbresia.UseVisualStyleBackColor = true;
            this.btnActualizarMenbresia.Click += new System.EventHandler(this.btnActualizarMenbresia_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Buscar clase";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxClases
            // 
            this.comboBoxClases.FormattingEnabled = true;
            this.comboBoxClases.Location = new System.Drawing.Point(80, 298);
            this.comboBoxClases.Name = "comboBoxClases";
            this.comboBoxClases.Size = new System.Drawing.Size(165, 24);
            this.comboBoxClases.TabIndex = 4;
            // 
            // listBoxReservas
            // 
            this.listBoxReservas.FormattingEnabled = true;
            this.listBoxReservas.ItemHeight = 16;
            this.listBoxReservas.Location = new System.Drawing.Point(251, 206);
            this.listBoxReservas.Name = "listBoxReservas";
            this.listBoxReservas.Size = new System.Drawing.Size(537, 116);
            this.listBoxReservas.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(514, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "Guardar reserva";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // formUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1.Properties.Resources.Altafit_web_800x600;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxClases);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBoxReservas);
            this.Controls.Add(this.btnActualizarMenbresia);
            this.Controls.Add(this.button1);
            this.Name = "formUsuario";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnActualizarMenbresia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxClases;
        private System.Windows.Forms.ListBox listBoxReservas;
        private System.Windows.Forms.Button button3;
    }
}