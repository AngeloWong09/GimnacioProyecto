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
            this.txtFechaPreaviso.Location = new System.Drawing.Point(380, 105);
            this.txtFechaPreaviso.Name = "txtFechaPreaviso";
            this.txtFechaPreaviso.Size = new System.Drawing.Size(130, 20);
            this.txtFechaPreaviso.TabIndex = 8;
            this.txtFechaPreaviso.TextChanged += new System.EventHandler(this.txtFechaPreaviso_TextChanged);
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Location = new System.Drawing.Point(74, 105);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Size = new System.Drawing.Size(112, 20);
            this.txtFechaPago.TabIndex = 7;
            this.txtFechaPago.TextChanged += new System.EventHandler(this.txtFechaPago_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de Preaviso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de Pago";
            // 
            // btnVolveraMenu
            // 
            this.btnVolveraMenu.Location = new System.Drawing.Point(9, 10);
            this.btnVolveraMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolveraMenu.Name = "btnVolveraMenu";
            this.btnVolveraMenu.Size = new System.Drawing.Size(75, 44);
            this.btnVolveraMenu.TabIndex = 25;
            this.btnVolveraMenu.Text = "< Volver al Menú";
            this.btnVolveraMenu.UseVisualStyleBackColor = true;
            this.btnVolveraMenu.Click += new System.EventHandler(this.btnVolveraMenu_Click);
            // 
            // CalendarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1.Properties.Resources.Altafit_web_800x600;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnVolveraMenu);
            this.Controls.Add(this.txtFechaPreaviso);
            this.Controls.Add(this.txtFechaPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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