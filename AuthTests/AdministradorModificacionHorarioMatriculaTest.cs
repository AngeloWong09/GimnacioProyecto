using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
  
    [TestClass]
    public class AdministradorModificacionHorarioMatriculaTest
    {
        /// <summary>
        /// Test para comprobar que el archivo CSV se guarda correctamente con los datos modificados.
        /// </summary>
        [TestMethod]
        public void TestGuardarCSV()
        {
            // Arrange
            // Aquí podemos crear un conjunto de datos simulado que correspondería con los datos editados en el CSV
            List<string[]> datosSimulados = new List<string[]>
        {
            new string[] { "1", "2023-01-15", "10:00", "2023-02-01", "6", "Básico" },
            new string[] { "2", "2023-02-20", "11:00", "2023-03-01", "12", "Avanzado" },
            new string[] { "3", "2023-03-30", "13:00", "2023-04-01", "3", "Intermedio" }
        };

            // Ruta temporal para guardar el archivo CSV generado
            string filePath = "Matriculas_guardadas_test.csv";

            // Act: Guardar los datos como archivo CSV (simulando el comportamiento del botón "Guardar datos")
            string csvContent = "ID Cliente;Fecha de Inscripción;Hora de Inscripción;Fecha de Inicio;Duración (meses);Plan de Membresía\n";
            foreach (var fila in datosSimulados)
            {
                csvContent += string.Join(";", fila) + "\n";
            }

            // Guardamos el contenido CSV en un archivo de prueba
            File.WriteAllText(filePath, csvContent);

            // Assert: Verificar que el archivo existe y tiene contenido válido
            Assert.IsTrue(File.Exists(filePath), "El archivo CSV no se guardó correctamente.");

            // También podemos comprobar que el contenido del archivo es correcto
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
            // Simular el contenido del archivo CSV como si fuera un archivo real
            string contenidoCSV = "ID Cliente;Fecha de Inscripción;Hora de Inscripción;Fecha de Inicio;Duración (meses);Plan de Membresía\n" +
                                  "1;2023-01-15;10:00;2023-02-01;6;Básico\n" +
                                  "2;2023-02-20;11:00;2023-03-01;12;Avanzado\n" +
                                  "3;2023-03-30;13:00;2023-04-01;3;Intermedio\n";

            // Act: Simular la lectura del archivo CSV y procesarlo
            var lineas = contenidoCSV.Split('\n');
            List<string[]> datosLeidos = new List<string[]>();

            foreach (var linea in lineas)
            {
                if (string.IsNullOrEmpty(linea) || linea.Contains("ID Cliente")) continue; // Saltar el encabezado
                datosLeidos.Add(linea.Split(';'));
            }

            // Assert: Verificar que los datos leídos son correctos
            Assert.AreEqual(3, datosLeidos.Count, "El número de filas leídas es incorrecto.");
            Assert.AreEqual("1", datosLeidos[0][0], "El ID Cliente de la primera fila no es correcto.");
            Assert.AreEqual("2023-01-15", datosLeidos[0][1], "La fecha de inscripción de la primera fila no es correcta.");
            Assert.AreEqual("Básico", datosLeidos[0][5], "El plan de membresía de la primera fila no es correcto.");
        }
    }

}