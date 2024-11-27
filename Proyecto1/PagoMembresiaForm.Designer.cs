namespace Proyecto1
{
    partial class PagoMembresiaForm
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
            this.btnPagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolveraMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(220, 120);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(135, 23);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "Pagar con Tarjeta";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "¿Desea realizar el pago?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // PagoMembresiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1.Properties.Resources.Altafit_web_800x600;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnVolveraMenu);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PagoMembresiaForm";
            this.Text = "PagoMembresiaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolveraMenu;
    }
}