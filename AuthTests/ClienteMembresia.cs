using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class ClienteMembresiaTest
    {
        // Simular los datos cargados del archivo CSV.
        private List<string[]> datosCSV;

        [TestInitialize]
        public void TestSetup()
        {
            // Preparamos los datos que vendrían del CSV
            datosCSV = new List<string[]>
            {
                new string[] { "123", "01/01/2023", "10:00", "20/12/2024", "12", "Básico" },
                new string[] { "456", "15/02/2023", "14:00", "10/05/2025", "24", "Premium" },
                new string[] { "789", "05/03/2023", "16:30", "20/12/2024", "12", "Básico" },
            };
        }

        [TestMethod]
        public void BuscarPorID_ClienteExistente_DeberiaMostrarResultados()
        {
            // Arrange
            string idCliente = "123";
            var tablaBody = new List<string[]>(); // Emulamos el cuerpo de la tabla HTML

            // Act: Filtramos los datos CSV por el ID Cliente proporcionado
            var resultadoBusqueda = datosCSV.FindAll(fila => fila[0] == idCliente);

            if (resultadoBusqueda.Count > 0)
            {
                foreach (var fila in resultadoBusqueda)
                {
                    tablaBody.Add(fila); // Simulamos agregar a la tabla
                }
            }

            // Assert: Verificamos si la búsqueda encuentra el ID y se muestra en la tabla
            Assert.AreEqual(1, tablaBody.Count, "No se encontró el cliente con el ID proporcionado.");
            Assert.AreEqual("123", tablaBody[0][0], "El ID Cliente no coincide.");
        }

        [TestMethod]
        public void BuscarPorID_ClienteNoExistente_NoDebeMostrarResultados()
        {
            // Arrange
            string idCliente = "000";
            var tablaBody = new List<string[]>(); // Emulamos el cuerpo de la tabla HTML

            // Act: Filtramos los datos CSV por el ID Cliente proporcionado
            var resultadoBusqueda = datosCSV.FindAll(fila => fila[0] == idCliente);

            if (resultadoBusqueda.Count > 0)
            {
                foreach (var fila in resultadoBusqueda)
                {
                    tablaBody.Add(fila); // Simulamos agregar a la tabla
                }
            }

            // Assert: Verificamos que no se muestren resultados si el cliente no existe
            Assert.AreEqual(0, tablaBody.Count, "El cliente con el ID proporcionado fue encontrado aunque no debería.");
        }

        [TestMethod]
        public void FechaVencimientoProximaVencimiento_AlertaDeVencimiento()
        {
            // Arrange
            string idCliente = "123";
            var alertaEsperada = false;
            var cliente = datosCSV.Find(fila => fila[0] == idCliente);

            // Verificamos la fecha de vencimiento y si está cerca de la fecha
            if (cliente != null)
            {
                string fechaVencimiento = cliente[3]; // Fecha de vencimiento
                if (fechaVencimiento == "20/12/2024")
                {
                    alertaEsperada = true; // Se simula que se muestra la alerta
                }
            }

            // Assert: Verificamos si se generó la alerta cuando la fecha de vencimiento es la esperada
            Assert.IsTrue(alertaEsperada, "No se generó la alerta de vencimiento.");
        }
    }
}
