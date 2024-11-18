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
        private string rutaUsuarios = "Usuarios.xlsx";       // Ruta del archivo Usuarios
        private string rutaEntrenadores = "Entrenadores.xlsx"; // Ruta del archivo Entrenadores
        private string rutaAdministradores = "Administrador.xlsx"; // Ruta del archivo Administradores

        public formAdministrador()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string idBuscado = txtIDUsuario.Text; // Leer el ID como string

                // Buscar en Usuarios
                if (!BuscarYMostrarDatos(rutaUsuarios, idBuscado, 7))
                {
                    // Buscar en Entrenadores
                    if (!BuscarYMostrarDatos(rutaEntrenadores, idBuscado, 5))
                    {
                        // Buscar en Administradores
                        if (!BuscarYMostrarDatos(rutaAdministradores, idBuscado, 5))
                        {
                            MessageBox.Show("ID no encontrado en ninguno de los archivos.", "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar usuario: {ex.Message}", "Error");
            }
        }

        private bool BuscarYMostrarDatos(string rutaArchivo, string idBuscado, int columnaID)
        {
            var workbook = new XLWorkbook(rutaArchivo);
            var worksheet = workbook.Worksheet("Sheet1");

            // Buscar la fila con el ID en la columna correspondiente
            var fila = worksheet.RowsUsed()
                                .FirstOrDefault(row => row.Cell(columnaID).GetValue<string>().Equals(idBuscado, StringComparison.OrdinalIgnoreCase));

            if (fila != null)
            {
                txtNombreUsuario.Text = fila.Cell(1).GetValue<string>(); // Nombre de Usuario
                txtContraseñaAntigua.Text = fila.Cell(2).GetValue<string>(); // Contraseña
                return true;
            }
            return false;
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

                // Actualizar en Usuarios
                if (!ActualizarContraseña(rutaUsuarios, idBuscado, nuevaContraseña, 7))
                {
                    // Actualizar en Entrenadores
                    if (!ActualizarContraseña(rutaEntrenadores, idBuscado, nuevaContraseña, 5))
                    {
                        // Actualizar en Administradores
                        if (!ActualizarContraseña(rutaAdministradores, idBuscado, nuevaContraseña, 5))
                        {
                            MessageBox.Show("ID no encontrado en ninguno de los archivos.", "Error");
                        }
                        else
                        {
                            MessageBox.Show("Contraseña actualizada exitosamente en Administradores.", "Éxito");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña actualizada exitosamente en Entrenadores.", "Éxito");
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña actualizada exitosamente en Usuarios.", "Éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar contraseña: {ex.Message}", "Error");
            }
        }

        private bool ActualizarContraseña(string rutaArchivo, string idBuscado, string nuevaContraseña, int columnaID)
        {
            var workbook = new XLWorkbook(rutaArchivo);
            var worksheet = workbook.Worksheet("Sheet1");

            // Buscar la fila con el ID en la columna correspondiente
            var fila = worksheet.RowsUsed()
                                .FirstOrDefault(row => row.Cell(columnaID).GetValue<string>().Equals(idBuscado, StringComparison.OrdinalIgnoreCase));

            if (fila != null)
            {
                // Actualizar la contraseña en la columna 2
                fila.Cell(2).Value = nuevaContraseña;

                // Guardar los cambios en el archivo Excel
                workbook.SaveAs(rutaArchivo);
                return true;
            }
            return false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de inicio de sesión
            formInicioSesion formularioInicioSesion = new formInicioSesion();
            formularioInicioSesion.Show();

            // Cerrar el formulario actual
            this.Close();
        }
    }
}

