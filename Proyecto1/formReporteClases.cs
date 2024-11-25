using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;


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

        /// <summary>
        /// Navega al formulario formEntrenador.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            formEntrenador entrenadorForm = new formEntrenador();
            entrenadorForm.Show();
            this.Close();
        }

        /// <summary>
        /// Filtra las clases asociadas a un entrenador y muestra la cantidad de inscritos.
        /// </summary>
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

        /// <summary>
        /// Filtra los horarios de las clases de un entrenador.
        /// </summary>
        private void btnFiltrarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                string idEntrenador = txtIdEntrenador.Text.Trim();

                if (string.IsNullOrEmpty(idEntrenador))
                {
                    MostrarMensaje("Por favor, busque y seleccione un entrenador antes de filtrar los horarios.", "Advertencia");
                    return;
                }

                listbReporteClase.Items.Clear();

                var horariosFiltrados = FiltrarClasesPorEntrenador(idEntrenador)
                    .Select(c => new { c.NombreClase, c.Horario });

                if (!horariosFiltrados.Any())
                {
                    MostrarMensaje("No se encontraron horarios para este entrenador.", "Sin resultados");
                    return;
                }

                foreach (var horario in horariosFiltrados)
                {
                    listbReporteClase.Items.Add($"Clase: {horario.NombreClase}, Horario: {horario.Horario}");
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al filtrar los horarios: {ex.Message}", "Error");
            }
        }


        /// <summary>
        /// Busca el ID de un entrenador por su nombre.
        /// </summary>
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

        /// <summary>
        /// Guarda los datos del ListBox en un archivo de texto.
        /// </summary>
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

        /// <summary>
        /// Muestra todas las clases asociadas a un entrenador.
        /// </summary>
        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                string idEntrenador = txtIdEntrenador.Text.Trim();

                if (string.IsNullOrEmpty(idEntrenador))
                {
                    MostrarMensaje("Por favor, ingrese el ID del entrenador.", "Advertencia");
                    return;
                }

                listbReporteClase.Items.Clear();

                var clasesFiltradas = FiltrarClasesPorEntrenador(idEntrenador);
                var reservas = File.Exists(rutaBasedatosClase) ? File.ReadAllLines(rutaBasedatosClase) : Array.Empty<string>();

                foreach (var clase in clasesFiltradas)
                {
                    int inscritos = reservas.Count(line => line.Split(';').Length >= 5 && line.Split(';')[4].Trim() == clase.ClaseId);
                    listbReporteClase.Items.Add($"Clase: {clase.NombreClase}, Horario: {clase.Horario}, Inscritos: {inscritos}");
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Ocurrió un error al mostrar los datos: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Filtra las clases por el ID del entrenador.
        /// </summary>
        private IEnumerable<(string ClaseId, string NombreClase, string Horario)> FiltrarClasesPorEntrenador(string idEntrenador)
        {
            if (!File.Exists(rutaClases))
                return Enumerable.Empty<(string, string, string)>();

            return File.ReadAllLines(rutaClases)
                .Where(line => line.Split(';').Length >= 6 && line.Split(';')[2].Trim() == idEntrenador)
                .Select(line => (
                    ClaseId: line.Split(';')[1].Trim(),
                    NombreClase: line.Split(';')[3].Trim(),
                    Horario: line.Split(';')[5].Trim()));
        }

        /// <summary>
        /// Busca un entrenador por su nombre y devuelve su ID.
        /// </summary>
        private string BuscarEntrenadorPorNombre(string nombreEntrenador)
        {
            if (!File.Exists(rutaEntrenadores))
                return null;

            return File.ReadAllLines(rutaEntrenadores)
                .Skip(1)
                .Select(line => line.Split(';'))
                .FirstOrDefault(columns => columns.Length >= 5 && columns[2].Trim().Equals(nombreEntrenador, StringComparison.OrdinalIgnoreCase))?[4].Trim();
        }

        /// <summary>
        /// Muestra un mensaje al usuario.
        /// </summary>
        private void MostrarMensaje(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
    



