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
        private List<Entrenador> entrenadores;

        public controladorEntrenador()
        {
            entrenadores = new List<Entrenador>();
            CargarEntrenadoresDesdeExcel("Entrenadores.xlsx");
        }

        private void CargarEntrenadoresDesdeExcel(string rutaArchivo)
        {
            try
            {
                string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaArchivo);
                var workbook = new XLWorkbook(rutaCompleta);
                var worksheet = workbook.Worksheet("Sheet1");
                var rows = worksheet.RangeUsed().RowsUsed();

                foreach (var row in rows.Skip(1)) // Saltar la fila de encabezados
                {
                    string nombreUsuario = row.Cell(1).GetValue<string>();
                    string contraseña = row.Cell(2).GetValue<string>();
                    string horario = row.Cell(3).GetValue<string>();
                    string puntosFuertes = row.Cell(4).GetValue<string>();

                    entrenadores.Add(new Entrenador(entrenadores.Count + 1, nombreUsuario, contraseña, horario, puntosFuertes));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar entrenadores desde Excel: {ex.Message}");
            }
        }

        public Entrenador IniciarSesion(string nombreUsuario, string contraseña)
        {
            return entrenadores.FirstOrDefault(e => e.NombreUsuario == nombreUsuario && e.VerificarContraseña(contraseña));
        }
    }
}

