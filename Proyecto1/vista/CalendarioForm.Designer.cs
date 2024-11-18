namespace CalendarioPago
{
    partial class CalendarioForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaPago = new System.Windows.Forms.TextBox();
            this.txtFechaPreaviso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Pago";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Preaviso";
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Location = new System.Drawing.Point(132, 124);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.ReadOnly = true;
            this.txtFechaPago.Size = new System.Drawing.Size(100, 20);
            this.txtFechaPago.TabIndex = 2;
            // 
            // txtFechaPreaviso
            // 
            this.txtFechaPreaviso.Location = new System.Drawing.Point(322, 124);
            this.txtFechaPreaviso.Name = "txtFechaPreaviso";
            this.txtFechaPreaviso.ReadOnly = true;
            this.txtFechaPreaviso.Size = new System.Drawing.Size(100, 20);
            this.txtFechaPreaviso.TabIndex = 3;
            // 
            // CalendarioForm
            // 
            this.ClientSize = new System.Drawing.Size(553, 261);
            this.Controls.Add(this.txtFechaPreaviso);
            this.Controls.Add(this.txtFechaPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalendarioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFechaPago;
        private System.Windows.Forms.TextBox txtFechaPreaviso;
    }
}