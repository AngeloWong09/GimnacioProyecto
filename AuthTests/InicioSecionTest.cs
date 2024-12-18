namespace AuthTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    namespace Test
    {
        [TestClass]
        public class InicioSecionTest
        {
            private List<string[]> administradores;
            private List<string[]> entrenadores;
            private List<string[]> clientes;

            [TestInitialize]
            public void Setup()
            {
                // Simulando datos CSV
                administradores = new List<string[]>
            {
                new string[] { "admin", "1234" }
            };

                entrenadores = new List<string[]>
            {
                new string[] { "entrenador1", "abcd" }
            };

                clientes = new List<string[]>
            {
                new string[] { "cliente1", "pass123" }
            };
            }

            [TestMethod]
            public void Test_Login_Administrador_Exitoso()
            {
                string user = "admin";
                string password = "1234";

                bool resultado = LoginValido(user, password, administradores);

                Assert.IsTrue(resultado, "El administrador debería poder iniciar sesión.");
            }

            [TestMethod]
            public void Test_Login_Entrenador_Invalido()
            {
                string user = "entrenador1";
                string password = "wrong";

                bool resultado = LoginValido(user, password, entrenadores);

                Assert.IsFalse(resultado, "El inicio de sesión debería fallar con contraseña incorrecta.");
            }

            private bool LoginValido(string user, string password, List<string[]> data)
            {
                return data.Exists(fila => fila[0] == user && fila[1] == password);
            }
        }
    }

}