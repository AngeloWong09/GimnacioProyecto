using CalendarioPago;
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
    public partial class CalendarioForm : Form
    {
        private readonly calendarioControlador _controlador;

        public CalendarioForm()
        {
            InitializeComponent();

            var modelo = new CalendarioModelo();
            _controlador = new calendarioControlador(modelo);

            InicializarVista();
        }

        private void InicializarVista()
        {
            txtFechaPago.Text = _controlador.ObtenerFechaPago();
            txtFechaPreaviso.Text = _controlador.ObtenerFechaPreaviso();

            if (_controlador.VerificarPreaviso())
            {
                lblNotificacion.Text = "¡Aviso! Su pago está próximo.";
                lblNotificacion.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblNotificacion.Text = "";
            }

            if (_controlador.VerificarFechaPago())
            {
                var pagoMembresiaForm = new PagoMembresiaForm(_controlador);
                pagoMembresiaForm.ShowDialog(); // Mostrar el formulario como un diálogo modal
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
