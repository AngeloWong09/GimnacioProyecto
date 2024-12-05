using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace Proyecto1.Controlador
{
    /// <summary>
    /// Controlador para gestionar las acciones relacionadas con los administradores.
    /// </summary>
    internal class controladorAdministrador
    {
        // Lista que almacena los administradores cargados desde el archivo Administrador.csv
        private List<administradorModelo> administradores;

        public controladorAdministrador()
        {
            // Inicializa la lista vacía de administradores
            administradores = new List<administradorModelo>();
            // Llama al método para cargar los administradores desde los archivos Administrador.csv
            CargarAdministradoresDesdeCSV("Assets/Administrador.csv");
        }

        /// <summary>
        /// Carga los administradores desde un archivo Administrador.csv
        /// </summary>
        /// <param name="rutaArchivo">Ruta del archivo CSV desde el cual se cargan los administradores.</param>
        private void CargarAdministradoresDesdeCSV(string rutaArchivo)
        {
            try
            {
                string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaArchivo);

                if (!File.Exists(rutaCompleta))
                {
                    MostrarError($"El archivo {rutaArchivo} no existe.");
                    return;
                }

                using (var reader = new StreamReader(rutaCompleta))
                {
                    reader.ReadLine(); // Saltar encabezado
                    while (!reader.EndOfStream)
                    {
                        ProcesarLinea(reader.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError($"Error al cargar administradores desde CSV: {ex.Message}");
            }
        }

        /// <summary>
        /// Procesa una línea del archivo CSV que contiene los datos de un administrador.
        /// Separa los valores de la línea y crea un administrador si los datos son válidos.
        /// </summary>
        private void ProcesarLinea(string linea)
        {
            var valores = linea.Split(';');
            if (valores.Length < 5) return;

            if (int.TryParse(valores[4].Trim(), out int id))
            {
                var administrador = CrearAdministrador(valores, id);
                administradores.Add(administrador);
            }
        }

        /// <summary>
        /// Crea un objeto administradorModelo a partir de los valores extraídos de una línea Administrador.csv
        /// </summary>
        private administradorModelo CrearAdministrador(string[] valores, int id)
        {
            return new administradorModelo(
                id,
                valores[0].Trim(),
                valores[1].Trim(),
                "Administrador",
                valores[2].Trim(),
                valores[3].Trim()
            );
        }

        /// <summary>
        /// Muestra un mensaje de error en una ventana emergente (MessageBox).
        /// </summary>
        private void MostrarError(string mensaje)
        {
            
        }

        /// <summary>
        /// Inicia sesión verificando si el nombre de usuario y la contraseña coinciden en el archivo Adminitrador.csv
        /// </summary>
        public administradorModelo IniciarSesion(string nombreUsuario, string contraseña)
        {
            return administradores.FirstOrDefault(a => a.NombreUsuario == nombreUsuario && a.Contraseña == contraseña);
        }
    }
}





