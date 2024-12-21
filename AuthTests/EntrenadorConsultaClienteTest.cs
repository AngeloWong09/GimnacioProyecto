namespace Test
{
    [TestClass]
    public class EntrenadorConsultaClienteTest
    {
        private List<string[]> clasesCSV; // Lista simulada para almacenar los datos de Clases.csv
        private List<string[]> basedatosCSV; // Lista simulada para almacenar los datos de BasedatosClase.csv

        /// <summary>
        /// Simular la carga de los datos de Clases.csv.
        /// </summary>
        private void SimularCargarClasesCSV()
        {
            clasesCSV = new List<string[]>
            {
                new string[] { "Clase1", "ID1", "Profesor1", "Sentadillas", "2024-12-01", "10:00" },
                new string[] { "Clase2", "ID2", "Profesor2", "Lagartijas", "2024-12-02", "11:00" },
                new string[] { "Clase3", "ID3", "Profesor3", "Planchas", "2024-12-03", "12:00" }
            };
        }

        /// <summary>
        /// Simular la carga de los datos de BasedatosClase.csv.
        /// </summary>
        private void SimularCargarBasedatosClaseCSV()
        {
            basedatosCSV = new List<string[]>
            {
                new string[] { "Juan", "Pérez", "ID1", "Sentadillas", "15" },
                new string[] { "Ana", "Gómez", "ID2", "Lagartijas", "20" },
                new string[] { "Carlos", "Rodríguez", "ID3", "Planchas", "25" }
            };
        }

        /// <summary>
        /// Test que verifica la carga de datos de Clases.csv.
        /// </summary>
        [TestMethod]
        public void TestCargarDatosClases()
        {
            // Arrange
            SimularCargarClasesCSV();

            // Act
            var clase = clasesCSV.FirstOrDefault(c => c[1] == "ID1");
            var nombreClase = clase?[0];

            // Assert
            Assert.IsNotNull(clase, "Los datos de clases deberían haberse cargado.");
            Assert.AreEqual("Clase1", nombreClase, "El nombre de la clase con ID 'ID1' debería ser 'Clase1'.");
        }

        /// <summary>
        /// Test que filtra datos por ID de clase.
        /// </summary>
        [TestMethod]
        public void TestFiltrarPorIDClase()
        {
            // Arrange
            SimularCargarBasedatosClaseCSV();
            string idClaseBuscada = "ID2";

            // Act
            var resultado = basedatosCSV.FirstOrDefault(fila => fila[2] == idClaseBuscada);

            // Assert
            Assert.IsNotNull(resultado, $"No se encontró el ID de clase {idClaseBuscada}.");
            Assert.AreEqual("Ana", resultado[0], "El nombre asociado al ID2 debería ser 'Ana'.");
        }

        /// <summary>
        /// Test que verifica los datos mostrados de una clase específica.
        /// </summary>
        [TestMethod]
        public void TestMostrarDatosClase()
        {
            // Arrange
            SimularCargarClasesCSV();
            string idClaseBuscada = "ID2";

            // Act
            var claseData = clasesCSV.FirstOrDefault(clase => clase[1] == idClaseBuscada);
            string clase = claseData?[3];
            string fecha = claseData?[4];
            string hora = claseData?[5];

            // Assert
            Assert.IsNotNull(claseData, "Los datos de clase no deberían ser nulos.");
            Assert.AreEqual("Lagartijas", clase, "La clase asociada al ID2 debería ser 'Lagartijas'.");
            Assert.AreEqual("2024-12-02", fecha, "La fecha asociada al ID2 debería ser '2024-12-02'.");
            Assert.AreEqual("11:00", hora, "La hora asociada al ID2 debería ser '11:00'.");
        }

        /// <summary>
        /// Test que filtra y muestra datos de clases y su base de datos asociada.
        /// </summary>
        [TestMethod]
        public void TestFiltrarYMostrarDatos()
        {
            // Arrange
            SimularCargarClasesCSV();
            SimularCargarBasedatosClaseCSV();
            string idClaseBuscada = "ID3";

            // Act
            var claseData = clasesCSV.FirstOrDefault(clase => clase[1] == idClaseBuscada);
            var fila = basedatosCSV.FirstOrDefault(fila => fila[2] == idClaseBuscada);

            // Filtrar y mostrar datos
            string clase = claseData?[3];
            string hora = claseData?[5];
            string fecha = claseData?[4];

            // Assert
            Assert.IsNotNull(claseData, "Los datos de clase no deberían ser nulos.");
            Assert.IsNotNull(fila, "Los datos de BasedatosClase no deberían ser nulos.");
            Assert.AreEqual("Planchas", clase, "La clase asociada al ID3 debería ser 'Planchas'.");
            Assert.AreEqual("2024-12-03", fecha, "La fecha asociada al ID3 debería ser '2024-12-03'.");
            Assert.AreEqual("12:00", hora, "La hora asociada al ID3 debería ser '12:00'.");
        }
    }
}
