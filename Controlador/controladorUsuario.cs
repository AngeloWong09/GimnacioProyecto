using System.Linq;
using ClosedXML.Excel;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Proyecto1.Controlador
{
    internal class controladorUsuario
    {
        private List<usuarioModelo> usuarios;

        public controladorUsuario()
        {
            usuarios = new List<usuarioModelo>();
            CargarUsuariosDesdeCSV("Assets/Usuarios.csv");
        }

        private void CargarUsuariosDesdeCSV(string rutaArchivo)

        {

            string rutaUsuarioArchivo = @"Assets\Usuario.csv"; // Ruta al archivo Usuario.csv
            if (File.Exists(rutaArchivo))
            {
                foreach (var linea in File.ReadAllLines(rutaArchivo))
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue; // Ignorar líneas vacías

                    string[] valores = linea.Split(';'); // Separar valores usando ';'

                    if (valores.Length >= 8) // Validar que haya al menos 8 columnas
                    {
                        string nombreUsuario = valores[0].Trim();   // Columna Usuario
                        string contraseña = valores[1].Trim();     // Columna Contraseña
                        string nombre = valores[2].Trim();         // Columna Nombre
                        string apellido1 = valores[3].Trim();      // Columna Apellido 1
                        string apellido2 = valores[4].Trim();      // Columna Apellido 2
                        int id = int.TryParse(valores[5].Trim(), out int tempId) ? tempId : 0; // Convertir ID a entero
                        string membresia = valores[6].Trim();      // Columna Membresía
                        string claseId = valores[7].Trim();        // Columna Clase ID

                        usuarios.Add(new usuarioModelo(
                            nombreUsuario,
                            contraseña,
                            "Usuario",     // Rol predeterminado
                            nombre,
                            apellido1,
                            apellido2,
                            id,
                            membresia,
                            "",            // UsuarioID no se provee en el CSV
                            claseId
                        ));
                    }
                }
            }
        }

        public usuarioModelo IniciarSesion(string nombreUsuario, string contraseña)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase) &&
                    usuario.VerificarContraseña(contraseña))
                {
                    return usuario;
                }
            }
            return null; // No se encontró un usuario con las credenciales dadas
        }

    }
}



