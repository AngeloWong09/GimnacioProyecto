namespace AuthTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    namespace Test
    {
        [TestClass]
        public class CSVTableTests
        {
            private List<string[]> datosCSV;

            [TestInitialize]
            public void Setup()
            {
                // Datos CSV simulados
                datosCSV = new List<string[]>
            {
                new string[] { "Usuario1", "pass123", "John", "Doe", "1001" },
                new string[] { "Usuario2", "abc123", "Jane", "Smith", "1002" }
            };
            }

            [TestMethod]
            public void Test_ProcesarCSVTexto_ValidarColumnas()
            {
                // Simula el texto del CSV
                string textoCSV = "Usuario;Contraseña;Nombre;Apellido;ID\n" +
                                  "Usuario1;pass123;John;Doe;1001\n" +
                                  "Usuario2;abc123;Jane;Smith;1002";

                // Simula procesamiento
                var lineas = textoCSV.Split("\n");
                var encabezado = lineas[0];
                var datos = new List<string[]>();

                for (int i = 1; i < lineas.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(lineas[i]))
                    {
                        datos.Add(lineas[i].Split(";"));
                    }
                }

                // Verificación
                Assert.AreEqual(2, datos.Count, "La cantidad de filas debería ser 2.");
                Assert.AreEqual("Usuario1", datos[0][0], "El primer usuario debería ser 'Usuario1'.");
                Assert.AreEqual("Doe", datos[0][3], "El apellido del primer usuario debería ser 'Doe'.");
                Assert.AreEqual("abc123", datos[1][1], "La contraseña del segundo usuario debería ser 'abc123'.");
            }

            [TestMethod]
            public void Test_GuardarCambios_ModificaFilaCorrecta()
            {
                // Simula la fila editada
                var filaEditada = new string[] { "Usuario1", "newPass", "John", "Doe", "1001" };

                // Encuentra y actualiza la fila correspondiente
                for (int i = 0; i < datosCSV.Count; i++)
                {
                    if (datosCSV[i][4] == filaEditada[4]) // Busca por ID
                    {
                        datosCSV[i] = filaEditada;
                        break;
                    }
                }

                // Verificación
                Assert.AreEqual("newPass", datosCSV[0][1], "La contraseña debería haber sido actualizada a 'newPass'.");
            }
        }
    }


}