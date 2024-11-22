using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Modelo
{
    public partial class PagoMembresiaForm : Form
    {
        private readonly CalendarioForm.calendarioControlador controlador;


        public PagoMembresiaForm(controlador)
        {
            InitializeComponent();
            controlador = controlador;
        }

        private void PagoMembresiaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Registrar el pago en el modelo
            controlador.RealizarPago();
            MessageBox.Show("¡Pago realizado exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cerrar el formulario
            this.Close();
        }
    }
}
