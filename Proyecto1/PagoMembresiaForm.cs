using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Proyecto1;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto1.Controlador;

namespace Proyecto1
{
    public partial class PagoMembresiaForm : Form
    {
        private readonly controladorCalendario _controlador;

        public PagoMembresiaForm(controladorCalendario controlador)
        {
            InitializeComponent();
            _controlador = controlador;
        }


        private void btnVolveraMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Registra el pago en el modelo
            _controlador.RealizarPago();
            MessageBox.Show("¡Pago realizado exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cierra el formulario
            this.Close();
        }
    }
}
