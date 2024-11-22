namespace Proyecto1
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
            this.txtFechaPreaviso = new System.Windows.Forms.TextBox();
            this.txtFechaPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolveraMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFechaPreaviso
            // 
            this.txtFechaPreaviso.Location = new System.Drawing.Point(507, 129);
            this.txtFechaPreaviso.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaPreaviso.Name = "txtFechaPreaviso";
            this.txtFechaPreaviso.Size = new System.Drawing.Size(172, 22);
            this.txtFechaPreaviso.TabIndex = 8;
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Location = new System.Drawing.Point(99, 129);
            this.txtFechaPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Size = new System.Drawing.Size(148, 22);
            this.txtFechaPago.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de Preaviso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de Pago";
            // 
            // btnVolveraMenu
            // 
            this.btnVolveraMenu.Location = new System.Drawing.Point(12, 12);
            this.btnVolveraMenu.Name = "btnVolveraMenu";
            this.btnVolveraMenu.Size = new System.Drawing.Size(100, 54);
            this.btnVolveraMenu.TabIndex = 25;
            this.btnVolveraMenu.Text = "< Volver al Menú";
            this.btnVolveraMenu.UseVisualStyleBackColor = true;
            // 
            // CalendarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1.Properties.Resources.Altafit_web_800x600;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolveraMenu);
            this.Controls.Add(this.txtFechaPreaviso);
            this.Controls.Add(this.txtFechaPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalendarioForm";
            this.Text = "CalendarioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFechaPreaviso;
        private System.Windows.Forms.TextBox txtFechaPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolveraMenu;
    }
}