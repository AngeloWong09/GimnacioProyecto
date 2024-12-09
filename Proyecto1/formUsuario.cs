using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class formUsuario : Form
    {
        private readonly string rutaEntrenadores = Path.Combine(Application.StartupPath, "Assets", "Entrenadores.csv");
        private readonly string rutaUsuarios = Path.Combine(Application.StartupPath, "Assets", "Usuarios.csv");
        private readonly string rutaClases = Path.Combine(Application.StartupPath, "Assets", "Clases.csv");
        private readonly string rutaBasedatosClase = Path.Combine(Application.StartupPath, "Assets", "BasedatosClase.csv");
        private string usuarioId; // Aquí se guarda el ID del usuario




        /// <summary>
        /// Constructor que inicializa el formulario y configura el ID del usuario.
        /// </summary>
        /// <param name="usuarioId">ID del usuario autenticado.</param>
        public formUsuario(string usuarioId)
        {
            InitializeComponent();

            // Inicializar opciones de ComboBox
            comboBoxClases.Items.AddRange(new string[] { "Zumba", "Funcionales", "CardioDance" });
            this.usuarioId = usuarioId;  // Asignar el ID del usuario
            txtUsuarioId.Text = usuarioId.ToString();  // Convertir el ID a string para mostrarlo en el TextBox
        }

        /// <summary>
        /// Maneja la acción de buscar clases basadas en la selección del usuario.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string claseSeleccionada = comboBoxClases.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(claseSeleccionada))
                {
                    MessageBox.Show("Seleccione una clase antes de buscar.", "Advertencia");
                    return;
                }

                if (!File.Exists(rutaClases))
                {
                    MessageBox.Show($"El archivo {rutaClases} no existe. Verifique la ruta.", "Error");
                    return;
                }

                listBoxReservas.Items.Clear();
                var lineas = File.ReadAllLines(rutaClases);

                if (lineas.Length <= 1)
                {
                    MessageBox.Show("El archivo Clases.csv está vacío o solo contiene el encabezado.", "Información");
                    return;
                }

                // Filtrar clases por la selección del usuario
                var clasesFiltradas = lineas
                    .Skip(1)
                    .Select(line => line.Split(';'))
                    .Where(columns => columns.Length >= 6 &&
                                      columns[3].Trim().Equals(claseSeleccionada, StringComparison.OrdinalIgnoreCase));

                if (!clasesFiltradas.Any())
                {
                    MessageBox.Show($"No se encontraron clases para '{claseSeleccionada}'.", "Información");
                    return;
                }

                // Mostrar clases filtradas en el ListBox
                foreach (var fila in clasesFiltradas)
                {
                    string idClase = fila[1]?.Trim() ?? "Desconocido";
                    string fecha = fila[4]?.Trim() ?? "Sin fecha";
                    string horario = fila[5]?.Trim() ?? "Sin horario";
                    string idEntrenador = fila[2]?.Trim() ?? "Sin ID";

                    string nombreEntrenador = ObtenerNombreEntrenador(rutaEntrenadores, idEntrenador);
                    listBoxReservas.Items.Add($"ID: {idClase}, Fecha: {fecha}, Hora: {horario}, Entrenador: {nombreEntrenador}");
                }

                MessageBox.Show("Clases cargadas con éxito.", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar clases: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Consulta las reservas realizadas por el usuario.
        /// </summary>
        private void btnconsultaReserva_Click(object sender, EventArgs e)
        {
            try
            {
                string idUsuario = txtUsuarioId.Text.Trim();

                if (string.IsNullOrEmpty(idUsuario))
                {
                    MessageBox.Show("Por favor, ingrese una ID de usuario.", "Advertencia");
                    return;
                }

                listBoxConsulta.Items.Clear();

                // Filtrar las reservas del usuario en BaseDatosClase.csv
                var reservasUsuario = File.ReadAllLines(rutaBasedatosClase)
                    .Where(line => line.Split(';').Length >= 5 && line.Split(';')[3].Trim() == idUsuario)
                    .Select(line => line.Split(';')[4].Trim())
                    .ToList();

                if (!reservasUsuario.Any())
                {
                    MessageBox.Show("No se encontraron reservas para el usuario proporcionado.", "Sin resultados");
                    return;
                }

                // Obtener información detallada de las clases
                var clases = File.ReadAllLines(rutaClases);
                foreach (var claseId in reservasUsuario)
                {
                    var clase = clases
                        .Where(line => line.Split(';')[1].Trim() == claseId)
                        .Select(line => new
                        {
                            NombreClase = line.Split(';')[3].Trim(),
                            Fecha = line.Split(';')[4].Trim(),
                            Hora = line.Split(';')[5].Trim(),
                            IdEntrenador = line.Split(';')[2].Trim()
                        })
                        .FirstOrDefault();

                    if (clase != null)
                    {
                        string nombreEntrenador = ObtenerNombreEntrenador(rutaEntrenadores, clase.IdEntrenador);
                        listBoxConsulta.Items.Add($"Clase: {clase.NombreClase}, Fecha: {clase.Fecha}, Hora: {clase.Hora}, Entrenador: {nombreEntrenador}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar reservas: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Guarda la reserva seleccionada en el archivo BaseDatosClase.csv.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxReservas.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una clase antes de guardar.", "Advertencia");
                    return;
                }

                string claseSeleccionada = listBoxReservas.SelectedItem.ToString();
                string idClase = claseSeleccionada.Split(',')[0].Replace("ID: ", "").Trim();
                string idUsuario = txtUsuarioId.Text.Trim();

                if (string.IsNullOrEmpty(idUsuario))
                {
                    MessageBox.Show("No se pudo obtener el ID del usuario. Verifique la sesión.", "Error");
                    return;
                }

                // Verificar si el usuario existe
                if (!UsuarioExiste(idUsuario, out string nombreUsuario, out string apellido1, out string apellido2))
                {
                    MessageBox.Show("Usuario no encontrado.", "Error");
                    return;
                }

                // Verificar disponibilidad de cupos
                if (!ClaseTieneCuposDisponibles(idClase))
                {
                    MessageBox.Show("Cupos llenos para esta clase.", "Advertencia");
                    return;
                }

                // Guardar la reserva
                using (var writer = new StreamWriter(rutaBasedatosClase, true))
                {
                    writer.WriteLine($"{nombreUsuario};{apellido1};{apellido2};{idUsuario};{idClase}");
                }

                MessageBox.Show("Reserva guardada exitosamente.", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la reserva: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Verifica si el usuario existe en el archivo Usuarios.csv.
        /// </summary>
        private bool UsuarioExiste(string idUsuario, out string nombre, out string apellido1, out string apellido2)
        {
            var usuario = File.ReadAllLines(rutaUsuarios)
                .Skip(1)
                .Select(line => line.Split(';'))
                .FirstOrDefault(columns => columns.Length >= 7 && columns[6].Trim() == idUsuario);

            if (usuario != null)
            {
                nombre = usuario[2].Trim();
                apellido1 = usuario[3].Trim();
                apellido2 = usuario[4].Trim();
                return true;
            }

            nombre = apellido1 = apellido2 = null;
            return false;
        }

        /// <summary>
        /// Verifica si una clase tiene cupos disponibles.
        /// </summary>
        private bool ClaseTieneCuposDisponibles(string idClase)
        {
            var clase = File.ReadAllLines(rutaClases)
                .Where(line => line.Split(';')[1].Trim() == idClase)
                .Select(line => new
                {
                    CuposDisponibles = int.Parse(line.Split(';')[6].Trim())
                })
                .FirstOrDefault();

            if (clase == null) return false;

            var reservasClase = File.ReadAllLines(rutaBasedatosClase)
                .Count(line => line.Split(';')[4].Trim() == idClase);

            return reservasClase < clase.CuposDisponibles;
        }

        /// <summary>
        /// Obtiene el nombre del entrenador desde Entrenadores.csv.
        /// </summary>
        private string ObtenerNombreEntrenador(string rutaArchivo, string idEntrenador)
        {
            if (!File.Exists(rutaArchivo)) return "Archivo no encontrado";

            var entrenador = File.ReadAllLines(rutaArchivo)
                .Skip(1)
                .Select(line => line.Split(';'))
                .FirstOrDefault(columns => columns.Length >= 5 && columns[4].Equals(idEntrenador, StringComparison.OrdinalIgnoreCase));

            return entrenador != null ? entrenador[2] : "Desconocido";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formInicioSesion formularioInicioSesion = new formInicioSesion();
            formularioInicioSesion.Show();
            this.Close();
        }

        private void btnActualizarMenbresia_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            CalendarioForm calendarioForm = new CalendarioForm();

            // Mostrar el formulario CalendarioForm
            calendarioForm.Show();

            // Cerrar el formulario actual
            this.Close();
        }


        private void btnVerPagos_Click(object sender, EventArgs e)
        {
            int idUsuario = int.Parse(txtUsuarioId.Text.Trim());
            formPagos pagosForm = new formPagos(idUsuario);
            pagosForm.ShowDialog();
            
        }
    }
}















