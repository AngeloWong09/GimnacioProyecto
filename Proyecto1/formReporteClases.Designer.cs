namespace Proyecto1
{
    partial class formReporteClases
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
            this.listbReporteClase = new System.Windows.Forms.ListBox();
            this.btnFiltrarClase = new System.Windows.Forms.Button();
            this.btnFiltrarHorario = new System.Windows.Forms.Button();
            this.txtIdEntrenador = new System.Windows.Forms.TextBox();
            this.btnBuscarEntrenador = new System.Windows.Forms.Button();
            this.btnGaradarReporte = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "< Volver al menú";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listbReporteClase
            // 
            this.listbReporteClase.FormattingEnabled = true;
            this.listbReporteClase.ItemHeight = 16;
            this.listbReporteClase.Location = new System.Drawing.Point(276, 172);
            this.listbReporteClase.Name = "listbReporteClase";
            this.listbReporteClase.Size = new System.Drawing.Size(350, 84);
            this.listbReporteClase.TabIndex = 1;
            // 
            // btnFiltrarClase
            // 
            this.btnFiltrarClase.Location = new System.Drawing.Point(276, 278);
            this.btnFiltrarClase.Name = "btnFiltrarClase";
            this.btnFiltrarClase.Size = new System.Drawing.Size(128, 23);
            this.btnFiltrarClase.TabIndex = 2;
            this.btnFiltrarClase.Text = "Filtrar por clase";
            this.btnFiltrarClase.UseVisualStyleBackColor = true;
            this.btnFiltrarClase.Click += new System.EventHandler(this.btnFiltrarClase_Click);
            // 
            // btnFiltrarHorario
            // 
            this.btnFiltrarHorario.Location = new System.Drawing.Point(485, 278);
            this.btnFiltrarHorario.Name = "btnFiltrarHorario";
            this.btnFiltrarHorario.Size = new System.Drawing.Size(141, 23);
            this.btnFiltrarHorario.TabIndex = 3;
            this.btnFiltrarHorario.Text = "Filtrar por horario";
            this.btnFiltrarHorario.UseVisualStyleBackColor = true;
            this.btnFiltrarHorario.Click += new System.EventHandler(this.btnFiltrarHorario_Click);
            // 
            // txtIdEntrenador
            // 
            this.txtIdEntrenador.Location = new System.Drawing.Point(132, 185);
            this.txtIdEntrenador.Name = "txtIdEntrenador";
            this.txtIdEntrenador.Size = new System.Drawing.Size(100, 22);
            this.txtIdEntrenador.TabIndex = 4;
            // 
            // btnBuscarEntrenador
            // 
            this.btnBuscarEntrenador.Location = new System.Drawing.Point(117, 213);
            this.btnBuscarEntrenador.Name = "btnBuscarEntrenador";
            this.btnBuscarEntrenador.Size = new System.Drawing.Size(124, 43);
            this.btnBuscarEntrenador.TabIndex = 5;
            this.btnBuscarEntrenador.Text = "Buscar tu nombre entrenador";
            this.btnBuscarEntrenador.UseVisualStyleBackColor = true;
            this.btnBuscarEntrenador.Click += new System.EventHandler(this.btnBuscarEntrenador_Click);
            // 
            // btnGaradarReporte
            // 
            this.btnGaradarReporte.Location = new System.Drawing.Point(495, 338);
            this.btnGaradarReporte.Name = "btnGaradarReporte";
            this.btnGaradarReporte.Size = new System.Drawing.Size(131, 23);
            this.btnGaradarReporte.TabIndex = 6;
            this.btnGaradarReporte.Text = "Guardar reporte";
            this.btnGaradarReporte.UseVisualStyleBackColor = true;
            this.btnGaradarReporte.Click += new System.EventHandler(this.btnGaradarReporte_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(276, 338);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(128, 23);
            this.btnMostrarTodo.TabIndex = 7;
            this.btnMostrarTodo.Text = "Mostrar Todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gimnacio FastForce";
            // 
            // formReporteClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1.Properties.Resources.Altafit_web_800x600;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnGaradarReporte);
            this.Controls.Add(this.btnBuscarEntrenador);
            this.Controls.Add(this.txtIdEntrenador);
            this.Controls.Add(this.btnFiltrarHorario);
            this.Controls.Add(this.btnFiltrarClase);
            this.Controls.Add(this.listbReporteClase);
            this.Controls.Add(this.button1);
            this.Name = "formReporteClases";
            this.Text = "formReporteClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listbReporteClase;
        private System.Windows.Forms.Button btnFiltrarClase;
        private System.Windows.Forms.Button btnFiltrarHorario;
        private System.Windows.Forms.TextBox txtIdEntrenador;
        private System.Windows.Forms.Button btnBuscarEntrenador;
        private System.Windows.Forms.Button btnGaradarReporte;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Label label1;
    }
}