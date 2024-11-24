using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class formGananciaMaquina : Form
    {
        private readonly string rutaMaquinas = Path.Combine(Application.StartupPath, "Assets", "Maquinas.csv");
        public formGananciaMaquina()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si el archivo existe
                if (!File.Exists(rutaMaquinas))
                {
                    MessageBox.Show($"El archivo no se encuentra en la ruta: {rutaMaquinas}",
                                    "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lee el archivo CSV línea por línea
                var lineas = File.ReadAllLines(rutaMaquinas);

                // Limpia el ListBox antes de cargar nuevos datos
                listReporteMaquina.Items.Clear();

                // Carga las líneas en el ListBox
                foreach (var linea in lineas)
                {
                    listReporteMaquina.Items.Add(linea);
                }

                MessageBox.Show("Datos cargados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void btnGuadarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si hay datos en el ListBox
                if (listReporteMaquina.Items.Count == 0)
                {
                    MessageBox.Show("No hay datos para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ruta para guardar el archivo TXT
                string rutaDirectorio = "reportes/maquinas";
                string rutaTXT = Path.Combine(rutaDirectorio, "ReporteMaquinas.txt");

                // Crea el directorio si no existe
                if (!Directory.Exists(rutaDirectorio))
                {
                    Directory.CreateDirectory(rutaDirectorio);
                }

                // Escribe los datos del ListBox en el archivo TXT
                using (StreamWriter sw = new StreamWriter(rutaTXT))
                {
                    foreach (var item in listReporteMaquina.Items)
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

        private void btnMenuEntrenador_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario formEntrenadores
            var formEntrenadores = new formEntrenador();

            // Mostrar el formulario (modo no modal)
            formEntrenadores.Show();

            this.Close();
        }

        private void btnDineroIngresoSalida_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si el archivo existe
                if (!File.Exists(rutaMaquinas))
                {
                    MessageBox.Show($"El archivo no se encuentra en la ruta: {rutaMaquinas}",
                                    "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lee el archivo CSV línea por línea
                var lineas = File.ReadAllLines(rutaMaquinas);

                // Limpia el ListBox antes de cargar nuevos datos
                listReporteMaquina.Items.Clear();

                // Itera a través de cada línea del archivo CSV
                foreach (var linea in lineas)
                {
                    // Separa la línea por comas
                    var valores = linea.Split(',');

                    // Verifica que la línea tiene el número correcto de columnas (6 columnas)
                    if (valores.Length == 6)
                    {
                        // Extrae los valores de "Ingresos" y "Egresos"
                        string ingresos = valores[3];  // Columna 4: "Ingresos"
                        string egresos = valores[4];   // Columna 5: "Egresos"

                        // Agrega los datos de Ingresos y Egresos al ListBox
                        string datos = $"Ingresos: {ingresos}, Egresos: {egresos}";
                        listReporteMaquina.Items.Add(datos);
                    }
                }

                MessageBox.Show("Datos cargados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
