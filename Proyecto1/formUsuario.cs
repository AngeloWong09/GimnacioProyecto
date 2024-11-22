using CalendarioPago;
using ClosedXML.Excel;
using Proyecto1.Modelo;
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

        // Modificar el constructor para aceptar el ID del usuario
      


        public formUsuario(string usuarioId)
        {
            InitializeComponent();

            // Inicializar opciones de ComboBox
            comboBoxClases.Items.AddRange(new string[] { "Zumba", "Funcionales", "CardioDance" });
            this.usuarioId = usuarioId;  // Asignar el ID del usuario
            txtUsuarioId.Text = usuarioId.ToString();  // Convertir el ID a string para mostrarlo en el TextBox
        }


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

                // Filtrar clases por selección
                var filas = lineas.Skip(1)
                                  .Select(line => line.Split(';'))
                                  .Where(columns => columns.Length >= 6 &&
                                                    columns[3].Trim().Equals(claseSeleccionada, StringComparison.OrdinalIgnoreCase));

                if (!filas.Any())
                {
                    MessageBox.Show($"No se encontraron clases para la selección '{claseSeleccionada}'.", "Información");
                    return;
                }

                // Agregar clases al ListBox
                foreach (var fila in filas)
                {
                    string idClase = fila[1]?.Trim() ?? "Desconocido";
                    string fecha = fila[4]?.Trim() ?? "Sin fecha";
                    string horario = fila[5]?.Trim() ?? "Sin horario";
                    string idEntrenador = fila[2]?.Trim() ?? "Sin ID";

                    string nombreEntrenador = ObtenerNombreEntrenador(rutaEntrenadores, idEntrenador);  // Corregido

                    listBoxReservas.Items.Add($"ID: {idClase}, Fecha: {fecha}, Hora: {horario}, Entrenador: {nombreEntrenador}");
                }

                MessageBox.Show("Clases cargadas con éxito.", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar clases: {ex.Message}", "Error");
            }
        }


        private void btnconsultaReserva_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la ID del usuario desde el txtUsuarioId
                string idUsuario = txtUsuarioId.Text.Trim();

                if (string.IsNullOrEmpty(idUsuario))
                {
                    MessageBox.Show("Por favor, ingrese una ID de usuario.", "Advertencia");
                    return;
                }

                // Limpiar el listBox para mostrar solo los resultados actuales
                listBoxConsulta.Items.Clear();

                // Leer las líneas del archivo BasedatosClase.csv
                var reservas = File.ReadAllLines(rutaBasedatosClase);

                // Filtrar las reservas donde la ID del usuario coincide con la ID del usuario
                var reservasUsuario = reservas
                    .Where(line => line.Split(';').Length >= 5 && line.Split(';')[3].Trim() == idUsuario)
                    .Select(line => line.Split(';')[4].Trim())  // Extraer la clase (columna 5, índice 4)
                    .ToList();

                if (reservasUsuario.Count > 0)
                {
                    // Leer el archivo Clases.csv para obtener la información de las clases (fecha, hora, nombre)
                    var clases = File.ReadAllLines(rutaClases);

                    // Iterar por cada clase reservada y obtener la información completa
                    foreach (var claseId in reservasUsuario)
                    {
                        var clase = clases
                            .Where(line => line.Split(';')[1].Trim() == claseId)
                            .Select(line => new
                            {
                                NombreClase = line.Split(';')[3].Trim(), // Nombre de la clase (columna 4)
                                Fecha = line.Split(';')[4].Trim(),        // Fecha de la clase (columna 5)
                                Hora = line.Split(';')[5].Trim(),         // Horario de la clase (columna 6)
                                IdEntrenador = line.Split(';')[2].Trim()   // ID del entrenador (columna 3)
                            })
                            .FirstOrDefault();

                        if (clase != null)
                        {
                            // Obtener el nombre del entrenador
                            string nombreEntrenador = ObtenerNombreEntrenador(rutaEntrenadores, clase.IdEntrenador);

                            // Agregar la información a listBoxConsulta (sin la ID de la clase)
                            listBoxConsulta.Items.Add($"Clase: {clase.NombreClase}, Fecha: {clase.Fecha}, Hora: {clase.Hora}, Entrenador: {nombreEntrenador}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron reservas para el usuario con la ID proporcionada.", "Sin resultados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar las reservas: {ex.Message}", "Error");
            }
        }

        //Guaradar la reserva
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se seleccionó una clase en la listBox
                if (listBoxReservas.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una clase de la lista antes de guardar.", "Advertencia");
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

                // Leer usuarios para verificar si existe el ID
                var usuarios = File.ReadAllLines(rutaUsuarios);
                var usuario = usuarios.Skip(1)
                                      .Select(line => line.Split(';'))
                                      .FirstOrDefault(columns => columns.Length >= 7 && columns[6].Trim() == idUsuario);

                if (usuario == null)
                {
                    MessageBox.Show("No se encontró el usuario en el archivo Usuarios.csv.", "Error");
                    return;
                }

                string nombreUsuario = usuario[2].Trim();
                string apellido1Usuario = usuario[3].Trim();
                string apellido2Usuario = usuario[4].Trim();

                // Leer el archivo de clases para obtener el cupo
                var clases = File.ReadAllLines(rutaClases);
                var claseInfo = clases
                    .Where(line => line.Split(';')[1].Trim() == idClase)
                    .Select(line => new
                    {
                        CuposDisponibles = int.Parse(line.Split(';')[6].Trim()) // Columna 7: Cupos
                    })
                    .FirstOrDefault();

                if (claseInfo == null)
                {
                    MessageBox.Show("No se encontró información sobre la clase seleccionada.", "Error");
                    return;
                }

                int cuposDisponibles = claseInfo.CuposDisponibles;

                // Leer el archivo BasedatosClase.csv para contar cuántos usuarios han hecho reserva para esta clase
                var reservas = File.ReadAllLines(rutaBasedatosClase);
                var reservasDeClase = reservas
                    .Where(line => line.Split(';')[4].Trim() == idClase) // Filtramos por ID de clase
                    .Select(line => line.Split(';')[3].Trim()) // Extraemos el ID del usuario
                    .Distinct() // Aseguramos que solo contemos usuarios diferentes
                    .Count();

                // Verificar si ya se alcanzó el límite de cupos
                if (reservasDeClase >= cuposDisponibles)
                {
                    MessageBox.Show("No se puede hacer la reserva, cupo lleno.", "Advertencia");
                    return;
                }

                // Si aún hay cupos disponibles, guardar la nueva reserva en BasedatosClase.csv
                using (var writer = new StreamWriter(rutaBasedatosClase, true))
                {
                    string nuevaReserva = $"{nombreUsuario};{apellido1Usuario};{apellido2Usuario};{idUsuario};{idClase}";
                    writer.WriteLine(nuevaReserva); // Escribe la nueva línea de reserva

                    // Confirmación de que la reserva se guardó
                    Console.WriteLine("Reserva guardada: " + nuevaReserva); // Se puede usar para depurar en la consola
                }

                MessageBox.Show("Reserva guardada exitosamente.", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la reserva: {ex.Message}", "Error");
            }

        }
       
        // Obtener el nombre del entrenador desde Entrenadores.csv
        private string ObtenerNombreEntrenador(string rutaArchivo, string idEntrenador)
        {
            if (!File.Exists(rutaEntrenadores))
            {
                return "Archivo de entrenadores no encontrado";
            }

            var entrenador = File.ReadAllLines(rutaEntrenadores)
                                 .Skip(1)
                                 .Select(line => line.Split(';'))
                                 .FirstOrDefault(columns => columns.Length >= 5 && columns[4].Equals(idEntrenador, StringComparison.OrdinalIgnoreCase));

            return entrenador != null ? entrenador[2] : "Desconocido";
        }

        // Evento para manejar cambios en el TextBox de usuarioId
        private void txtUsuarioId_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuarioId.Text != usuarioId)
            {
                txtUsuarioId.Text = usuarioId;
                txtUsuarioId.SelectionStart = txtUsuarioId.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formInicioSesion formularioInicioSesion = new formInicioSesion();
            formularioInicioSesion.Show();
            this.Close();
        }

        private void btnActualizarMenbresia_Click(object sender, EventArgs e)
        {
            PagoMembresiaForm pagoForm = new PagoMembresiaForm();

            // Mostrar el formulario de pago
            pagoForm.ShowDialog();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            CalendarioForm calendarioForm = new CalendarioForm();

            // Mostrar el formulario CalendarioForm
            calendarioForm.Show();

            // Cerrar el formulario actual
            this.Close();
        }
    }

    




        



}

    

