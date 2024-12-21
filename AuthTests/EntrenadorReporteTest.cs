using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    [TestClass]
    public class EntrenadorReporteTest
    {
        private List<string[]> datosCSV;  // Lista de datos cargados desde el CSV

        /// <summary>
        /// Simulación de CSV cargado de prueba (equivalente al archivo CSV).
        /// </summary>
        private void SimularCargarDatosCSV()
        {
            datosCSV = new List<string[]>
            {
                new string[] { "usuario1", "contraseña1", "Juan", "Pérez", "1", "Fuerza1" },
                new string[] { "usuario2", "contraseña2", "Ana", "Gómez", "2", "Fuerza2" },
                new string[] { "usuario3", "contraseña3", "Carlos", "Rodríguez", "3", "Fuerza3" }
            };
        }

        /// <summary>
        /// Test que verifica la correcta carga de datos desde un archivo CSV simulado.
        /// </summary>
        [TestMethod]
        public void TestCargarDatosCSV_DatosCargados_Correctamente()
        {
            // Arrange
            SimularCargarDatosCSV();

            // Act
            var primerFila = datosCSV.FirstOrDefault();
            var nombre = primerFila?[2];

            // Assert
            Assert.IsNotNull(datosCSV, "Los datos CSV deberían haberse cargado.");
            Assert.AreEqual("Juan", nombre, "El nombre en la primera fila debería ser 'Juan'.");
        }

        /// <summary>
        /// Test que verifica que los cambios realizados a los datos se guardan correctamente.
        /// </summary>
        [TestMethod]
        public void TestGuardarCambios_DatosCambiados_Correctamente()
        {
            // Arrange
            SimularCargarDatosCSV();

            // Act
            var segundoEntrenador = datosCSV[1];
            segundoEntrenador[5] = "Fuerza modificada";
            var actualizado = datosCSV[1][5];

            // Assert
            Assert.AreEqual("Fuerza modificada", actualizado, "El punto fuerte debería haber sido actualizado.");
        }

        /// <summary>
        /// Test que verifica si los datos se guardan correctamente en un archivo CSV simulado.
        /// </summary>
        [TestMethod]
        public void TestGuardarCSV_ContenidoCorrecto_CSVGenerado()
        {
            // Arrange
            SimularCargarDatosCSV();
            string resultadoCSV = string.Join("\n", datosCSV.Select(fila => string.Join(";", fila)));

            // Act
            bool contienePrimeraFila = resultadoCSV.Contains("usuario1;contraseña1;Juan;Pérez;1;Fuerza1");

            // Assert
            Assert.IsTrue(contienePrimeraFila, "El CSV generado debe contener la primera fila.");
        }

        /// <summary>
        /// Test que verifica el filtro de datos por ID de entrenador.
        /// </summary>
        [TestMethod]
        public void TestFiltrarPorID_IDEncontrado_EntrenadorCorrecto()
        {
            // Arrange
            SimularCargarDatosCSV();
            string idBuscado = "2";

            // Act
            var resultado = datosCSV.FirstOrDefault(fila => fila[4] == idBuscado);

            // Assert
            Assert.IsNotNull(resultado, "El entrenador con el ID especificado debería existir.");
            Assert.AreEqual("Ana", resultado[2], "El nombre del entrenador debería ser 'Ana'.");
        }

        /// <summary>
        /// Test que calcula la suma de precios de clases a partir de datos cargados.
        /// </summary>
        [TestMethod]
        public void TestCalcularSumaPrecios_DatosCargados_SumaCorrecta()
        {
            // Arrange
            datosCSV = new List<string[]>
            {
                new string[] { "1", "101", "1", "Clase A", "2024-12-21", "08:00", "10", "1000" },
                new string[] { "2", "102", "1", "Clase B", "2024-12-22", "10:00", "15", "1500" },
                new string[] { "3", "103", "2", "Clase C", "2024-12-23", "12:00", "20", "2000" }
            };

            // Act
            var sumaTotal = datosCSV.Sum(fila => int.Parse(fila[7]));

            // Assert
            Assert.AreEqual(4500, sumaTotal, "La suma total de los precios debería ser 4500.");
        }
    }
}
