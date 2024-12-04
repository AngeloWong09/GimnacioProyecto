
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto1.Controlador
{
    internal class controladorUsuario
    {
        /// <summary>
        /// Controlador que gestiona los usuarios en el sistema
        /// Cargar usuarios desde un archivo Usuarios.csv y realizar operaciones como autenticación
        /// </summary>
        private List<usuarioModelo> usuarios; 

        /// <summary>
        /// Constructor de la clase controladorUsuario
        /// Inicializa la lista de usuarios y los carga desde Usuarios.csv
        /// </summary>
        public controladorUsuario()
        {
            usuarios = new List<usuarioModelo>();
            CargarUsuariosDesdeCSV("Assets/Usuarios.csv"); 
        }

        /// <summary>
        /// Método privado que carga usuarios desde un archivo CSV.
        /// </summary>
        private void CargarUsuariosDesdeCSV(string rutaArchivo)
        {

            // Verifica si el archivo existe antes de proceder.
            if (File.Exists(rutaArchivo))
            {
                // Lee todas las líneas del archivo.
                foreach (var linea in File.ReadAllLines(rutaArchivo))
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue; // Ignora líneas vacías.

                    // Divide la línea en columnas usando el carácter ';'.
                    string[] valores = linea.Split(';');

                    // Verifica si hay al menos 8 columnas para procesar la información.
                    if (valores.Length >= 8)
                    {
                        // Asigna valores a las propiedades del modelo de usuario.
                        string nombreUsuario = valores[0].Trim();   // Nombre de usuario.
                        string contraseña = valores[1].Trim();     // Contraseña del usuario.
                        string nombre = valores[2].Trim();         // Nombre del usuario.
                        string apellido1 = valores[3].Trim();      // Primer apellido.
                        string apellido2 = valores[4].Trim();      // Segundo apellido.
                        int id = int.TryParse(valores[5].Trim(), out int tempId) ? tempId : 0; // ID convertido a entero.
                        string membresia = valores[6].Trim();      // Tipo de membresía.
                        string claseId = valores[7].Trim();        // ID de la clase.

                        // Agrega un nuevo usuario a la lista utilizando el modelo usuarioModelo.
                        usuarios.Add(new usuarioModelo(
                            nombreUsuario,
                            contraseña,
                            "Usuario",     
                            nombre,
                            apellido1,
                            apellido2,
                            id,
                            membresia,
                            "",            
                            claseId
                        ));
                    }
                }
            }
        }

        /// <summary>
        /// Método público que permite autenticar a un usuario.
        /// Verifica si las credenciales proporcionadas coinciden con las de un usuario existente.
        /// </summary>
        /// <returns>
        /// Si lo escrito es correcto lo deja acceder. De no ser devuelve null.
        /// </returns>
        public usuarioModelo IniciarSesion(string nombreUsuario, string contraseña)
        {
            // Recorre la lista de usuarios para buscar coincidencias.
            foreach (var usuario in usuarios)
            {
                if (usuario.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase) &&
                    usuario.VerificarContraseña(contraseña)) // Verifica si la contraseña coincide.
                {
                    return usuario; // Retorna el usuario autenticado.
                }
            }

            return null; 
        }

    }
}



