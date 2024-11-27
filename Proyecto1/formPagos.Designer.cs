namespace Proyecto1
{
    partial class formPagos
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
            this.Volver = new System.Windows.Forms.Button();
            this.listBoxPagos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(465, 144);
            this.Volver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(161, 28);
            this.Volver.TabIndex = 0;
            this.Volver.Text = "Regresar";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxPagos
            // 
            this.listBoxPagos.FormattingEnabled = true;
            this.listBoxPagos.ItemHeight = 16;
            this.listBoxPagos.Location = new System.Drawing.Point(31, 208);
            this.listBoxPagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxPagos.Name = "listBoxPagos";
            this.listBoxPagos.Size = new System.Drawing.Size(1004, 212);
            this.listBoxPagos.TabIndex = 1;
            // 
            // formPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1.Properties.Resources.Altafit_web_800x600;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listBoxPagos);
            this.Controls.Add(this.Volver);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formPagos";
            this.Text = "formPagos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.ListBox listBoxPagos;
    }
}