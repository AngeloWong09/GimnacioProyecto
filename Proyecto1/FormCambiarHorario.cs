using ClosedXML.Excel;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Proyecto1
{
    public partial class FormCambiarHorario : Form
    {
        private string rutaClases = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "Clases.csv");
        private string rutaEntrenadores = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "Entrenadores.csv");

        public FormCambiarHorario()
        {
            InitializeComponent();
            InicializarComboBox();
        }

        private void InicializarComboBox()
        {
            // Opciones para Nuevo día
            comboBoxNuevoDia.Items.AddRange(new string[]
            {
                "1/11/2024", "2/11/2024", "3/11/2024", "4/11/2024", "5/11/2024",
                "6/11/2024", "7/11/2024", "8/11/2024", "9/11/2024", "10/11/2024",
                "11/11/2024", "12/11/2024", "13/11/2024", "14/11/2024", "15/11/2024",
                "16/11/2024", "17/11/2024", "18/11/2024"
            });

            // Opciones para Nueva hora
            comboBoxNuevaHora.Items.AddRange(new string[]
            {
                "8:00:00 a.m", "10:00:00 a.m", "02:00:00 p.m", "04:00:00 p.m", "06:00:00 p.m"
            });
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string idClase = txtIDClase.Text; // Leer la ID ingresada

                if (!BuscarDatosClase(rutaClases, idClase))
                {
                    MessageBox.Show("No se encontró la clase con el ID especificado.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar la clase: {ex.Message}", "Error");
            }
        }

        private bool BuscarDatosClase(string rutaArchivo, string idClase)
        {
            try
            {
                var lines = File.ReadAllLines(rutaArchivo);

                foreach (var line in lines.Skip(1)) // Ignorar la primera línea (encabezado)
                {
                    var valores = line.Split(';');
                    string id = valores[1].Trim();  // La columna ID está en la posición 1 (Ajustado para CSV)

                    if (id == idClase)
                    {
                        txtNumeroClase.Text = valores[3];       // Nombre de la clase (Columna 3)
                        txtDiaActual.Text = valores[4];         // Fecha actual (Columna 4)
                        txtHoraActual.Text = valores[5];        // Hora actual (Columna 5)

                        // Buscar el entrenador en Entrenadores.csv
                        string idEntrenador = valores[2];     // ID Entrenador (Columna 2)
                        MostrarEntrenador(rutaEntrenadores, idEntrenador);

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar la clase: {ex.Message}", "Error");
            }
            return false;
        }

        private void MostrarEntrenador(string rutaArchivo, string idEntrenador)
        {
            try
            {
                var lines = File.ReadAllLines(rutaArchivo);

                foreach (var line in lines.Skip(1)) // Ignorar la primera línea (encabezado)
                {
                    var valores = line.Split(';');
                    string id = valores[4].Trim();  // La columna ID está en la posición 4 (Ajustado para CSV)

                    if (id == idEntrenador)
                    {
                        txtEntrenadorDesignado.Text = valores[0]; // Nombre del entrenador (Columna 0)
                        return;
                    }
                }

                txtEntrenadorDesignado.Text = "No encontrado";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar datos del entrenador: {ex.Message}", "Error");
            }
        }
        


        private bool ActualizarHorarioClase(string rutaArchivo, string idClase, string nuevoDia, string nuevaHora)
        {
            try
            {
                var lines = File.ReadAllLines(rutaArchivo).ToList();
                bool actualizado = false;

                for (int i = 1; i < lines.Count; i++) // Ignorar la primera línea (encabezado)
                {
                    var valores = lines[i].Split(';');
                    string id = valores[1].Trim();  // La columna ID está en la posición 1 (Ajustado para CSV)

                    if (id == idClase)
                    {
                        valores[4] = nuevoDia;  // Actualizar día (Columna 4)
                        valores[5] = nuevaHora; // Actualizar hora (Columna 5)
                        lines[i] = string.Join(";", valores); // Reemplazar la línea con los nuevos valores
                        actualizado = true;
                        break;
                    }
                }

                if (actualizado)
                {
                    File.WriteAllLines(rutaArchivo, lines);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el horario: {ex.Message}", "Error");
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string idClase = txtIDClase.Text;
                string nuevoDia = comboBoxNuevoDia.SelectedItem?.ToString();
                string nuevaHora = comboBoxNuevaHora.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(nuevoDia) || string.IsNullOrWhiteSpace(nuevaHora))
                {
                    MessageBox.Show("Debe seleccionar un nuevo día y una nueva hora.", "Advertencia");
                    return;
                }

                if (ActualizarHorarioClase(rutaClases, idClase, nuevoDia, nuevaHora))
                {
                    MessageBox.Show("Horario actualizado exitosamente.", "Éxito");
                }
                else
                {
                    MessageBox.Show("No se encontró la clase con el ID especificado.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar el horario: {ex.Message}", "Error");
            }
        }


        private void comboBoxNuevaHora_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            
        
    
    





