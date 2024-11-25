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
            this.txtUsuarioId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnconsultaReserva = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxConsulta = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnVerPagos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizarMenbresia
            // 
            this.btnActualizarMenbresia.Location = new System.Drawing.Point(684, 20);
            this.btnActualizarMenbresia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarMenbresia.Name = "btnActualizarMenbresia";
            this.btnActualizarMenbresia.Size = new System.Drawing.Size(104, 53);
            this.btnActualizarMenbresia.TabIndex = 1;
            this.btnActualizarMenbresia.Text = "Actualizar Membresia";
            this.btnActualizarMenbresia.UseVisualStyleBackColor = true;
            this.btnActualizarMenbresia.Click += new System.EventHandler(this.btnActualizarMenbresia_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 338);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Buscar clase";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxClases
            // 
            this.comboBoxClases.FormattingEnabled = true;
            this.comboBoxClases.Location = new System.Drawing.Point(35, 305);
            this.comboBoxClases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxClases.Name = "comboBoxClases";
            this.comboBoxClases.Size = new System.Drawing.Size(165, 24);
            this.comboBoxClases.TabIndex = 4;
            // 
            // listBoxReservas
            // 
            this.listBoxReservas.FormattingEnabled = true;
            this.listBoxReservas.ItemHeight = 16;
            this.listBoxReservas.Location = new System.Drawing.Point(251, 305);
            this.listBoxReservas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxReservas.Name = "listBoxReservas";
            this.listBoxReservas.Size = new System.Drawing.Size(521, 52);
            this.listBoxReservas.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(635, 363);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "Guardar reserva";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtUsuarioId
            // 
            this.txtUsuarioId.Location = new System.Drawing.Point(32, 172);
            this.txtUsuarioId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuarioId.Name = "txtUsuarioId";
            this.txtUsuarioId.Size = new System.Drawing.Size(165, 22);
            this.txtUsuarioId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Su Id de usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccione la clase a inscribirse:";
            // 
            // btnconsultaReserva
            // 
            this.btnconsultaReserva.BackColor = System.Drawing.SystemColors.Control;
            this.btnconsultaReserva.Location = new System.Drawing.Point(32, 212);
            this.btnconsultaReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnconsultaReserva.Name = "btnconsultaReserva";
            this.btnconsultaReserva.Size = new System.Drawing.Size(165, 44);
            this.btnconsultaReserva.TabIndex = 9;
            this.btnconsultaReserva.Text = "Consultar reservas de clases";
            this.btnconsultaReserva.UseVisualStyleBackColor = false;
            this.btnconsultaReserva.Click += new System.EventHandler(this.btnconsultaReserva_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccione la clase que desea:";
            // 
            // listBoxConsulta
            // 
            this.listBoxConsulta.FormattingEnabled = true;
            this.listBoxConsulta.ItemHeight = 16;
            this.listBoxConsulta.Location = new System.Drawing.Point(251, 204);
            this.listBoxConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxConsulta.Name = "listBoxConsulta";
            this.listBoxConsulta.Size = new System.Drawing.Size(521, 52);
            this.listBoxConsulta.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sus clases programadas:";
            // 
            // btnCalendario
            // 
            this.btnCalendario.Location = new System.Drawing.Point(684, 77);
            this.btnCalendario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(104, 43);
            this.btnCalendario.TabIndex = 13;
            this.btnCalendario.Text = "Calendario";
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // btnVerPagos
            // 
            this.btnVerPagos.Location = new System.Drawing.Point(684, 126);
            this.btnVerPagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerPagos.Name = "btnVerPagos";
            this.btnVerPagos.Size = new System.Drawing.Size(103, 59);
            this.btnVerPagos.TabIndex = 14;
            this.btnVerPagos.Text = "Ver Pagos";
            this.btnVerPagos.UseVisualStyleBackColor = true;
            this.btnVerPagos.Click += new System.EventHandler(this.btnVerPagos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Gimnacio FastForce";
            // 
            // formUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1.Properties.Resources.Altafit_web_800x600;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVerPagos);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxConsulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnconsultaReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuarioId);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxClases);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBoxReservas);
            this.Controls.Add(this.btnActualizarMenbresia);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formUsuario";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnActualizarMenbresia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxClases;
        private System.Windows.Forms.ListBox listBoxReservas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtUsuarioId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnconsultaReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Button btnVerPagos;
        private System.Windows.Forms.Label label5;
    }
}