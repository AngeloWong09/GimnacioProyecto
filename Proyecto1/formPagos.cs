using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto1.Controlador;
using Proyecto1.Modelo;

namespace Proyecto1
{
    public partial class formPagos : Form
    {
        private readonly controladorPagos controlador;
        private int usuarioId;

        public formPagos(int usuarioID)
        {
            InitializeComponent();
            controlador = new controladorPagos();
            this.usuarioId = usuarioId;
            CargarPagos(usuarioID);
        }

        private void CargarPagos(int usuarioID)
        {//se buscan los pagos en el csv
            listBoxPagos.Items.Clear();
            var pagos = controlador.ObtenerPagosPorUsuario(usuarioId);

            if (pagos.Any())
            {
                foreach (var pago in pagos)
                {
                    listBoxPagos.Items.Add($"Mes: {pago.MesPago}, Monto: {pago.Monto:C}");
                }
            }
            else
            {
                listBoxPagos.Items.Add("No se encontraron pagos.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
