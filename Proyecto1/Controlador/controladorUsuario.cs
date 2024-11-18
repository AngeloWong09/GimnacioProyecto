using System.Linq;
using ClosedXML.Excel;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto1.Controlador
{
    internal class controladorUsuario
    {
        private List<Usuario> usuarios;

        public controladorUsuario()
        {
            usuarios = new List<Usuario>();
            CargarUsuariosDesdeExcel("Usuarios.xlsx");
        }

        private void CargarUsuariosDesdeExcel(string rutaArchivo)
        {
            try
            {
                string rutaCompleta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaArchivo);
                var workbook = new XLWorkbook(rutaCompleta); // Usa la ruta completa
                var worksheet = workbook.Worksheet("Sheet1");
                var rows = worksheet.RangeUsed().RowsUsed();

                foreach (var row in rows.Skip(1)) // Saltar la fila de encabezados
                {
                    string usuario = row.Cell(1).GetValue<string>();
                    string contraseña = row.Cell(2).GetValue<string>();
                    usuarios.Add(new Usuario(usuarios.Count + 1, usuario, contraseña, "Usuario"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios desde Excel: {ex.Message}");
            }
        }

        public Usuario IniciarSesion(string nombreUsuario, string contraseña)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.NombreUsuario == nombreUsuario && usuario.VerificarContraseña(contraseña))
                {
                    return usuario;
                }
            }
            return null; // Retorna null si no se encuentra el usuario
        }
    }
}
