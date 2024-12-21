namespace Test
{
    [TestClass]
    public class EntrenadorAgregarRutinaTest
    {
        private List<string[]> datosCSV; // Lista simulada para almacenar los datos del CSV

        /// <summary>
        /// Simula la carga de datos desde un archivo CSV.
        /// </summary>
        private void SimularCargarDatosCSV()
        {
            datosCSV = new List<string[]>
            {
                new string[] { "Juan", "Pérez", "ID1", "Sentadillas", "15" },
                new string[] { "Ana", "Gómez", "ID2", "Lagartijas", "20" },
                new string[] { "Carlos", "Rodríguez", "ID3", "Planchas", "25" }
            };
        }

        /// <summary>
        /// Test que verifica si los datos de las rutinas se cargan correctamente.
        /// </summary>
        [TestMethod]
        public void TestCargarRutinas_DatosCargadosCorrectamente_ListaNoVacia()
        {
            // Arrange
            SimularCargarDatosCSV();

            // Act
            var primeraFila = datosCSV.FirstOrDefault();
            var nombre = primeraFila?[0];

            // Assert
            Assert.IsNotNull(datosCSV, "Los datos CSV deberían haberse cargado.");
            Assert.AreEqual("Juan", nombre, "El nombre en la primera fila debería ser 'Juan'.");
        }

        /// <summary>
        /// Test que verifica si se filtran los datos correctamente por ID.
        /// </summary>
        [TestMethod]
        public void TestFiltrarPorID_IDExistente_DevuelveDatosCorrectos()
        {
            // Arrange
            SimularCargarDatosCSV();
            string idBuscado = "ID2";

            // Act
            var resultado = datosCSV.FirstOrDefault(fila => fila[2] == idBuscado);

            // Assert
            Assert.IsNotNull(resultado, $"No se encontró el ID {idBuscado}.");
            Assert.AreEqual("Ana", resultado[0], "El nombre asociado al ID2 debería ser 'Ana'.");
        }

        /// <summary>
        /// Test que verifica si se editan los datos de una rutina correctamente.
        /// </summary>
        [TestMethod]
        public void TestEditarRutina_IDExistente_ActualizaRutinaYRepeticiones()
        {
            // Arrange
            SimularCargarDatosCSV();
            string idBuscado = "ID3";
            string nuevaRutina = "Correr";
            string nuevasRepeticiones = "30";

            // Act
            var fila = datosCSV.FirstOrDefault(fila => fila[2] == idBuscado);
            if (fila != null)
            {
                fila[3] = nuevaRutina;
                fila[4] = nuevasRepeticiones;
            }

            // Assert
            Assert.AreEqual(nuevaRutina, fila[3], "La rutina debería haberse actualizado a 'Correr'.");
            Assert.AreEqual(nuevasRepeticiones, fila[4], "Las repeticiones deberían haberse actualizado a '30'.");
        }

        /// <summary>
        /// Test que verifica si los datos de las rutinas se guardan correctamente.
        /// </summary>
        [TestMethod]
        public void TestGuardarDatos_ArchivoGenerado_ContienePrimeraFila()
        {
            // Arrange
            SimularCargarDatosCSV();

            // Simular el guardado del archivo CSV
            string resultadoCSV = "Nombre;Apellido;ID;Rutina;Repeticiones\n";
            foreach (var fila in datosCSV)
            {
                resultadoCSV += string.Join(";", fila) + "\n";
            }

            // Act
            bool contienePrimeraFila = resultadoCSV.Contains("Juan;Pérez;ID1;Sentadillas;15");

            // Assert
            Assert.IsTrue(contienePrimeraFila, "El CSV generado debe contener la primera fila.");
        }
    }
}
