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
            this.btnActualizar.Location = new System.Drawing.Point(297, 78);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(156, 23);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvMaquinas
            // 
            this.dgvMaquinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinas.Location = new System.Drawing.Point(21, 132);
            this.dgvMaquinas.Name = "dgvMaquinas";
            this.dgvMaquinas.ReadOnly = true;
            this.dgvMaquinas.Size = new System.Drawing.Size(767, 225);
            this.dgvMaquinas.TabIndex = 1;
            // 
            // lblNotificacion
            // 
            this.lblNotificacion.AutoSize = true;
            this.lblNotificacion.Location = new System.Drawing.Point(372, 37);
            this.lblNotificacion.Name = "lblNotificacion";
            this.lblNotificacion.Size = new System.Drawing.Size(35, 13);
            this.lblNotificacion.TabIndex = 2;
            this.lblNotificacion.Text = "label1";
            this.lblNotificacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNotificacion);
            this.Controls.Add(this.dgvMaquinas);
            this.Controls.Add(this.btnActualizar);
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