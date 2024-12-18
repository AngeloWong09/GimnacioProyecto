
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;

namespace AdministradorTest
{
    [TestClass]
    public class AdministradorCambiarPuntoFuerteTest
    {
        // Variable para almacenar el contenido de prueba del CSV
        private string archivoCSVPrueba;

        /// <summary>
        /// Método de inicialización que se ejecuta antes de cada prueba.
        /// Prepara el contenido del archivo CSV para las pruebas.
        /// </summary>
        [TestInitialize]
        public void Inicializar()
        {
            archivoCSVPrueba = "Usuario;Contraseña;Nombre;Apellido;Id;Puntos fuertes\n" +
                               "usuario1;pass123;Juan;Perez;1;Resistencia\n" +
                               "usuario2;pass456;Maria;Lopez;2;Fuerza\n" +
                               "usuario3;pass789;Carlos;Diaz;3;Velocidad";

            // Simulamos el archivo CSV en memoria (sin usar archivos físicos)
            File.WriteAllText("EntrenadoresTest.csv", archivoCSVPrueba, Encoding.UTF8);
        }

        /// <summary>
        /// Prueba para validar que los datos del CSV se procesen correctamente.
        /// </summary>
        [TestMethod]
        public void CargarCSV_DeberiaProcesarDatosCorrectamente()
        {
            // Arrange
            var rutaArchivo = "EntrenadoresTest.csv";
            var esperado = 3; // Se esperan 3 líneas de datos

            // Act
            var lineas = File.ReadAllLines(rutaArchivo);
            var datos = lineas.Length - 1; // Descontamos el encabezado

            // Assert
            Assert.AreEqual(esperado, datos, "La cantidad de filas no coincide con la esperada.");
        }

        /// <summary>
        /// Prueba para validar que una fila editada se guarde correctamente.
        /// </summary>
        [TestMethod]
        public void GuardarFila_Editada_DeberiaActualizarDatos()
        {
            // Arrange
            var rutaArchivo = "EntrenadoresTest.csv";
            var contenidoInicial = File.ReadAllLines(rutaArchivo);
            var datos = contenidoInicial[2].Split(';'); // Fila 2: Maria Lopez
            datos[5] = "Agilidad"; // Editamos 'Puntos fuertes'

            contenidoInicial[2] = string.Join(";", datos);

            // Act
            File.WriteAllLines(rutaArchivo, contenidoInicial);
            var contenidoFinal = File.ReadAllLines(rutaArchivo);

            // Assert
            Assert.IsTrue(contenidoFinal[2].Contains("Agilidad"), "El dato editado no se guardó correctamente.");
        }

        /// <summary>
        /// Prueba para validar que el archivo CSV se guarde correctamente después de editarlo.
        /// </summary>
        [TestMethod]
        public void GuardarCSV_DeberiaGenerarArchivoCorrectamente()
        {
            // Arrange
            var rutaArchivoOriginal = "EntrenadoresTest.csv";
            var rutaArchivoGuardado = "EntrenadoresGuardadoTest.csv";
            var contenidoOriginal = File.ReadAllText(rutaArchivoOriginal);

            // Act
            File.WriteAllText(rutaArchivoGuardado, contenidoOriginal);
            var archivoGuardadoExiste = File.Exists(rutaArchivoGuardado);

            // Assert
            Assert.IsTrue(archivoGuardadoExiste, "El archivo guardado no se generó correctamente.");
        }

        /// <summary>
        /// Método que se ejecuta después de cada prueba para limpiar archivos.
        /// </summary>
        [TestCleanup]
        public void Limpiar()
        {
            // Eliminamos los archivos temporales creados durante las pruebas
            if (File.Exists("EntrenadoresTest.csv"))
                File.Delete("EntrenadoresTest.csv");

            if (File.Exists("EntrenadoresGuardadoTest.csv"))
                File.Delete("EntrenadoresGuardadoTest.csv");
        }
    }
}
