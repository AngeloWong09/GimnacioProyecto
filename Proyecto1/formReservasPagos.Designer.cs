namespace Proyecto1
{
    partial class formReservasPagos
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
            this.listBoxMeses = new System.Windows.Forms.ListBox();
            this.listBoxReservas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxMeses
            // 
            this.listBoxMeses.FormattingEnabled = true;
            this.listBoxMeses.Location = new System.Drawing.Point(12, 45);
            this.listBoxMeses.Name = "listBoxMeses";
            this.listBoxMeses.Size = new System.Drawing.Size(662, 108);
            this.listBoxMeses.TabIndex = 0;
            this.listBoxMeses.SelectedIndexChanged += new System.EventHandler(this.listBoxMeses_SelectedIndexChanged);
            // 
            // listBoxReservas
            // 
            this.listBoxReservas.FormattingEnabled = true;
            this.listBoxReservas.Location = new System.Drawing.Point(12, 180);
            this.listBoxReservas.Name = "listBoxReservas";
            this.listBoxReservas.Size = new System.Drawing.Size(662, 160);
            this.listBoxReservas.TabIndex = 1;
            // 
            // formReservasPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxReservas);
            this.Controls.Add(this.listBoxMeses);
            this.Name = "formReservasPagos";
            this.Text = "formReservasPagos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMeses;
        private System.Windows.Forms.ListBox listBoxReservas;
    }
}