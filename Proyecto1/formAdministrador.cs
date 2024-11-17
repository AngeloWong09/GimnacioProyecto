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
        private string rutaUsuarios = "Usuarios.xlsx"; // Ruta del archivo Excel
        public formAdministrador()
        {
            InitializeComponent();
        }

        //---------------------------------
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string idBuscado = txtIDUsuario.Text; // Leer el ID como string
                var workbook = new XLWorkbook(rutaUsuarios);
                var worksheet = workbook.Worksheet("Sheet1");

                // Buscar la fila con el ID (columna 6)
                var fila = worksheet.RowsUsed()
                                    .FirstOrDefault(row => row.Cell(6).GetValue<string>().Equals(idBuscado, StringComparison.OrdinalIgnoreCase));

                if (fila != null)
                {
                    txtNombreUsuario.Text = fila.Cell(1).GetValue<string>(); // Nombre de Usuario
                    txtContraseñaAntigua.Text = fila.Cell(2).GetValue<string>(); // Contraseña
                }
                else
                {
                    MessageBox.Show("ID no encontrado.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar usuario: {ex.Message}", "Error");
            }
        }


        private void btnNuevaContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                string idBuscado = txtIDUsuario.Text; // Leer el ID como string
                string nuevaContraseña = txtNuevaContraseña.Text;

                if (string.IsNullOrWhiteSpace(nuevaContraseña))
                {
                    MessageBox.Show("La nueva contraseña no puede estar vacía.", "Advertencia");
                    return;
                }

                var workbook = new XLWorkbook(rutaUsuarios);
                var worksheet = workbook.Worksheet("Sheet1");

                // Buscar la fila con el ID (columna 6)
                var fila = worksheet.RowsUsed()
                                    .FirstOrDefault(row => row.Cell(6).GetValue<string>().Equals(idBuscado, StringComparison.OrdinalIgnoreCase));

                if (fila != null)
                {
                    // Actualizar la contraseña (columna 2)
                    fila.Cell(2).Value = nuevaContraseña;

                    // Guardar los cambios en el archivo Excel
                    workbook.SaveAs(rutaUsuarios);

                    MessageBox.Show("Contraseña actualizada exitosamente.", "Éxito");
                }
                else
                {
                    MessageBox.Show("ID no encontrado.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar contraseña: {ex.Message}", "Error");
            }
        }
    }
}
