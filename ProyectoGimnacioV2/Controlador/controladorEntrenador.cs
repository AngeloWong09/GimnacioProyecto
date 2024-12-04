using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto1.Controlador
{
    internal class controladorEntrenador
    {
        private List<entrenadorModelo> entrenadores;

        public controladorEntrenador()
        {
            entrenadores = new List<entrenadorModelo>();
            CargarEntrenadoresDesdeCSV("Assets/Entrenadores.csv");  // Cambié a CSV
        }

        private void CargarEntrenadoresDesdeCSV(string rutaArchivo)
        {

            string rutaCompleta = ObtenerRutaCompletaDelArchivo(rutaArchivo);

            if (!ArchivoExiste(rutaCompleta))
            {
                MostrarError($"El archivo {rutaArchivo} no existe.");
                return;
            }

            ProcesarArchivoCSV(rutaCompleta);
        }

        /// <summary>
        /// Obtiene la ruta completa del archivo.
        /// </summary>
        private string ObtenerRutaCompletaDelArchivo(string rutaArchivo)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaArchivo);
        }

        /// <summary>
        /// Verifica si el archivo existe.
        /// </summary>
        private bool ArchivoExiste(string rutaArchivo)
        {
            return File.Exists(rutaArchivo);
        }

        /// <summary>
        /// Procesa el archivo CSV y carga los datos de los entrenadores.
        /// </summary>
        private void ProcesarArchivoCSV(string rutaArchivo)
        {
            try
            {
                using (var reader = new StreamReader(rutaArchivo))
                {
                    bool esPrimeraLinea = true;

                    while (reader.ReadLine() is string linea)
                    {
                        if (esPrimeraLinea) // Ignorar la primera línea del encabezado
                        {
                            esPrimeraLinea = false;
                            continue;
                        }

                        ProcesarLinea(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError($"Error al cargar entrenadores desde CSV: {ex.Message}");
            }
        }

        /// <summary>
        /// Procesa una línea del archivo CSV y agrega un entrenador a la lista.
        /// </summary>
        private void ProcesarLinea(string linea)
        {
            var valores = linea.Split(';'); // Separador en CSV

            if (valores.Length < 6) return; // Verificar que hay suficientes columnas

            if (int.TryParse(valores[4].Trim(), out int id))
            {
                CrearEntrenador(valores, id);
            }
            else
            {
                MostrarError($"ID no válido en la línea: {linea}");
            }
        }

        /// <summary>
        /// Crea un objeto entrenadorModelo y lo agrega a la lista.
        /// </summary>
        private void CrearEntrenador(string[] valores, int id)
        {
            var entrenador = new entrenadorModelo(
                valores[0].Trim(),  // Nombre de usuario
                valores[1].Trim(),  // Contraseña
                valores[2].Trim(),  // Nombre
                valores[3].Trim(),  // Apellido
                id,                 // ID
                valores[5].Trim()   // Puntos fuertes
            );

            entrenadores.Add(entrenador);
        }

        /// <summary>
        /// Muestra un mensaje de error al usuario.
        /// </summary>
        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error");
        }

        /// <summary>
        /// Inicia sesión verificando el nombre de usuario y contraseña del entrenador.
        /// </summary>
        /// <returns>El entrenador que coincide con las credenciales, o null si no se encuentra.</returns>
        public entrenadorModelo IniciarSesion(string nombreUsuario, string contraseña)
        {
            return entrenadores.FirstOrDefault(e => e.NombreUsuario == nombreUsuario && e.Contraseña == contraseña);
        }
    }
}
 






