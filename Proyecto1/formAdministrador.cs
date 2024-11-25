using ClosedXML.Excel;
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
    public partial class formAdministrador : Form
    {

        public formAdministrador()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Método que maneja la acción de salir y redirigir a la pantalla de inicio de sesión.
        /// Muestra el formulario de inicio de sesión y cierra el formulario actual.
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
        
            formInicioSesion formularioInicioSesion = new formInicioSesion();
            formularioInicioSesion.Show();

       
            this.Close();
        }

        /// <summary>
        /// Método que maneja la acción de cambiar el horario.
        /// Muestra el formulario para cambiar el horario.
        /// </summary>
        private void btncambiarHorario_Click(object sender, EventArgs e)
        {
            formCambiarHorario formularioCambiarHorario = new formCambiarHorario();
            formularioCambiarHorario.Show();
        }

        /// <summary>
        /// Método que maneja la acción de cambiar el punto fuerte.
        /// Muestra el formulario para cambiar el punto fuerte y cierra el formulario actual.
        /// </summary>
        private void btnPuntoFuerteForm_Click(object sender, EventArgs e)
        {
            formCambiarPuntoFuerte formularioPuntoFuerte = new formCambiarPuntoFuerte();
            formularioPuntoFuerte.Show();
            this.Close();
        }

        /// <summary>
        /// Método que maneja la acción de cambiar la contraseña.
        /// Muestra el formulario para cambiar la contraseña y cierra el formulario actual.
        /// </summary>
        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            formCambiarContraseña formularioCambiarContraseña = new formCambiarContraseña();
            formularioCambiarContraseña.Show();

            this.Close();
        }
    }
}


