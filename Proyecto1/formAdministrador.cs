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



        private void btnSalir_Click(object sender, EventArgs e)
        {
        
            formInicioSesion formularioInicioSesion = new formInicioSesion();
            formularioInicioSesion.Show();

       
            this.Close();
        }

        private void btncambiarHorario_Click(object sender, EventArgs e)
        {
            FormCambiarHorario formularioCambiarHorario = new FormCambiarHorario();
            formularioCambiarHorario.Show();
        }

        private void btnPuntoFuerteForm_Click(object sender, EventArgs e)
        {
            formCambiarPuntoFuerte formularioPuntoFuerte = new formCambiarPuntoFuerte();
            formularioPuntoFuerte.Show();
            this.Close();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            formCambiarContraseña formularioCambiarContraseña = new formCambiarContraseña();
            formularioCambiarContraseña.Show();

            // Cerrar el formulario actual
            this.Close();
        }
    }
}


