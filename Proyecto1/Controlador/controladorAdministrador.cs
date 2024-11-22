using ClosedXML.Excel;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Proyecto1.Controlador
{
    internal class controladorAdministrador
    {
        private List<administradorModelo> administradores;

        public controladorAdministrador()
        {
          
            administradores = new List<administradorModelo>();
            CargarAdministradoresDesdeCSV("Assets/Administrador.csv");
        }


        private void CargarAdministradoresDesdeCSV(string rutaArchivo)
        {
            try
            {
                string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaArchivo);

                if (!File.Exists(rutaCompleta))
                {
                    MessageBox.Show($"El archivo {rutaArchivo} no existe.", "Error");
                    return;
                }

                using (var reader = new StreamReader(rutaCompleta))
                {
                    string linea;
                    bool primeraLinea = true;

                    while ((linea = reader.ReadLine()) != null)
                    {
                        if (primeraLinea) // Ignorar encabezado
                        {
                            primeraLinea = false;
                            continue;
                        }

                        var valores = linea.Split(';'); // Separador es ';'

                        if (valores.Length >= 5) // Verificar que haya suficientes columnas
                        {
                            string nombreUsuario = valores[0].Trim();  // Columna Usuario
                            string contraseña = valores[1].Trim();     // Columna Contraseña
                            string nombre = valores[2].Trim();         // Columna Nombre
                            string apellido = valores[3].Trim();      // Columna Apellido
                            int id;

                            // Verificar que el ID sea un número válido
                            if (int.TryParse(valores[4].Trim(), out id))
                            {
                                // Crear el administrador con los datos disponibles
                                var administrador = new administradorModelo(
                                    id,                      // ID
                                    nombreUsuario,           // Nombre de usuario
                                    contraseña,              // Contraseña
                                    "Administrador",         // NivelAcceso predeterminado
                                    nombre,                  // Nombre
                                    apellido                 // Apellido
                                );

                                administradores.Add(administrador);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar administradores desde CSV: {ex.Message}", "Error");
            }
        }

        public administradorModelo IniciarSesion(string nombreUsuario, string contraseña)
        {
            return administradores.FirstOrDefault(a => a.NombreUsuario == nombreUsuario && a.Contraseña == contraseña);
        }
    }
}





