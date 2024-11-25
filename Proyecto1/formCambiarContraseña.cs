 using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class formCambiarContraseña : Form
    {

        private string rutaUsuarios = "Assets/Usuarios.csv";        // Ruta del archivo Usuarios
        private string rutaEntrenadores = "Assets/Entrenadores.csv"; // Ruta del archivo Entrenadores
        private string rutaAdministradores = "Assets/Administrador.csv"; // Ruta del archivo Administradores

        public formCambiarContraseña()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de búsqueda, buscando un usuario, entrenador o administrador por su ID.
        /// </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string idBuscado = txtIDUsuario.Text;

                // Buscar en el archivo de usuarios
                if (!BuscarYMostrarDatos(rutaUsuarios, idBuscado, 6))
                {
                    // Buscar en el archivo de entrenadores
                    if (!BuscarYMostrarDatos(rutaEntrenadores, idBuscado, 4))
                    {
                        // Buscar en el archivo de administradores
                        if (!BuscarYMostrarDatos(rutaAdministradores, idBuscado, 4))
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

        /// <summary>
        /// Realiza la búsqueda de un ID en el archivo especificado y muestra los datos del usuario si se encuentra.
        /// </summary>
        /// <returns>True si se encontró el ID y se mostraron los datos, False en caso contrario.</returns>
        private bool BuscarYMostrarDatos(string rutaArchivo, string idBuscado, int columnaID)
        {
            try
            {
                var lines = File.ReadAllLines(rutaArchivo);

                foreach (var line in lines.Skip(1)) // Ignorar la primera línea (encabezado)
                {
                    var valores = line.Split(';');
                    string id = valores[columnaID].Trim();

                    if (id == idBuscado)
                    {
                        txtNombreUsuario.Text = valores[0]; // Nombre de Usuario
                        txtContraseñaAntigua.Text = valores[1]; // Contraseña
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar datos en {Path.GetFileName(rutaArchivo)}: {ex.Message}", "Error");
            }
            return false;
        }

        private bool BuscarYMostrarDatosEntrenadores(string rutaArchivo, string idBuscado)
        {
            try
            {
                var lines = File.ReadAllLines(rutaArchivo);

                foreach (var line in lines.Skip(1)) // Ignorar la primera línea (encabezado)
                {
                    var valores = line.Split(';');
                    string id = valores[4].Trim();  // La columna ID está en la posición 4

                    if (id == idBuscado)
                    {
                        txtNombreUsuario.Text = valores[0]; // Nombre de Usuario
                        txtContraseñaAntigua.Text = valores[1]; // Contraseña
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar datos de Entrenadores: {ex.Message}", "Error");
            }
            return false;
        }

        private bool BuscarYMostrarDatosAdministradores(string rutaArchivo, string idBuscado)
        {
            try
            {
                var lines = File.ReadAllLines(rutaArchivo);

                foreach (var line in lines.Skip(1)) // Ignorar la primera línea (encabezado)
                {
                    var valores = line.Split(';');
                    string id = valores[4].Trim();  // La columna ID está en la posición 4

                    if (id == idBuscado)
                    {
                        txtNombreUsuario.Text = valores[0]; // Nombre de Usuario
                        txtContraseñaAntigua.Text = valores[1]; // Contraseña
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar datos de Administradores: {ex.Message}", "Error");
            }
            return false;
        }


        /// <summary>
        /// Actualiza la contraseña de un usuario en el archivo especificado.
        /// </summary>
        private bool ActualizarContraseña(string rutaArchivo, string idBuscado, string nuevaContraseña, int columnaID)
        {
            try
            {
                var lines = File.ReadAllLines(rutaArchivo).ToList();
                bool actualizado = false;

                for (int i = 1; i < lines.Count; i++) // Ignorar la primera línea (encabezado)
                {
                    var valores = lines[i].Split(';');
                    if (valores.Length > columnaID) // Validar que exista la columna ID
                    {
                        string id = valores[columnaID].Trim();

                        if (id == idBuscado)
                        {
                            valores[1] = nuevaContraseña; // Actualizar la contraseña en la columna 1
                            lines[i] = string.Join(";", valores); // Reconstruir la línea actualizada
                            actualizado = true;
                            break;
                        }
                    }
                }

                if (actualizado)
                {
                    // Sobrescribir el archivo con los cambios
                    File.WriteAllLines(rutaArchivo, lines);
                    return true;
                }
                else
                {
                    MessageBox.Show($"No se encontró el ID {idBuscado} en {Path.GetFileName(rutaArchivo)}.", "Advertencia");
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la contraseña en {Path.GetFileName(rutaArchivo)}: {ex.Message}", "Error");
                return false;
            }
        }

        /// <summary>
        /// Verifica si el id es válido y actualizando la contraseña en los archivos.
        /// </summary>
        private void btnNuevaContraseña_Click_1(object sender, EventArgs e)
        {
            try
            {
                string idBuscado = txtIDUsuario.Text.Trim();
                string nuevaContraseña = txtNuevaContraseña.Text.Trim();

                if (string.IsNullOrWhiteSpace(nuevaContraseña))
                {
                    MessageBox.Show("La nueva contraseña no puede estar vacía.", "Advertencia");
                    return;
                }

                // Intentar actualizar en cada archivo
                if (ActualizarContraseña(rutaUsuarios, idBuscado, nuevaContraseña, 6))
                {
                    MessageBox.Show("Contraseña actualizada exitosamente en Usuarios.", "Éxito");
                }
                else if (ActualizarContraseña(rutaEntrenadores, idBuscado, nuevaContraseña, 4))
                {
                    MessageBox.Show("Contraseña actualizada exitosamente en Entrenadores.", "Éxito");
                }
                else if (ActualizarContraseña(rutaAdministradores, idBuscado, nuevaContraseña, 4))
                {
                    MessageBox.Show("Contraseña actualizada exitosamente en Administradores.", "Éxito");
                }
                else
                {
                    MessageBox.Show("No se encontró el ID en ningún archivo.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar contraseña: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Botón para volver al menú principal del administrador.
        /// </summary>
        private void btnVolveraMenu_Click(object sender, EventArgs e)
        {
            formAdministrador formularioAdministrador = new formAdministrador();
            formularioAdministrador.Show();

            this.Close();
        }
    }
}



