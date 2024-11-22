using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //nuevo: Método para actualizar el punto fuerte en el archivo Entrenadores
        private bool ActualizarPuntoFuerte(string rutaArchivo, string idBuscado, string nuevoPuntoFuerte)
        {
            try
            {
                var lines = File.ReadAllLines(rutaArchivo).ToList(); // Leer todas las líneas
                bool actualizado = false;

                for (int i = 1; i < lines.Count; i++) // Empezar desde la fila 1 para evitar el encabezado
                {
                    var valores = lines[i].Split(';');

                    if (valores[4].Trim() == idBuscado) // Columna 5 (ID)
                    {
                        valores[5] = nuevoPuntoFuerte; // Actualizar la columna 6 (Puntos fuertes)
                        lines[i] = string.Join(";", valores); // Reconstruir la línea
                        actualizado = true;
                        break;
                    }
                }

                if (actualizado)
                {
                    File.WriteAllLines(rutaArchivo, lines); // Sobrescribir el archivo
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
        private bool BuscarYMostrarDatosEntrenadores(string rutaArchivo, string idBuscado)
        {
            try
            {
                var lines = File.ReadAllLines(rutaArchivo).Skip(1); // Leer todas las líneas, omitiendo el encabezado

                foreach (var line in lines)
                {
                    var valores = line.Split(';');

                    // Verificar si el ID coincide
                    if (valores[4].Trim() == idBuscado) // Columna 5 es el ID
                    {
                        txtNombreUsuario.Text = valores[0]; // Nombre de Usuario
                        txtPuntoFuerte.Text = valores[5];   // Punto Fuerte (Columna 6)
                        return true;
                    }
                }

                MessageBox.Show("ID no encontrado en el archivo Entrenadores.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar datos de entrenadores: {ex.Message}", "Error");
            }

            return false;
        }

        private void btnCambiarPuntoFuerte_Click(object sender, EventArgs e)
        {
            try
            {
                string idBuscado = txtIDUsuario.Text;
                string nuevoPuntoFuerte = comboBoxPuntoFuerte.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(nuevoPuntoFuerte))
                {
                    MessageBox.Show("Debe seleccionar un nuevo punto fuerte.", "Advertencia");
                    return;
                }

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
                string idBuscado = txtIDUsuario.Text;

                if (string.IsNullOrWhiteSpace(idBuscado))
                {
                    MessageBox.Show("Debe ingresar un ID para buscar.", "Advertencia");
                    return;
                }

                BuscarYMostrarDatosEntrenadores(rutaEntrenadores, idBuscado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el entrenador: {ex.Message}", "Error");
            }
        }

  


        private void txtPuntoFuerte_TextChanged(object sender, EventArgs e)
        {

        }


     
    }
    }

