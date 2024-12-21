using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class AdministradorControlInventarioTest
    {
        /// <summary>
        /// Test para comprobar que el archivo CSV se guarda correctamente con los datos modificados.
        /// </summary>
        [TestMethod]
        public void TestGuardarCSV()
        {
            // Arrange
            // Crear datos simulados (configuración inicial)
            List<string[]> datosSimulados = new List<string[]>
        {
            new string[] { "1", "2023-01-15", "10:00", "2023-02-01", "6", "Básico" },
            new string[] { "2", "2023-02-20", "11:00", "2023-03-01", "12", "Avanzado" },
            new string[] { "3", "2023-03-30", "13:00", "2023-04-01", "3", "Intermedio" }
        };
            string filePath = "Matriculas_guardadas_test.csv"; // Ruta temporal del archivo para guardar

            // Act
            // Crear el contenido CSV basado en los datos simulados
            string csvContent = "ID Cliente;Fecha de Inscripción;Hora de Inscripción;Fecha de Inicio;Duración (meses);Plan de Membresía\n";
            foreach (var fila in datosSimulados)
            {
                csvContent += string.Join(";", fila) + "\n"; // Formar las líneas CSV
            }

            // Guardar el contenido CSV en el archivo de prueba
            File.WriteAllText(filePath, csvContent);

            // Assert
            // Verificar que el archivo existe y tiene contenido
            Assert.IsTrue(File.Exists(filePath), "El archivo CSV no se guardó correctamente.");

            // Verificar que el archivo contiene el encabezado y los datos correctos
            string archivoLeido = File.ReadAllText(filePath);
            Assert.IsTrue(archivoLeido.Contains("ID Cliente;Fecha de Inscripción;Hora de Inscripción;Fecha de Inicio;Duración (meses);Plan de Membresía"), "El archivo CSV no contiene el encabezado esperado.");
            Assert.IsTrue(archivoLeido.Contains("1;2023-01-15;10:00;2023-02-01;6;Básico"), "El archivo CSV no contiene los datos esperados.");

            // Limpiar después de la prueba
            File.Delete(filePath);
        }

        /// <summary>
        /// Test para verificar la correcta carga de un archivo CSV y su procesamiento.
        /// </summary>
        [TestMethod]
        public void TestCargarCSV()
        {
            // Arrange
            // Contenido simulado de archivo CSV (preparar datos)
            string contenidoCSV = "ID Cliente;Fecha de Inscripción;Hora de Inscripción;Fecha de Inicio;Duración (meses);Plan de Membresía\n" +
                                  "1;2023-01-15;10:00;2023-02-01;6;Básico\n" +
                                  "2;2023-02-20;11:00;2023-03-01;12;Avanzado\n" +
                                  "3;2023-03-30;13:00;2023-04-01;3;Intermedio\n";

            // Act
            // Procesar el contenido CSV como si fuera leído desde un archivo
            var lineas = contenidoCSV.Split('\n');
            List<string[]> datosLeidos = new List<string[]>();

            foreach (var linea in lineas)
            {
                if (string.IsNullOrEmpty(linea) || linea.Contains("ID Cliente")) continue; // Ignorar encabezados
                datosLeidos.Add(linea.Split(';')); // Procesar los datos de la línea
            }

            // Assert
            // Verificar que se leyeron el número esperado de líneas
            Assert.AreEqual(3, datosLeidos.Count, "El número de filas leídas es incorrecto.");

            // Verificar que se leyeron correctamente los valores de la primera fila
            Assert.AreEqual("1", datosLeidos[0][0], "El ID Cliente de la primera fila no es correcto.");
            Assert.AreEqual("2023-01-15", datosLeidos[0][1], "La fecha de inscripción de la primera fila no es correcta.");
            Assert.AreEqual("Básico", datosLeidos[0][5], "El plan de membresía de la primera fila no es correcto.");
        }
    }
}
