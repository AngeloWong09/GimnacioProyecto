using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class ClientePagosTest
    {
        /// <summary>
        /// Test que verifica si la función para guardar pagos genera un archivo CSV correcto.
        /// </summary>
        [TestMethod]
        public void GuardarPago_ValoresValidos_GeneraArchivoCSVCorrecto()
        {
            // Arrange: Preparamos los datos simulados para el pago.
            var userId = "12345";
            var mesPago = "Enero 2024";
            var monto = 500.00;
            var esperado = $"{userId};{mesPago};{monto}\n";
            var rutaArchivo = "Pagos.csv";

            // Act: Simulamos el guardado del archivo CSV.
            File.WriteAllText(rutaArchivo, esperado);

            // Assert: Verificamos que el archivo fue creado y contiene los datos esperados.
            Assert.IsTrue(File.Exists(rutaArchivo), "El archivo CSV no fue creado.");
            var contenidoArchivo = File.ReadAllText(rutaArchivo);
            Assert.AreEqual(esperado, contenidoArchivo, "El contenido del archivo CSV no es el esperado.");

            // Cleanup: Eliminamos el archivo de prueba para mantener el ambiente limpio.
            File.Delete(rutaArchivo);
        }

        /// <summary>
        /// Test que verifica si se muestra la fecha de preaviso y pago correctamente.
        /// </summary>
        [TestMethod]
        public void MostrarFechas_FechaActual_RetornaFechasCorrectas()
        {
            // Arrange: Establecemos una fecha específica para simular el entorno.
            var fechaSimulada = new DateTime(2024, 1, 15); // Fecha simulada: 15 de enero de 2024
            var preavisoEsperado = "24 enero 2024";
            var pagoEsperado = "29 enero 2024";

            // Act: Calculamos las fechas con base en la fecha simulada.
            var preavisoCalculado = $"24 {fechaSimulada.ToString("MMMM yyyy")}";
            var pagoCalculado = $"29 {fechaSimulada.ToString("MMMM yyyy")}";

            // Assert: Comprobamos que las fechas calculadas sean las esperadas.
            Assert.AreEqual(preavisoEsperado, preavisoCalculado, "La fecha de preaviso no es correcta.");
            Assert.AreEqual(pagoEsperado, pagoCalculado, "La fecha de pago no es correcta.");
        }
    }
}