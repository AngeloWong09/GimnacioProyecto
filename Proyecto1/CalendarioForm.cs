using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarioPago
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
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtFechaPago.Text = _controlador.ObtenerFechaPago();
            txtFechaPreaviso.Text = _controlador.ObtenerFechaPreaviso();
        }

        private void CalendarioForm_Load(object sender, EventArgs e)
        {

        }
    }
}
