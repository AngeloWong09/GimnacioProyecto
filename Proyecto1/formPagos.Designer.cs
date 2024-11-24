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
            this.Volver.Location = new System.Drawing.Point(349, 117);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(121, 23);
            this.Volver.TabIndex = 0;
            this.Volver.Text = "Regresar";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxPagos
            // 
            this.listBoxPagos.FormattingEnabled = true;
            this.listBoxPagos.Location = new System.Drawing.Point(23, 169);
            this.listBoxPagos.Name = "listBoxPagos";
            this.listBoxPagos.Size = new System.Drawing.Size(754, 173);
            this.listBoxPagos.TabIndex = 1;
            // 
            // formPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxPagos);
            this.Controls.Add(this.Volver);
            this.Name = "formPagos";
            this.Text = "formPagos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.ListBox listBoxPagos;
    }
}