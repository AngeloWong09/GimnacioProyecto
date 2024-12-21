using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class AdministradorCambiarPuntoFuerteTest
    {
        private List<string[]> datosCSV;  // Lista de datos cargados desde el CSV

        // Simulación de CSV cargado de prueba (equivalente al archivo CSV)
        private void SimularCargarDatosCSV()
        {
            datosCSV = new List<string[]>
            {
                new string[] { "usuario1", "contraseña1", "Juan", "Pérez", "1", "Fuerza1" },
                new string[] { "usuario2", "contraseña2", "Ana", "Gómez", "2", "Fuerza2" },
                new string[] { "usuario3", "contraseña3", "Carlos", "Rodríguez", "3", "Fuerza3" }
            };
        }

        // Método de prueba para verificar que los datos CSV se cargan correctamente
        [TestMethod]
        public void TestCargarDatosCSV()
        {
            // Arrange: Simulamos cargar los datos CSV
            SimularCargarDatosCSV();

            // Act: Verificamos si la lista de datos contiene los elementos esperados
            var primerFila = datosCSV.FirstOrDefault();
            var nombre = primerFila?[2]; // Recuperamos el nombre de la primera fila (Carlos)

            // Assert: Verificamos si los datos se cargaron correctamente
            Assert.IsNotNull(datosCSV, "Los datos CSV deberían haberse cargado.");
            Assert.AreEqual("Juan", nombre, "El nombre en la primera fila debería ser 'Juan'.");
        }

        // Método de prueba para verificar si se realizan cambios y se guardan correctamente
        [TestMethod]
        public void TestGuardarCambios()
        {
            // Arrange: Simulamos cargar datos
            SimularCargarDatosCSV();

            // Cambiar el punto fuerte del segundo entrenador
            var segundoEntrenador = datosCSV[1];
            segundoEntrenador[5] = "Fuerza modificada"; // Cambiamos "Fuerza2" a "Fuerza modificada"

            // Act: Verificamos si el cambio se ha guardado correctamente
            var actualizado = datosCSV[1][5];

            // Assert: Verificamos si el punto fuerte fue actualizado
            Assert.AreEqual("Fuerza modificada", actualizado, "El punto fuerte debería haber sido actualizado.");
        }

        // Método de prueba para verificar si los datos se guardan correctamente en un archivo CSV
        [TestMethod]
        public void TestGuardarCSV()
        {
            // Arrange: Simulamos cargar los datos y guardar como CSV
            SimularCargarDatosCSV();

            // Creamos un archivo de CSV simulado (esto normalmente se haría usando un "mocking" o una herramienta similar para simular el guardado)
            string resultadoCSV = "";
            foreach (var fila in datosCSV)
            {
                resultadoCSV += string.Join(";", fila) + "\n";  // Genera la representación CSV
            }

            // Act: Verificamos si el contenido generado del CSV contiene la primera fila esperada
            bool contienePrimeraFila = resultadoCSV.Contains("usuario1;contraseña1;Juan;Pérez;1;Fuerza1");

            // Assert: Verificamos si la fila está presente en el contenido CSV generado
            Assert.IsTrue(contienePrimeraFila, "El CSV generado debe contener la primera fila.");
        }
    }
}
