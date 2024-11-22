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
        private string rutaEntrenadores = Path.Combine(Application.StartupPath, "Assets", "Entrenadores.csv");
        private string rutaUsuarios = Path.Combine(Application.StartupPath, "Assets", "Usuarios.csv");
        private string rutaClases = Path.Combine(Application.StartupPath, "Assets", "Clases.csv");
        private string rutaBasedatosClase = Path.Combine(Application.StartupPath, "Assets", "BasedatosClase.csv");
        public static usuarioModelo UsuarioLogueado; // Variable estática para almacenar el usuario logueado


        public formUsuario()
        {
            InitializeComponent();

            comboBoxClases.Items.AddRange(new string[] { "Zumba", "Funcionales", "CardioDance" });
        }


        // Inicializar el ComboBox con las opciones de clase
        private void InicializarComboBoxClases()
        {
            comboBoxClases.Items.AddRange(new string[] { "Zumba", "Funcionales", "CardioDance" });
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

                listBoxReservas.Items.Clear(); // Limpiar la lista antes de agregar nuevos datos

                // Leer y procesar el archivo Clases.csv
                var lineas = File.ReadAllLines(rutaClases);

                if (lineas.Length <= 1)
                {
                    MessageBox.Show("El archivo Clases.csv está vacío o solo contiene el encabezado.", "Información");
                    return;
                }

                // Procesar datos
                var filas = lineas.Skip(1) // Omitir el encabezado
                                  .Select(line => line.Split(';'))
                                  .Where(columns => columns.Length >= 6 &&  // Validar que hay suficientes columnas
                                                    columns[3].Trim().Equals(claseSeleccionada, StringComparison.OrdinalIgnoreCase));

                if (!filas.Any())
                {
                    MessageBox.Show($"No se encontraron clases para la selección '{claseSeleccionada}'.", "Información");
                    return;
                }

                foreach (var fila in filas)
                {
                    // Validar que las columnas tengan datos antes de acceder
                    string idClase = fila[1]?.Trim() ?? "Desconocido";  // Columna 2: ID Clase
                    string fecha = fila[4]?.Trim() ?? "Sin fecha";      // Columna 5: Fecha
                    string horario = fila[5]?.Trim() ?? "Sin horario";  // Columna 6: Horario
                    string idEntrenador = fila[2]?.Trim() ?? "Sin ID";  // Columna 3: ID Entrenador

                    // Buscar el nombre del entrenador
                    string nombreEntrenador = ObtenerNombreEntrenador(rutaEntrenadores, idEntrenador);

                    // Agregar a la lista
                    listBoxReservas.Items.Add($"ID: {idClase}, Fecha: {fecha}, Hora: {horario}, Entrenador: {nombreEntrenador}");
                }

                if (listBoxReservas.Items.Count == 0)
                {
                    MessageBox.Show("No se cargaron elementos en la lista.", "Información");
                }
                else
                {
                    MessageBox.Show("Clases cargadas con éxito.", "Éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar clases: {ex.Message}", "Error");
            }
        }

        //Guaradar la reserva
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que haya una clase seleccionada
                if (listBoxReservas.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una clase de la lista antes de guardar.", "Advertencia");
                    return;
                }

                // Obtener la clase seleccionada
                string claseSeleccionada = listBoxReservas.SelectedItem.ToString();
                string idClase = claseSeleccionada.Split(',')[0].Replace("ID: ", "").Trim();

                // Verificar que haya un usuario logueado
                if (UsuarioLogueado == null)
                {
                    MessageBox.Show("No hay un usuario autenticado. Inicie sesión primero.", "Error");
                    return;
                }

                // Obtener los datos del usuario logueado
                string nombreUsuario = UsuarioLogueado.Nombre;
                string apellido1Usuario = UsuarioLogueado.Apellido1;
                string apellido2Usuario = UsuarioLogueado.Apellido2;
                string idUsuario = UsuarioLogueado.Id.ToString();  // Usar "Id" en lugar de "ID"


                // Verificar que los datos sean correctos
                if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(apellido1Usuario) || string.IsNullOrEmpty(idUsuario))
                {
                    MessageBox.Show("No se pudo recuperar la información del usuario.", "Error");
                    return;
                }

                // Depuración: Mostrar lo que se va a guardar
                MessageBox.Show($"Guardando reserva: {nombreUsuario} {apellido1Usuario} {apellido2Usuario}, ID Usuario: {idUsuario}, ID Clase: {idClase}", "Depuración");

                // Guardar la reserva en el archivo BasedatosClase.csv
                using (var writer = new StreamWriter(rutaBasedatosClase, true))
                {
                    // Escribir los datos en el archivo CSV: Nombre, Apellido, ID Usuario, ID Clase
                    writer.WriteLine($"{nombreUsuario};{apellido1Usuario};{apellido2Usuario};{idUsuario};{idClase}");
                    writer.Flush(); // Asegura que los datos se escriban inmediatamente
                }

                MessageBox.Show("Reserva guardada exitosamente.", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la reserva: {ex.Message}", "Error");
            }
        }
    



        // Obtener el nombre del entrenador desde Entrenadores.xlsx
        private string ObtenerNombreEntrenador(string rutaArchivo, string idEntrenador)
        {
            // Leer Entrenadores.csv y buscar el entrenador por ID
            var entrenador = File.ReadAllLines(rutaArchivo)
                                 .Skip(1) // Omitir el encabezado
                                 .Select(line => line.Split(';'))
                                 .FirstOrDefault(columns => columns[4].Equals(idEntrenador, StringComparison.OrdinalIgnoreCase));

            return entrenador != null ? entrenador[2] : "Desconocido";
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de inicio de sesión
            formInicioSesion formularioInicioSesion = new formInicioSesion();
            formularioInicioSesion.Show();

            // Cerrar el formulario actual
            this.Close();
        }

        private void btnActualizarMenbresia_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de Calendario
            CalendarioForm formularioCalendario = new CalendarioForm();
            formularioCalendario.Show();

            // Cerrar el formulario actual
            this.Close();
        }

    
    }
    }

