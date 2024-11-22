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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string idBuscado = txtIDUsuario.Text;

                // Buscar en Usuarios.csv
                if (!BuscarYMostrarDatosUsuarios(rutaUsuarios, idBuscado))
                {
                    // Buscar en Entrenadores.csv
                    if (!BuscarYMostrarDatosEntrenadores(rutaEntrenadores, idBuscado))
                    {
                        // Buscar en Administradores.csv
                        if (!BuscarYMostrarDatosAdministradores(rutaAdministradores, idBuscado))
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

        private bool BuscarYMostrarDatosUsuarios(string rutaArchivo, string idBuscado)
        {
            try
            {
                var lines = File.ReadAllLines(rutaArchivo);

                foreach (var line in lines.Skip(1)) // Ignorar la primera línea (encabezado)
                {
                    var valores = line.Split(';');
                    string id = valores[6].Trim();  // La columna ID está en la posición 6

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
                MessageBox.Show($"Error al buscar datos de Usuarios: {ex.Message}", "Error");
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

        private bool ActualizarContraseña(string rutaArchivo, string idBuscado, string nuevaContraseña, int columnaID)
        {
            try
            {
                // Leer todas las líneas del archivo
                var lines = File.ReadAllLines(rutaArchivo).ToList();
                bool actualizado = false;

                for (int i = 1; i < lines.Count; i++) // Ignorar la primera línea (encabezado)
                {
                    var valores = lines[i].Split(';'); // Dividir la línea en columnas
                    if (valores.Length > columnaID) // Validar que exista la columna ID
                    {
                        string id = valores[columnaID].Trim(); // Obtener el ID actual

                        if (id == idBuscado)
                        {
                            // Actualizar la columna de contraseña
                            valores[1] = nuevaContraseña; // La contraseña siempre está en la columna 1
                            lines[i] = string.Join(";", valores); // Reconstruir la línea actualizada
                            actualizado = true;
                            break; // Salir del bucle después de actualizar
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
                if (ActualizarContraseña(rutaUsuarios, idBuscado, nuevaContraseña, 6)) // ID en columna 6 para Usuarios
                {
                    MessageBox.Show("Contraseña actualizada exitosamente en Usuarios.", "Éxito");
                }
                else if (ActualizarContraseña(rutaEntrenadores, idBuscado, nuevaContraseña, 4)) // ID en columna 4 para Entrenadores
                {
                    MessageBox.Show("Contraseña actualizada exitosamente en Entrenadores.", "Éxito");
                }
                else if (ActualizarContraseña(rutaAdministradores, idBuscado, nuevaContraseña, 4)) // ID en columna 4 para Administradores
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

        private void btnVolveraMenu_Click(object sender, EventArgs e)
        {
            formAdministrador formularioAdministrador = new formAdministrador();
            formularioAdministrador.Show();

            // Cerrar el formulario actual
            this.Close();
        }
    }
}



