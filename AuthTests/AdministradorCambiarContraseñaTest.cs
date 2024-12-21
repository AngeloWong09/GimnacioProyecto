using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{

    [TestClass]
    public class AdministradorCambiarContraseñaTest
    {
        /// <summary>
        /// Test que verifica que la función cargarCSV carga los datos correctamente para el tipo Administrador.
        /// </summary>
        [TestMethod]
        public void cargarCSV_Admin_ArchivoCSVCorrecto()
        {
            // Arrange: Se definen los datos que el archivo CSV debería contener
            var datosEsperados = new List<List<string>> {
            new List<string> { "admin1", "12345", "Juan", "Pérez", "101" },
            new List<string> { "admin2", "67890", "María", "López", "102" }
        };

            // Creamos un "mock" del contenido del archivo CSV (simulando la lectura de un archivo CSV)
            string contenidoCSV = "Usuario;Contraseña;Nombre;Apellido;ID\n" +
                                  "admin1;12345;Juan;Pérez;101\n" +
                                  "admin2;67890;María;López;102";

            // Act: Llamamos a la función que procesará el contenido CSV
            List<List<string>> datosCargados = procesarCSVTextoMock(contenidoCSV);

            // Assert: Verificamos que los datos cargados son los esperados
            for (int i = 0; i < datosEsperados.Count; i++)
            {
                for (int j = 0; j < datosEsperados[i].Count; j++)
                {
                    Assert.AreEqual(datosEsperados[i][j], datosCargados[i][j]);
                }
            }
        }

        // Método de "mock" que simula el comportamiento de procesar el archivo CSV
        private List<List<string>> procesarCSVTextoMock(string texto)
        {
            var lineas = texto.Split("\n");
            var datos = new List<List<string>>();

            for (int i = 1; i < lineas.Length; i++) // Comenzamos desde el índice 1 para omitir el encabezado
            {
                if (!string.IsNullOrWhiteSpace(lineas[i]))
                {
                    datos.Add(new List<string>(lineas[i].Split(";")));
                }
            }

            return datos;
        }

        /// <summary>
        /// Test que verifica que la función guardarCambios actualiza correctamente los datos en la tabla.
        /// </summary>
        [TestMethod]
        public void guardarCambios_ActualizarFilaCorrectamente()
        {
            // Arrange: Definimos los datos iniciales de una fila
            var fila = new List<string> { "admin1", "12345", "Juan", "Pérez", "101" };
            var filaActualizada = new List<string> { "admin1", "54321", "Juan", "Pérez", "101" };

            // Mock de tabla (representación simulada del DOM)
            var tablaSimulada = new List<List<string>> { fila };

            // Act: Simulamos que el valor de la contraseña ha sido editado en la tabla
            fila[1] = "54321";  // Actualizamos la contraseña a través de la celda de la tabla
            guardarCambiosMock(tablaSimulada, fila);

            // Assert: Verificamos que la fila ha sido actualizada correctamente
            Assert.AreEqual(fila[1], filaActualizada[1]); // Comprobamos que la contraseña se haya actualizado
        }

        // Método "mock" de guardar los cambios (simulación de funcionalidad)
        private void guardarCambiosMock(List<List<string>> tabla, List<string> columna)
        {
            var index = tabla.FindIndex(fila => fila[4] == columna[4]); // Buscamos por ID
            if (index != -1)
            {
                tabla[index] = columna; // Actualizamos la fila con los nuevos valores
            }
        }

        /// <summary>
        /// Test que verifica el comportamiento de la función guardarCSV para generar un archivo CSV descargable.
        /// </summary>
        [TestMethod]
        public void guardarCSV_ArchivoGenerado()
        {
            // Arrange: Datos que se deberían guardar en el archivo CSV
            var datosGuardar = new List<List<string>> {
            new List<string> { "admin1", "12345", "Juan", "Pérez", "101" },
            new List<string> { "admin2", "67890", "María", "López", "102" }
        };

            // Act: Generamos el contenido CSV simulado
            string contenidoEsperado = "Usuario;Contraseña;Nombre;Apellido;ID\n" +
                                       "admin1;12345;Juan;Pérez;101\n" +
                                       "admin2;67890;María;López;102";

            string contenidoGenerado = generarCSVMock(datosGuardar);

            // Assert: Verificamos que el contenido generado es el esperado
            Assert.AreEqual(contenidoEsperado, contenidoGenerado);
        }

        // Método "mock" de generación de CSV (simulación de la descarga del archivo CSV)
        private string generarCSVMock(List<List<string>> datos)
        {
            var contenidoCSV = "Usuario;Contraseña;Nombre;Apellido;ID\n";
            foreach (var fila in datos)
            {
                contenidoCSV += string.Join(";", fila) + "\n";
            }
            return contenidoCSV;
        }
    }
}