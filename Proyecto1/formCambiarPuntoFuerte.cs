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
    public partial class formCambiarPuntoFuerte : Form
    {
        private string rutaEntrenadores = "Entrenadores.xlsx"; // Ruta del archivo Entrenadores
        public formCambiarPuntoFuerte()
        {
            InitializeComponent();
            comboBoxPuntoFuerte.Items.AddRange(new string[] { "Zumba", "CardioDance", "Funcionales" });
        }

        //nuevo: Método para actualizar el punto fuerte en el archivo Entrenadores
        private bool ActualizarPuntoFuerte(string rutaArchivo, string idBuscado, string nuevoPuntoFuerte, int columnaID, int columnaPuntoFuerte)
        {
            var workbook = new XLWorkbook(rutaArchivo);
            var worksheet = workbook.Worksheet("Hoja1");

            // Buscar la fila con el ID en la columna correspondiente
            var fila = worksheet.RowsUsed()
                                .FirstOrDefault(row => row.Cell(columnaID).GetValue<string>().Equals(idBuscado, StringComparison.OrdinalIgnoreCase));

            if (fila != null)
            {
                // Actualizar el punto fuerte en la columna correspondiente
                fila.Cell(columnaPuntoFuerte).Value = nuevoPuntoFuerte;

                // Guardar los cambios en el archivo Excel
                workbook.SaveAs(rutaArchivo);
                return true;
            }
            return false;

        }
        private bool BuscarYMostrarDatosEntrenadores(string rutaArchivo, string idBuscado, int columnaID, int columnaPuntoFuerte)
        {
            var workbook = new XLWorkbook(rutaArchivo);
            var worksheet = workbook.Worksheet("Hoja1");

            // Buscar la fila con el ID en la columna correspondiente
            var fila = worksheet.RowsUsed()
                                .FirstOrDefault(row => row.Cell(columnaID).GetValue<string>().Equals(idBuscado, StringComparison.OrdinalIgnoreCase));

            if (fila != null)
            {
                txtNombreUsuario.Text = fila.Cell(1).GetValue<string>(); // Nombre de Usuario
                txtPuntoFuerte.Text = fila.Cell(columnaPuntoFuerte).GetValue<string>(); // Punto Fuerte
                return true;
            }
            return false;
        }

        private void btnCambiarPuntoFuerte_Click(object sender, EventArgs e)
        {
            try
            {
                string idBuscado = txtIDUsuario.Text; // Leer el ID como string
                string nuevoPuntoFuerte = comboBoxPuntoFuerte.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(nuevoPuntoFuerte))
                {
                    MessageBox.Show("Debe seleccionar un nuevo punto fuerte.", "Advertencia");
                    return;
                }

                // Actualizar en Entrenadores
                if (ActualizarPuntoFuerte(rutaEntrenadores, idBuscado, nuevoPuntoFuerte, 5, 6))
                {
                    MessageBox.Show("Punto fuerte actualizado exitosamente.", "Éxito");
                }
                else
                {
                    MessageBox.Show("ID no encontrado en el archivo Entrenadores.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar el punto fuerte: {ex.Message}", "Error");
            }
        }

    

        private void btnSalir_Click(object sender, EventArgs e)
        {
            formAdministrador formularioAdministrador = new formAdministrador();
            formularioAdministrador.Show();

            // Cerrar el formulario actual
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string idBuscado = txtIDUsuario.Text; // Leer el ID como string

                if (!BuscarYMostrarDatosEntrenadores(rutaEntrenadores, idBuscado, 5, 6))
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar usuario: {ex.Message}", "Error");
            }
        }

  


        private void txtPuntoFuerte_TextChanged(object sender, EventArgs e)
        {

        }


     
    }
    }

