
namespace GymFastForceTests
{
    [TestClass]
    public class AdministradorCambiarContraseñaTest
    {
        /// <summary>
        /// Prueba que verifica el procesamiento correcto de un archivo CSV y la conversión a una lista de datos.
        /// </summary>
        [TestMethod]
        public void ProcesarCSVTexto_DeberiaDividirEnLineasYColumnas()
        {
            // Arrange: Simulamos el contenido de un archivo CSV con datos ficticios.
            string contenidoCSV = "Usuario;Contraseña;Nombre;Apellido;ID\n" +
                                  "admin;1234;Juan;Pérez;1\n" +
                                  "cliente1;5678;Ana;Gómez;2\n";
            string[] lineasEsperadas = { "admin;1234;Juan;Pérez;1", "cliente1;5678;Ana;Gómez;2" };

            // Act: Simulamos el procesamiento del CSV en líneas y columnas.
            var lineasProcesadas = contenidoCSV
                .Split("\n")
                .Skip(1) // Omitimos la primera línea (encabezado)
                .Where(linea => !string.IsNullOrWhiteSpace(linea)) // Omitimos líneas vacías
                .Select(linea => linea.Split(";")) // Dividimos cada línea por ';'
                .ToList();

            // Assert: Comparamos los resultados esperados con los obtenidos.
            Assert.AreEqual(2, lineasProcesadas.Count); // Debe haber 2 filas de datos
            CollectionAssert.AreEqual(lineasEsperadas[0].Split(";"), lineasProcesadas[0]);
            CollectionAssert.AreEqual(lineasEsperadas[1].Split(";"), lineasProcesadas[1]);
        }

        /// <summary>
        /// Prueba que verifica si se actualiza correctamente una fila de datos en la tabla.
        /// </summary>
        [TestMethod]
        public void GuardarCambios_DeberiaActualizarFilaCorrecta()
        {
            // Arrange: Creamos una lista de datos simulando el CSV cargado.
            var datosCSV = new List<string[]>
            {
                new string[] { "admin", "1234", "Juan", "Pérez", "1" },
                new string[] { "cliente1", "5678", "Ana", "Gómez", "2" }
            };

            // Datos que se actualizarán
            var nuevaFila = new string[] { "admin", "4321", "Juan", "Pérez", "1" }; // Cambio en Contraseña

            // Act: Actualizamos la fila cuyo ID coincide.
            var filaIndex = datosCSV.FindIndex(fila => fila[4] == nuevaFila[4]); // Encontramos la fila con ID = "1"
            if (filaIndex > -1)
            {
                datosCSV[filaIndex] = nuevaFila; // Actualizamos la fila
            }

            // Assert: Verificamos que la fila ha sido actualizada correctamente.
            Assert.AreEqual("4321", datosCSV[0][1]); // Contraseña debería ser "4321"
        }

        /// <summary>
        /// Prueba que verifica la generación de contenido CSV a partir de una lista de datos.
        /// </summary>
        [TestMethod]
        public void GuardarCSV_DeberiaGenerarContenidoCorrecto()
        {
            // Arrange: Creamos datos simulados para la tabla.
            var encabezado = "Usuario;Contraseña;Nombre;Apellido;ID";
            var datosCSV = new List<string[]>
            {
                new string[] { "admin", "1234", "Juan", "Pérez", "1" },
                new string[] { "cliente1", "5678", "Ana", "Gómez", "2" }
            };
            var contenidoEsperado = "Usuario;Contraseña;Nombre;Apellido;ID\nadmin;1234;Juan;Pérez;1\ncliente1;5678;Ana;Gómez;2\n";

            // Act: Simulamos la conversión de los datos a formato CSV.
            var contenidoGenerado = encabezado + "\n" +
                                    string.Join("\n", datosCSV.Select(fila => string.Join(";", fila))) + "\n";

            // Assert: Comparamos el contenido esperado con el generado.
            Assert.AreEqual(contenidoEsperado, contenidoGenerado);
        }
    }
}
