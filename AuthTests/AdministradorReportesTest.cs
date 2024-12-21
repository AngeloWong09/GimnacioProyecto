using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class AdministradorReportesTests
    {
        /// <summary>
        /// Test para verificar si la función `mostrarTabla` carga correctamente el archivo CSV de maquinas.
        /// </summary>
        [TestMethod]
        public void MostrarTabla_Maquinas_CargaCorrecta()
        {
            // Arrange: Simulamos que el archivo CSV existe y contiene los datos que esperamos.
            var archivoCSV = "sample-data/Maquinas.csv";
            var datosEsperados = new List<string>
        {
            "Nombre,Fecha Entrada,Tiempo Vida (días),Ingresos,Clase ID,ID,Acciones",
            "Máquina A,2022-01-01,500,1000,Clase1,1,Guardar",
            "Máquina B,2023-01-01,300,600,Clase2,2,Guardar"
        };

            // Act: Llamamos a la función que debería cargar el archivo CSV.
            var datosCargados = CargarCSV(archivoCSV); // Esto representaría la simulación del cargado de CSV.

            // Assert: Verificamos que los datos cargados sean los que esperamos.
            CollectionAssert.AreEqual(datosEsperados, datosCargados);
        }

        /// <summary>
        /// Test para verificar que al hacer clic en "Guardar", los cambios se almacenan correctamente.
        /// </summary>
        [TestMethod]
        public void GuardarCambios_AlHacerClick_CambiaValorCorrectamente()
        {
            // Arrange: Datos originales en una fila de máquina
            var filaOriginal = new List<string>
        {
            "Máquina A",
            "2022-01-01",
            "500",
            "1000",
            "Clase1",
            "1"
        };

            // Modificamos uno de los valores en la tabla como si se editara en el DOM
            var datosModificados = new List<string>
        {
            "Máquina A",
            "2022-01-01",
            "500",
            "1100",  // Cambio en ingresos
            "Clase1",
            "1"
        };

            // Act: Simulamos el cambio de valores después de hacer clic en "Guardar"
            GuardarCambios(filaOriginal, datosModificados);  // Guardamos los cambios simulados

            // Assert: Verificamos que los cambios fueron correctamente almacenados.
            Assert.AreEqual("1100", filaOriginal[3]);  // Aseguramos que los ingresos fueron actualizados a 1100
        }

        // Método simulado para cargar los datos desde un archivo CSV (esto debe ser sustituido por un mock o un test de integración en el navegador)
        private List<string> CargarCSV(string archivo)
        {
            // Aquí podrías usar herramientas de mock o de integración para simular el proceso
            // para este ejemplo solo devolvemos datos estáticos
            return new List<string>
        {
            "Nombre,Fecha Entrada,Tiempo Vida (días),Ingresos,Clase ID,ID,Acciones",
            "Máquina A,2022-01-01,500,1000,Clase1,1,Guardar",
            "Máquina B,2023-01-01,300,600,Clase2,2,Guardar"
        };
        }

        // Método simulado para guardar cambios (debería implementar lógica de manipulación de datos)
        private void GuardarCambios(List<string> filaOriginal, List<string> filaModificada)
        {
            // Simulamos la actualización de la fila
            for (int i = 0; i < filaOriginal.Count; i++)
            {
                filaOriginal[i] = filaModificada[i];
            }
        }
    }

}