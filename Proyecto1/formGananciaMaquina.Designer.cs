namespace Proyecto1
{
    partial class formGananciaMaquina
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
            this.btnReporte = new System.Windows.Forms.Button();
            this.listReporteMaquina = new System.Windows.Forms.ListBox();
            this.btnGuadarReporte = new System.Windows.Forms.Button();
            this.btnMenuEntrenador = new System.Windows.Forms.Button();
            this.btnDineroIngresoSalida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(137, 267);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(124, 49);
            this.btnReporte.TabIndex = 0;
            this.btnReporte.Text = "Ver reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // listReporteMaquina
            // 
            this.listReporteMaquina.FormattingEnabled = true;
            this.listReporteMaquina.ItemHeight = 16;
            this.listReporteMaquina.Location = new System.Drawing.Point(137, 98);
            this.listReporteMaquina.Name = "listReporteMaquina";
            this.listReporteMaquina.Size = new System.Drawing.Size(550, 132);
            this.listReporteMaquina.TabIndex = 1;
            // 
            // btnGuadarReporte
            // 
            this.btnGuadarReporte.Location = new System.Drawing.Point(563, 267);
            this.btnGuadarReporte.Name = "btnGuadarReporte";
            this.btnGuadarReporte.Size = new System.Drawing.Size(124, 49);
            this.btnGuadarReporte.TabIndex = 2;
            this.btnGuadarReporte.Text = "Guardar reporte";
            this.btnGuadarReporte.UseVisualStyleBackColor = true;
            this.btnGuadarReporte.Click += new System.EventHandler(this.btnGuadarReporte_Click);
            // 
            // btnMenuEntrenador
            // 
            this.btnMenuEntrenador.Location = new System.Drawing.Point(12, 12);
            this.btnMenuEntrenador.Name = "btnMenuEntrenador";
            this.btnMenuEntrenador.Size = new System.Drawing.Size(75, 49);
            this.btnMenuEntrenador.TabIndex = 3;
            this.btnMenuEntrenador.Text = "< Volver al menú";
            this.btnMenuEntrenador.UseVisualStyleBackColor = true;
            this.btnMenuEntrenador.Click += new System.EventHandler(this.btnMenuEntrenador_Click);
            // 
            // btnDineroIngresoSalida
            // 
            this.btnDineroIngresoSalida.Location = new System.Drawing.Point(338, 267);
            this.btnDineroIngresoSalida.Name = "btnDineroIngresoSalida";
            this.btnDineroIngresoSalida.Size = new System.Drawing.Size(143, 49);
            this.btnDineroIngresoSalida.TabIndex = 4;
            this.btnDineroIngresoSalida.Text = "Dinero que ingresa vs la que sale";
            this.btnDineroIngresoSalida.UseVisualStyleBackColor = true;
            this.btnDineroIngresoSalida.Click += new System.EventHandler(this.btnDineroIngresoSalida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gimnacio FastForce";
            // 
            // formGananciaMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1.Properties.Resources.Altafit_web_800x600;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDineroIngresoSalida);
            this.Controls.Add(this.btnMenuEntrenador);
            this.Controls.Add(this.btnGuadarReporte);
            this.Controls.Add(this.listReporteMaquina);
            this.Controls.Add(this.btnReporte);
            this.Name = "formGananciaMaquina";
            this.Text = "formGananciaMaquina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.ListBox listReporteMaquina;
        private System.Windows.Forms.Button btnGuadarReporte;
        private System.Windows.Forms.Button btnMenuEntrenador;
        private System.Windows.Forms.Button btnDineroIngresoSalida;
        private System.Windows.Forms.Label label1;
    }
}