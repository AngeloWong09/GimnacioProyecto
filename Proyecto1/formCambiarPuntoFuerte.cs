using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class formCambiarPuntoFuerte : Form
    {
        private string rutaEntrenadores = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "Entrenadores.csv"); // Ruta dinámica del archivo Entrenadores.csv
        
        public formCambiarPuntoFuerte()
        {
            InitializeComponent();
            comboBoxPuntoFuerte.Items.AddRange(new string[] { "Zumba", "CardioDance", "Funcionales" });
        }

        /// <summary>
        /// Actualiza el punto fuerte del entrenador en el archivo Entrenadore.csv.
        /// </summary>
        private bool ActualizarPuntoFuerte(string rutaArchivo, string idBuscado, string nuevoPuntoFuerte)
        {
            try
            {
                var lines = File.ReadAllLines(rutaArchivo).ToList(); // Leer todas las líneas
                bool actualizado = false;

                // Iterar sobre las líneas del archivo, comenzando desde la fila 1 (saltando el encabezado)
                for (int i = 1; i < lines.Count; i++)
                {
                    var valores = lines[i].Split(';');

                    if (valores[4].Trim() == idBuscado) // Verificar si el ID coincide con el buscado
                    {
                        valores[5] = nuevoPuntoFuerte; // Actualizar el punto fuerte (columna 6)
                        lines[i] = string.Join(";", valores); // Reconstruir la línea con el nuevo punto fuerte
                        actualizado = true;
                        break;
                    }
                }

                if (actualizado)
                {
                    File.WriteAllLines(rutaArchivo, lines); // Sobrescribir el archivo con los cambios
                    return true;
                }
                else
                {
                    MessageBox.Show("ID no encontrado en el archivo Entrenadores.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el punto fuerte: {ex.Message}", "Error");
            }

            return false;

        }

        /// <summary>
        /// Busca y muestra los datos del entrenador en los cuadros de texto.
        /// </summary>
        private bool BuscarYMostrarDatosEntrenadores(string rutaArchivo, string idBuscado)
        {
            try
            {
                var lines = File.ReadAllLines(rutaArchivo).Skip(1); // Omitir el encabezado

                foreach (var line in lines)
                {
                    var valores = line.Split(';');

                    if (valores[4].Trim() == idBuscado) // Comprobar si el ID coincide
                    {
                        txtNombreUsuario.Text = valores[0]; // Asignar el nombre del entrenador
                        txtPuntoFuerte.Text = valores[5];   // Asignar el punto fuerte
                        return true;
                    }
                }

                MessageBox.Show("ID no encontrado en el archivo Entrenadores.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar datos del entrenador: {ex.Message}", "Error");
            }

            return false;
        }

        /// <summary>
        /// Evento para cambiar el punto fuerte del entrenador al hacer clic en el botón.
        /// </summary>
        private void btnCambiarPuntoFuerte_Click(object sender, EventArgs e)
        {
            try
            {
                string idBuscado = txtIDUsuario.Text;
                string nuevoPuntoFuerte = comboBoxPuntoFuerte.SelectedItem?.ToString();

                // Validación para asegurarse de que se ha seleccionado un nuevo punto fuerte
                if (string.IsNullOrWhiteSpace(nuevoPuntoFuerte))
                {
                    MessageBox.Show("Debe seleccionar un nuevo punto fuerte.", "Advertencia");
                    return;
                }

                // Intentar actualizar el punto fuerte en el archivo CSV
                if (ActualizarPuntoFuerte(rutaEntrenadores, idBuscado, nuevoPuntoFuerte))
                {
                    MessageBox.Show("Punto fuerte actualizado exitosamente.", "Éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar el punto fuerte: {ex.Message}", "Error");
            }
        }


        /// <summary>
        /// Evento para salir del formulario y regresar al menú principal.
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            formAdministrador formularioAdministrador = new formAdministrador();
            formularioAdministrador.Show();

            // Cerrar el formulario actual
            this.Close();
        }


        /// <summary>
        /// Evento para buscar los datos de un entrenador cuando se ingresa su ID.
        /// </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string idBuscado = txtIDUsuario.Text;

                if (string.IsNullOrWhiteSpace(idBuscado))
                {
                    MessageBox.Show("Debe ingresar un ID para buscar.", "Advertencia");
                    return;
                }

                // Buscar y mostrar los datos del entrenador con el ID ingresado
                BuscarYMostrarDatosEntrenadores(rutaEntrenadores, idBuscado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el entrenador: {ex.Message}", "Error");
            }


        }
    }
}

