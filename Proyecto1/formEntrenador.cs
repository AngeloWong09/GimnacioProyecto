using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class formEntrenador : Form
    {
        public formEntrenador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario formInicioSesion
            formInicioSesion inicioSesionForm = new formInicioSesion();

            // Mostrar el formulario formInicioSesion
            inicioSesionForm.Show();

            // Cerrar el formulario actual
            this.Close();
        }

        private void btnReportesClase_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario formReporteClases
            formReporteClases reporteClasesForm = new formReporteClases();

            // Mostrar el formulario formReporteClases
            reporteClasesForm.Show();

            // Cerrar el formulario actual
            this.Close();
        }
    }
}
