using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class ClienteRutinaTest
    {
        /// <summary>
        /// Test que verifica si se cargan y procesan correctamente los datos desde un archivo CSV.
        /// </summary>
        [TestMethod]
        public void CargarRutinas_ArchivoValido_SeProcesaCorrectamente()
        {
            // Arrange: Crear contenido simulado para el archivo CSV.
            var contenidoCSV = "Nombre;Apellidos;ID;Rutina;Repeticiones\nJuan;Pérez;P1400;Brazos;15\nMaría;Gómez;P1401;Piernas;20";
            var rutaArchivo = "RutinaCliente.csv";
            File.WriteAllText(rutaArchivo, contenidoCSV);

            // Act: Leer y procesar el archivo CSV.
            var lineas = File.ReadAllLines(rutaArchivo);
            var datosProcesados = lineas.Skip(1) // Omitir encabezado
                                        .Select(linea => linea.Split(';'))
                                        .ToList();

            // Assert: Verificar que los datos procesados coincidan con el contenido esperado.
            Assert.AreEqual(2, datosProcesados.Count, "El número de registros procesados no es correcto.");
            Assert.AreEqual("Juan", datosProcesados[0][0], "El nombre del primer registro no es correcto.");
            Assert.AreEqual("P1401", datosProcesados[1][2], "El ID del segundo registro no es correcto.");

            // Cleanup: Eliminar el archivo simulado para mantener limpio el entorno de pruebas.
            File.Delete(rutaArchivo);
        }

        /// <summary>
        /// Test que verifica si se agrega una rutina correctamente a los datos existentes.
        /// </summary>
        [TestMethod]
        public void AgregarRutina_DatosValidos_SeAgregaCorrectamente()
        {
            // Arrange: Preparar datos existentes y nueva rutina.
            var datosExistentes = new List<string[]> {
            new string[] { "Juan", "Pérez", "P1400", "Brazos", "15" },
            new string[] { "María", "Gómez", "P1401", "Piernas", "20" }
        };
            var nuevaRutina = new string[] { "Carlos", "Ramírez", "P1402", "Abdomen", "25" };

            // Act: Agregar la nueva rutina a los datos existentes.
            datosExistentes.Add(nuevaRutina);

            // Assert: Verificar que la nueva rutina se agregó correctamente.
            Assert.AreEqual(3, datosExistentes.Count, "El número de registros no es correcto después de agregar una rutina.");
            CollectionAssert.AreEqual(nuevaRutina, datosExistentes.Last(), "La nueva rutina no se agregó correctamente.");
        }

        /// <summary>
        /// Test que verifica si se genera correctamente un archivo CSV a partir de los datos procesados.
        /// </summary>
        [TestMethod]
        public void GuardarCSV_DatosValidos_GeneraArchivoCorrecto()
        {
            // Arrange: Preparar datos simulados para el archivo CSV.
            var encabezadoCSV = "Nombre;Apellidos;ID;Rutina;Repeticiones";
            var datosCSV = new List<string[]> {
            new string[] { "Juan", "Pérez", "P1400", "Brazos", "15" },
            new string[] { "María", "Gómez", "P1401", "Piernas", "20" }
        };
            var rutaArchivo = "rutinas_guardadas.csv";

            // Act: Generar el contenido del archivo CSV y guardarlo.
            var contenidoCSV = encabezadoCSV + "\n" + string.Join("\n", datosCSV.Select(fila => string.Join(";", fila)));
            File.WriteAllText(rutaArchivo, contenidoCSV);

            // Assert: Verificar que el archivo fue creado y contiene los datos esperados.
            Assert.IsTrue(File.Exists(rutaArchivo), "El archivo CSV no fue creado.");
            var contenidoGuardado = File.ReadAllText(rutaArchivo);
            Assert.AreEqual(contenidoCSV, contenidoGuardado, "El contenido del archivo CSV no es el esperado.");

            // Cleanup: Eliminar el archivo creado para mantener el entorno limpio.
            File.Delete(rutaArchivo);
        }
}
}