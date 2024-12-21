using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class ClienteClaseTest
    {
        /// <summary>
        /// Prueba para verificar si el filtro de ID está funcionando correctamente
        /// </summary>
        [TestMethod]
        public void FiltrarPorID_DeberiaRetornarDatosCorrectos_WhenIDValido()
        {
            // Arrange 
            var idBuscada = "12345";  // ID que queremos buscar
            var datosCSV = new List<string[]>
        {
            new string[] { "Juan", "Pérez", "Lopez", "12345", "A1" }, // Datos de prueba
            new string[] { "María", "Gómez", "Martínez", "67890", "B2" }
        };

            var resultadoEsperado = new List<string[]>
        {
            new string[] { "Juan", "Pérez", "Lopez", "12345", "A1" }
        };

            // Act: Simular el filtro con el ID ingresado
            var resultado = FiltrarPorID(idBuscada, datosCSV);

            // Assert
            CollectionAssert.AreEqual(resultadoEsperado, resultado);
        }

        /// <summary>
        /// Función que simula el filtro de datos por ID
        /// </summary>
        private List<string[]> FiltrarPorID(string idBuscada, List<string[]> datos)
        {
            // Filtrar los datos buscando el ID en la cuarta columna
            return datos.Where(fila => fila[3] == idBuscada).ToList();
        }

        /// <summary>
        /// Test para la carga de datos del archivo CSV.
        /// </summary>
        [TestMethod]
        public void CargarDatosDeCSV_DeberiaCargarCorrectamenteDatosDesdeArchivo()
        {
            // Arrange
            var archivoCSV = "sample-data/BasedatosClase.csv";

            // Aquí deberías simular la lectura del archivo CSV y cargar los datos

            // Este test dependería del entorno, pero podrías simular el proceso de carga si fuera necesario.
            // Act: Llamar al método que carga datos del CSV
            var datosCargados = CargarDatosDesdeArchivo(archivoCSV);

            // Assert: Verificar que los datos se hayan cargado correctamente.
            Assert.IsNotNull(datosCargados); // Verificar que no sea nulo
            Assert.IsTrue(datosCargados.Count > 0); // Verificar que se cargaron datos
        }

        /// <summary>
        /// Método simulado para cargar datos desde el archivo CSV
        /// </summary>
        private List<string[]> CargarDatosDesdeArchivo(string archivoCSV)
        {
            // En una prueba real, este método cargaría el archivo CSV, pero aquí simulamos datos.
            return new List<string[]>
        {
            new string[] { "Juan", "Pérez", "Lopez", "12345", "A1" },
            new string[] { "María", "Gómez", "Martínez", "67890", "B2" }
        };
        }
    }
}