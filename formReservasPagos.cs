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
    public partial class formReservasPagos : Form
    {
        private int usuarioId;
        private controladorReservaPago controlador;

        public formReservasPagos(int usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            controlador = new controladorReservaPago();
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Cargar meses pagados
            var mesesPagados = controlador.ObtenerMesesPagados(usuarioId);
            listBoxMeses.Items.Clear();
            listBoxMeses.Items.AddRange(mesesPagados.ToArray());

            // Cargar reservas del mes seleccionado
            listBoxReservas.Items.Clear();
            if (mesesPagados.Any())
            {
                var reservas = controlador.ObtenerReservasDelMes(usuarioId, mesesPagados[0]);
                listBoxReservas.Items.AddRange(reservas.ToArray());
            }
        }

        private void listBoxMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mesSeleccionado = listBoxMeses.SelectedItem?.ToString();
            if (mesSeleccionado != null)
            {
                var reservas = controlador.ObtenerReservasDelMes(usuarioId, mesSeleccionado);
                listBoxReservas.Items.Clear();
                listBoxReservas.Items.AddRange(reservas.ToArray());
            }
        }
    }
}
