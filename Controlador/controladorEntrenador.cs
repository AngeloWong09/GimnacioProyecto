using ClosedXML.Excel;
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

                        var valores = linea.Split(';'); // Separador es punto y coma en CSV

                        if (valores.Length >= 7) // Verificar que hay suficientes columnas
                        {
                            string nombreUsuario = valores[0].Trim();  // Columna Usuario
                            string contraseña = valores[1].Trim();     // Columna Contraseña
                            string nombre = valores[2].Trim();         // Columna Nombre
                            string apellido = valores[3].Trim();      // Columna Apellido
                            string idStr = valores[4].Trim();          // Columna ID
                            string puntosFuertes = valores[5].Trim();  // Columna Puntos fuertes
                            string horario = valores[6].Trim();        // Columna Horario

                            int id;
                            // Verificar que el ID sea un número válido
                            if (int.TryParse(idStr, out id))
                            {
                                // Crear el modelo de entrenador con los datos obtenidos del CSV
                                entrenadores.Add(new entrenadorModelo(
                                    nombreUsuario,       // Nombre de usuario
                                    contraseña,          // Contraseña
                                    nombre,              // Nombre
                                    apellido,            // Apellido
                                    id,                  // ID
                                    puntosFuertes,       // Puntos fuertes
                                    horario              // Horario
                                ));
                            }
                            else
                            {
                                MessageBox.Show($"ID no válido en la línea: {linea}", "Error");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar entrenadores desde CSV: {ex.Message}", "Error");
            }
        }

        public entrenadorModelo IniciarSesion(string nombreUsuario, string contraseña)
        {
            return entrenadores.FirstOrDefault(e => e.NombreUsuario == nombreUsuario && e.Contraseña == contraseña);
        }
    }
}


