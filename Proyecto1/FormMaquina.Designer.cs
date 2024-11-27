namespace Proyecto1
{
    partial class FormMaquina
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvMaquinas = new System.Windows.Forms.DataGridView();
            this.lblNotificacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(396, 96);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(208, 28);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvMaquinas
            // 
            this.dgvMaquinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinas.Location = new System.Drawing.Point(28, 162);
            this.dgvMaquinas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMaquinas.Name = "dgvMaquinas";
            this.dgvMaquinas.ReadOnly = true;
            this.dgvMaquinas.RowHeadersWidth = 51;
            this.dgvMaquinas.Size = new System.Drawing.Size(1023, 277);
            this.dgvMaquinas.TabIndex = 1;
            // 
            // lblNotificacion
            // 
            this.lblNotificacion.AutoSize = true;
            this.lblNotificacion.Location = new System.Drawing.Point(496, 46);
            this.lblNotificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotificacion.Name = "lblNotificacion";
            this.lblNotificacion.Size = new System.Drawing.Size(44, 16);
            this.lblNotificacion.TabIndex = 2;
            this.lblNotificacion.Text = "label1";
            this.lblNotificacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1.Properties.Resources.Altafit_web_800x600;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblNotificacion);
            this.Controls.Add(this.dgvMaquinas);
            this.Controls.Add(this.btnActualizar);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMaquina";
            this.Text = "FormMaquina";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvMaquinas;
        private System.Windows.Forms.Label lblNotificacion;
    }
}