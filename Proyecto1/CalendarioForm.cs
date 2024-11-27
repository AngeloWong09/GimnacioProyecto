using CalendarioPago;
using Proyecto1.Controlador;
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
    public partial class CalendarioForm : Form
    {
        private readonly controladorCalendario controlador;//para poder obtener datos del controlador
        public CalendarioForm()
        {//inicializamos valores a usar en general
            InitializeComponent();
            var modelo = new CalendarioModelo();
            controlador = new controladorCalendario(modelo);
            InicializarVista();
        }
        private void InicializarVista()
        {//tomamos datos del controlador
            txtFechaPago.Text = controlador.ObtenerFechaPago();
            txtFechaPreaviso.Text = controlador.ObtenerFechaPreaviso();

            if (controlador.VerificarPreaviso())
            {//si es fecha preaviso muestra la alerta
               label1.Text = "¡Aviso! Su pago está próximo.";//
               label1.ForeColor = System.Drawing.Color.Red;//
            }
            else
            {
                label2.Text = "";
            }

            if (controlador.VerificarFechaPago()) //revisa que sea fecha de pago y abre el form de pago
            {
                var pagoMembresiaForm = new PagoMembresiaForm(controlador);
                pagoMembresiaForm.ShowDialog(); 
            }
        }
        private void btnVolveraMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFechaPreaviso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaPago_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
