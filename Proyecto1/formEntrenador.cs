using System;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class formEntrenador : Form
    {
        public formEntrenador()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Redirigue al entrenador a inicio de sesión y cierra el formulario actual.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            formInicioSesion inicioSesionForm = new formInicioSesion();
            inicioSesionForm.Show();
            this.Close();
        }

        /// <summary>
        /// Redirigue al entrenador a reportes de clases y cierra el formulario actual.
        /// </summary>
        private void btnReportesClase_Click(object sender, EventArgs e)
        {
            formReporteClases reporteClasesForm = new formReporteClases();
            reporteClasesForm.Show();
            this.Close();
        }

        /// <summary>
        /// Redirigue al entrenador a  ganancias de máquinas y cierra el formulario actual.
        /// </summary>
        private void btnGanaciasMaquinas_Click(object sender, EventArgs e)
        {
            var formularioGananciaMaquina = new formGananciaMaquina();
            this.Close();
            formularioGananciaMaquina.ShowDialog();
        }
    }
}
