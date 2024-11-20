using CalendarioPago;
using ClosedXML.Excel;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class formUsuario : Form
    {
        private string rutaEntrenadores = "Entrenadores.xlsx"; // Ruta del archivo Entrenadores
        private string rutaUsuarios = "Usuarios.xlsx"; // Ruta
        private string rutaClases = "Clases.xlsx"; // 
        private string rutaBasedatosClase = "BasedatosClase.xlsx"; // 
     
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

                listBoxReservas.Items.Clear(); // Limpiar lista antes de agregar nuevos datos

                using (var workbookClases = new XLWorkbook(rutaClases))
                {
                    var worksheetClases = workbookClases.Worksheet("Hoja1");

                    // Comprobar si la hoja tiene datos
                    if (worksheetClases == null)
                    {
                        MessageBox.Show("No se encontró la hoja 'Hoja1' en el archivo Clases.xlsx.", "Error");
                        return;
                    }

                    // Filtrar por clase seleccionada (columna 4 - "Clase")
                    var filas = worksheetClases.RowsUsed()
                                                .Where(row =>
                                                    row.Cell(4).GetValue<string>().Trim().Equals(claseSeleccionada, StringComparison.OrdinalIgnoreCase));

                    if (!filas.Any())
                    {
                        MessageBox.Show($"No se encontraron clases para la selección '{claseSeleccionada}'.", "Información");
                        return;
                    }

                    foreach (var fila in filas)
                    {
                        // Leer valores según la estructura de columnas
                        string idClase = fila.Cell(2).GetValue<string>();  // Columna 2: ID Clase
                        string fecha = fila.Cell(5).GetValue<string>();    // Columna 5: Fecha
                        string horario = fila.Cell(6).GetValue<string>();  // Columna 6: Horario
                        string idEntrenador = fila.Cell(3).GetValue<string>(); // Columna 3: ID Entrenador

                        // Buscar el nombre del entrenador
                        string nombreEntrenador = ObtenerNombreEntrenador(rutaEntrenadores, idEntrenador);

                        // Agregar a la lista
                        listBoxReservas.Items.Add($"ID: {idClase}, Fecha: {fecha}, Hora: {horario}, Entrenador: {nombreEntrenador}");
                    }
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
                if (listBoxReservas.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una clase de la lista antes de guardar.", "Advertencia");
                    return;
                }

                // Obtener la clase seleccionada
                string claseSeleccionada = listBoxReservas.SelectedItem.ToString();
                string idClase = claseSeleccionada.Split(',')[0].Replace("ID: ", "").Trim();

                // Leer datos del usuario
                string nombre = "", apellido1 = "", apellido2 = "", idUsuario = "";

                using (var workbookUsuarios = new XLWorkbook("Usuarios.xlsx"))
                {
                    var worksheetUsuarios = workbookUsuarios.Worksheet("Hoja1");
                    var filaUsuario = worksheetUsuarios.RowsUsed().FirstOrDefault();

                    if (filaUsuario != null)
                    {
                        nombre = filaUsuario.Cell(3).GetValue<string>();
                        apellido1 = filaUsuario.Cell(4).GetValue<string>();
                        apellido2 = filaUsuario.Cell(5).GetValue<string>();
                        idUsuario = filaUsuario.Cell(7).GetValue<string>();
                    }
                }

                // Guardar en la hoja "Hoja1" del archivo BasedatosClase.xlsx
                string archivoBaseDatos = "BasedatosClase.xlsx";

                using (var workbookBaseDatos = new XLWorkbook(archivoBaseDatos))
                {
                    var worksheet = workbookBaseDatos.Worksheet("Hoja1");

                    // Si la hoja no existe, la agregamos
                    if (worksheet == null)
                    {
                        worksheet = workbookBaseDatos.AddWorksheet("Hoja1");
                    }

                    // Encontrar la última fila de la hoja
                    int ultimaFila = worksheet.LastRowUsed()?.RowNumber() ?? 0;
                    int nuevaFila = ultimaFila + 1;

                    // Guardar los datos en la nueva fila
                    worksheet.Cell(nuevaFila, 1).Value = nombre;
                    worksheet.Cell(nuevaFila, 2).Value = apellido1;
                    worksheet.Cell(nuevaFila, 3).Value = apellido2;
                    worksheet.Cell(nuevaFila, 4).Value = idUsuario;
                    worksheet.Cell(nuevaFila, 5).Value = idClase;  // Añadir el ID de la clase si es necesario

                    // Guardar el archivo
                    workbookBaseDatos.SaveAs(archivoBaseDatos);
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
            using (var workbook = new XLWorkbook(rutaArchivo))
            {
                var worksheet = workbook.Worksheet("Hoja1");

                var fila = worksheet.RowsUsed()
                                    .FirstOrDefault(row => row.Cell(5).GetValue<string>().Equals(idEntrenador, StringComparison.OrdinalIgnoreCase));

                return fila != null ? fila.Cell(1).GetValue<string>() : "Desconocido";
            }
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

