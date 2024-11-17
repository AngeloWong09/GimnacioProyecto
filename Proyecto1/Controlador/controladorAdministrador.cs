﻿using ClosedXML.Excel;
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
        private List<Administrador> administradores;

        public controladorAdministrador()
        {
            administradores = new List<Administrador>();
            CargarAdministradoresDesdeExcel("Administrador.xlsx");
        }

        private void CargarAdministradoresDesdeExcel(string rutaArchivo)
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
                    string nivelAcceso = row.Cell(3).GetValue<string>();

                    administradores.Add(new Administrador(administradores.Count + 1, nombreUsuario, contraseña, nivelAcceso));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar administradores desde Excel: {ex.Message}");
            }
        }

        public Administrador IniciarSesion(string nombreUsuario, string contraseña)
        {
            return administradores.FirstOrDefault(a => a.NombreUsuario == nombreUsuario && a.VerificarContraseña(contraseña));
        }
    }
}


