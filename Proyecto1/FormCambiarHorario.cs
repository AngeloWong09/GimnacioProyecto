using ClosedXML.Excel;
using System;
using System.Linq;
using System.Windows.Forms;


namespace Proyecto1
{
    public partial class FormCambiarHorario : Form
    {
        private string rutaClases = "Clases.xlsx";          // Ruta del archivo Clases
        private string rutaEntrenadores = "Entrenadores.xlsx"; // Ruta del archivo Entrenadores

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
            using (var workbook = new XLWorkbook(rutaArchivo))
            {
                var worksheet = workbook.Worksheet("Hoja1");

                // Buscar la fila con la ID de la clase en la columna 2
                var fila = worksheet.RowsUsed()
                                    .FirstOrDefault(row => row.Cell(2).GetValue<string>().Equals(idClase, StringComparison.OrdinalIgnoreCase));

                if (fila != null)
                {
                    txtNumeroClase.Text = fila.Cell(4).GetValue<string>();       // Nombre de la clase (Columna 4)
                    txtDiaActual.Text = fila.Cell(5).GetValue<string>();       // Fecha actual (Columna 5)
                    txtHoraActual.Text = fila.Cell(6).GetValue<string>();      // Hora actual (Columna 6)

                    // Buscar el entrenador en Entrenadores.xlsx
                    string idEntrenador = fila.Cell(3).GetValue<string>();     // ID Entrenador (Columna 3)
                    MostrarEntrenador(rutaEntrenadores, idEntrenador);

                    return true;
                }
            }
            return false;
        }

        private void MostrarEntrenador(string rutaArchivo, string idEntrenador)
        {
            using (var workbook = new XLWorkbook(rutaArchivo))
            {
                var worksheet = workbook.Worksheet("Hoja1");

                // Buscar la fila del entrenador en la columna 5
                var fila = worksheet.RowsUsed()
                                    .FirstOrDefault(row => row.Cell(5).GetValue<string>().Equals(idEntrenador, StringComparison.OrdinalIgnoreCase));

                if (fila != null)
                {
                    txtEntrenadorDesignado.Text = fila.Cell(1).GetValue<string>(); // Nombre del entrenador (Columna 1)
                }
                else
                {
                    txtEntrenadorDesignado.Text = "No encontrado";
                }
            }
        }


        private bool ActualizarHorarioClase(string rutaArchivo, string idClase, string nuevoDia, string nuevaHora)
        {
            using (var workbook = new XLWorkbook(rutaArchivo))
            {
                var worksheet = workbook.Worksheet("Hoja1");

                // Buscar la fila con la ID de la clase en la columna 2
                var fila = worksheet.RowsUsed()
                                    .FirstOrDefault(row => row.Cell(2).GetValue<string>().Equals(idClase, StringComparison.OrdinalIgnoreCase));

                if (fila != null)
                {
                    fila.Cell(5).Value = nuevoDia;  // Actualizar día (Columna 5)
                    fila.Cell(6).Value = nuevaHora; // Actualizar hora (Columna 6)

                    // Guardar los cambios en el archivo Excel
                    workbook.SaveAs(rutaArchivo);
                    return true;
                }
            }
            return false;
        }

        private void comboBoxNuevaHora_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnVolveraMenu_Click(object sender, EventArgs e)
        {
            formAdministrador formularioAdministrador = new formAdministrador();
            formularioAdministrador.Show();

            // Cerrar el formulario actual
            this.Close();
        }
    }
}
            
        
    
    





