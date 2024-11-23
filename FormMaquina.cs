using Proyecto1.Controlador;
using Proyecto1.Modelo;
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
    public partial class FormMaquina : Form
    {    //logica
        private readonly controladorMaquina controlador;

        public FormMaquina()
        {
            InitializeComponent();
            controlador = new controladorMaquina();
            CargarMaquinas();
        }

        private void CargarMaquinas()
        {
            // Llama al controlador para obtener las máquinas próximas a caducar, vinculando la lista al DataGrid, ademas actualiza el texto del label
            List<maquinaModelo> maquinasPorCaducar = controlador.ObtenerMaquinasPorCaducar();

            
            dgvMaquinas.DataSource = maquinasPorCaducar;

            
            if (maquinasPorCaducar.Count > 0)
            {
                lblNotificacion.Text = "¡Alerta! Hay máquinas próximas a caducar."; 
                lblNotificacion.ForeColor = System.Drawing.Color.Red; 
            }
            else
            {
                lblNotificacion.Text = "Todas las máquinas están en buen estado."; 
                lblNotificacion.ForeColor = System.Drawing.Color.Green; 
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarMaquinas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
