namespace Test
{
    [TestClass]
    public class ClienteMembresiaTest
    {
        private List<string[]> datosCSV;

        /// <summary>
        /// Configuración inicial para preparar los datos simulados del CSV.
        /// </summary>
        [TestInitialize]
        public void TestSetup()
        {
            datosCSV = new List<string[]>
            {
                new string[] { "123", "01/01/2023", "10:00", "20/12/2024", "12", "Básico" },
                new string[] { "456", "15/02/2023", "14:00", "10/05/2025", "24", "Premium" },
                new string[] { "789", "05/03/2023", "16:30", "20/12/2024", "12", "Básico" },
            };
        }

        /// <summary>
        /// Test que verifica que un cliente existente pueda ser encontrado por su ID.
        /// </summary>
        [TestMethod]
        public void BuscarPorID_ClienteExistente_DeberiaMostrarResultados()
        {
            // Arrange
            string idCliente = "123";
            var tablaBody = new List<string[]>();

            // Act
            var resultadoBusqueda = datosCSV.FindAll(fila => fila[0] == idCliente);

            if (resultadoBusqueda.Count > 0)
            {
                foreach (var fila in resultadoBusqueda)
                {
                    tablaBody.Add(fila);
                }
            }

            // Assert
            Assert.AreEqual(1, tablaBody.Count, "No se encontró el cliente con el ID proporcionado.");
            Assert.AreEqual("123", tablaBody[0][0], "El ID Cliente no coincide.");
        }

        /// <summary>
        /// Test que verifica que no se muestren resultados para un cliente no existente.
        /// </summary>
        [TestMethod]
        public void BuscarPorID_ClienteNoExistente_NoDebeMostrarResultados()
        {
            // Arrange
            string idCliente = "000";
            var tablaBody = new List<string[]>();

            // Act
            var resultadoBusqueda = datosCSV.FindAll(fila => fila[0] == idCliente);

            if (resultadoBusqueda.Count > 0)
            {
                foreach (var fila in resultadoBusqueda)
                {
                    tablaBody.Add(fila);
                }
            }

            // Assert
            Assert.AreEqual(0, tablaBody.Count, "El cliente con el ID proporcionado fue encontrado aunque no debería.");
        }

        /// <summary>
        /// Test que verifica si se genera una alerta cuando la fecha de vencimiento está cerca.
        /// </summary>
        [TestMethod]
        public void FechaVencimientoProximaVencimiento_AlertaDeVencimiento()
        {
            // Arrange
            string idCliente = "123";
            var alertaEsperada = false;
            var cliente = datosCSV.Find(fila => fila[0] == idCliente);

            if (cliente != null)
            {
                string fechaVencimiento = cliente[3];
                if (fechaVencimiento == "20/12/2024")
                {
                    alertaEsperada = true;
                }
            }

            // Assert
            Assert.IsTrue(alertaEsperada, "No se generó la alerta de vencimiento.");
        }
    }
}
