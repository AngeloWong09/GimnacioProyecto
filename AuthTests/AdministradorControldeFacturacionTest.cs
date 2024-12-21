using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class AdministradorControlFacturacionTest
    {
        /// <summary>
        /// Test para la funcionalidad de filtrar pagos por mes.
        /// </summary>
        [TestMethod]
        public void FiltrarPagosPorMes_Test()
        {
            // Arrange: datos de ejemplo
            var pagos = new List<List<string>>()
        {
            new List<string> { "F001", "1", "Enero 2024", "100", "01/01/2024", "15/01/2024", "Pagada", "CardioDance" },
            new List<string> { "F002", "2", "Febrero 2024", "150", "01/02/2024", "15/02/2024", "Pendiente", "Spinning" },
            new List<string> { "F003", "1", "Enero 2024", "200", "01/01/2024", "15/01/2024", "Pagada", "Yoga" }
        };

            // Act: Filtrar pagos para el mes de "Enero 2024"
            var mesFiltro = "Enero 2024";
            var pagosFiltrados = FiltrarPagosPorMes(pagos, mesFiltro);

            // Assert: Verificar que solo los pagos de "Enero 2024" están en los resultados filtrados
            Assert.AreEqual(2, pagosFiltrados.Count);
            Assert.IsTrue(pagosFiltrados.TrueForAll(pago => pago[2].Contains("Enero 2024")));
        }

        /// <summary>
        /// Función que simula la lógica de filtrado por mes.
        /// </summary>
        public List<List<string>> FiltrarPagosPorMes(List<List<string>> pagos, string mes)
        {
            if (string.IsNullOrEmpty(mes))
            {
                return pagos;
            }
            else
            {
                return pagos.FindAll(pago => pago[2].Contains(mes));
            }
        }
    }
}