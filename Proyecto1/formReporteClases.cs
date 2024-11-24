using System;

using System.Data;

using System.Linq;

using System.Windows.Forms;

using System.IO;


namespace Proyecto1
{
    public partial class formReporteClases : Form
    {
        private readonly string rutaEntrenadores = Path.Combine(Application.StartupPath, "Assets", "Entrenadores.csv");
        private readonly string rutaClases = Path.Combine(Application.StartupPath, "Assets", "Clases.csv");
        private readonly string rutaBasedatosClase = Path.Combine(Application.StartupPath, "Assets", "BasedatosClase.csv");



        public formReporteClases()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario formEntrenador
            formEntrenador entrenadorForm = new formEntrenador();

            // Mostrar el formulario formEntrenador
            entrenadorForm.Show();

            // Cerrar el formulario actual
            this.Close();
        }

        private void btnFiltrarClase_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del entrenador desde el campo txtIdEntrenador
                string idEntrenador = txtIdEntrenador.Text.Trim();

                if (string.IsNullOrEmpty(idEntrenador))
                {
                    MessageBox.Show("Por favor, busque y seleccione un entrenador antes de filtrar las clases.", "Advertencia");
                    return;
                }

                // Limpiar el ListBox para los resultados actuales
                listbReporteClase.Items.Clear();

                // Leer las líneas de Clase.csv
                var clases = File.ReadAllLines(rutaClases);

                // Filtrar las clases que coinciden con la ID del entrenador
                var clasesFiltradas = clases
                    .Where(line => line.Split(';').Length >= 3 && line.Split(';')[2].Trim() == idEntrenador)
                    .Select(line => new
                    {
                        ClaseId = line.Split(';')[1].Trim(),  // ID de la clase (columna 2)
                        NombreClase = line.Split(';')[3].Trim() // Nombre de la clase (columna 4)
                    })
                    .ToList();

                if (clasesFiltradas.Count > 0)
                {
                    // Leer el archivo BasedatosClase.csv para contar los usuarios inscritos en cada clase
                    if (!File.Exists(rutaBasedatosClase))
                    {
                        MessageBox.Show("El archivo BasedatosClase.csv no se encontró en la carpeta Assets.", "Error");
                        return;
                    }

                    var reservas = File.ReadAllLines(rutaBasedatosClase);

                    foreach (var clase in clasesFiltradas)
                    {
                        // Contar los usuarios inscritos en la clase actual
                        int usuariosInscritos = reservas
                            .Count(line => line.Split(';').Length >= 5 && line.Split(';')[4].Trim() == clase.ClaseId);

                        // Mostrar el nombre de la clase y la cantidad de usuarios inscritos
                        listbReporteClase.Items.Add($"Clase: {clase.NombreClase}, Inscritos: {usuariosInscritos}");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron clases para este entrenador.", "Sin resultados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar las clases: {ex.Message}", "Error");
            }

        }


        private void btnFiltrarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del entrenador desde el campo txtIdEntrenador
                string idEntrenador = txtIdEntrenador.Text.Trim();

                if (string.IsNullOrEmpty(idEntrenador))
                {
                    MessageBox.Show("Por favor, busque y seleccione un entrenador antes de filtrar los horarios.", "Advertencia");
                    return;
                }

                // Limpiar el ListBox para los resultados actuales
                listbReporteClase.Items.Clear();

                // Leer las líneas del archivo Clase.csv
                var clases = File.ReadAllLines(rutaClases);

                // Filtrar las clases que coinciden con la ID del entrenador
                var horariosFiltrados = clases
                    .Where(line => line.Split(';').Length >= 6 && line.Split(';')[2].Trim() == idEntrenador)
                    .Select(line => new
                    {
                        Clase = line.Split(';')[3].Trim(),
                        Horario = line.Split(';')[5].Trim()
                    })
                    .ToList();

                if (horariosFiltrados.Count > 0)
                {
                    // Agregar los horarios al ListBox
                    foreach (var horario in horariosFiltrados)
                    {
                        listbReporteClase.Items.Add($"Clase: {horario.Clase}, Horario: {horario.Horario}");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron horarios para este entrenador.", "Sin resultados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar los horarios: {ex.Message}", "Error");
            }
        }


        private void btnBuscarEntrenador_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el nombre del entrenador desde un campo de texto (ejemplo: txtNombreEntrenador)
                string nombreEntrenador = txtIdEntrenador.Text.Trim();

                if (string.IsNullOrEmpty(nombreEntrenador))
                {
                    MessageBox.Show("Por favor, ingrese el nombre del entrenador.", "Advertencia");
                    return;
                }

                // Leer las líneas del archivo Entrenadores.csv
                var entrenadores = File.ReadAllLines(rutaEntrenadores);

                // Buscar la ID del entrenador que coincida con el nombre
                var entrenador = entrenadores
                    .Skip(1) // Omitir la primera línea si contiene encabezados
                    .Select(line => line.Split(';'))
                    .FirstOrDefault(columns => columns.Length >= 5 && columns[2].Trim().Equals(nombreEntrenador, StringComparison.OrdinalIgnoreCase));

                if (entrenador != null)
                {
                    // Mostrar la ID del entrenador en txtIdEntrenador
                    txtIdEntrenador.Text = entrenador[4].Trim();
                }
                else
                {
                    MessageBox.Show("No se encontró un entrenador con ese nombre.", "Sin resultados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el entrenador: {ex.Message}", "Error");
            }
        }

        private void txtNombreEntrenador_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGaradarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si hay datos en el ListBox
                if (listbReporteClase.Items.Count == 0)
                {
                    MessageBox.Show("No hay datos para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Definir la ruta para guardar el archivo dentro de la subcarpeta "reportes"
                string rutaDirectorio = Path.Combine(Application.StartupPath, "reportes");
                string rutaArchivo = Path.Combine(rutaDirectorio, "ReporteClases.txt");

                // Crear el directorio si no existe
                if (!Directory.Exists(rutaDirectorio))
                {
                    Directory.CreateDirectory(rutaDirectorio);
                }

                // Escribir los datos del ListBox en el archivo TXT
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    foreach (var item in listbReporteClase.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }

                MessageBox.Show("Reporte guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del entrenador desde el campo txtIdEntrenador
                string idEntrenador = txtIdEntrenador.Text.Trim();

                if (string.IsNullOrEmpty(idEntrenador))
                {
                    MessageBox.Show("Por favor, ingrese el ID del entrenador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Limpiar el ListBox para mostrar los nuevos resultados
                listbReporteClase.Items.Clear();

                // Verificar si los archivos existen
                if (!File.Exists(rutaClases))
                {
                    MessageBox.Show("El archivo Clases.csv no se encontró en la carpeta Assets.", "Error");
                    return;
                }

                if (!File.Exists(rutaBasedatosClase))
                {
                    MessageBox.Show("El archivo BasedatosClase.csv no se encontró en la carpeta Assets.", "Error");
                    return;
                }

                // Leer las líneas de Clases.csv
                var clases = File.ReadAllLines(rutaClases);

                // Leer las líneas de BasedatosClase.csv
                var reservas = File.ReadAllLines(rutaBasedatosClase);

                // Filtrar las clases asociadas con el ID del entrenador
                var clasesFiltradas = clases
                    .Where(line => line.Split(';').Length >= 6 && line.Split(';')[2].Trim() == idEntrenador)
                    .Select(line => new
                    {
                        ClaseId = line.Split(';')[1].Trim(),  // ID de la clase (columna 2)
                        NombreClase = line.Split(';')[3].Trim(), // Nombre de la clase (columna 4)
                        Horario = line.Split(';')[5].Trim() // Horario de la clase (columna 6)
                    })
                    .ToList();

                if (clasesFiltradas.Count > 0)
                {
                    // Iterar sobre las clases filtradas y obtener el número de inscritos
                    foreach (var clase in clasesFiltradas)
                    {
                        int inscritos = reservas
                            .Count(line => line.Split(';').Length >= 5 && line.Split(';')[4].Trim() == clase.ClaseId);

                        // Agregar al ListBox los detalles de la clase
                        listbReporteClase.Items.Add($"Clase: {clase.NombreClase}, Horario: {clase.Horario}, Inscritos: {inscritos}");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron clases para el entrenador proporcionado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al mostrar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

