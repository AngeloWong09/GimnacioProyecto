using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Modelo
{
  
        internal class administradorModelo
        {
            public int Id { get; set; }
            public string NombreUsuario { get; set; }
            public string Contraseña { get; set; }
            public string Rol { get; set; }
            public string Nombre { get; set; }
            public string Apellido1 { get; set; }
            public string Apellido2 { get; set; }
            public string Membresia { get; set; }
            public string UsuarioID { get; set; }
            public string ClaseID { get; set; }
            public string NivelAcceso { get; set; }

            // Constructor sin herencia, con todos los parámetros directamente en esta clase
            public administradorModelo(int id, string nombreUsuario, string contraseña, string nivelAcceso, string nombre, string apellido)
            {
                Id = id;
                NombreUsuario = nombreUsuario;
                Contraseña = contraseña;
                Rol = "Administrador"; // Rol predeterminado
                Nombre = nombre;
                Apellido1 = apellido;  // Utilizamos apellido para Apellido1
                Apellido2 = "";        // No se tiene apellido2, lo dejamos vacío
                Membresia = "";        // No se tiene Membresía, lo dejamos vacío
                UsuarioID = "";        // No se tiene UsuarioID, lo dejamos vacío
                ClaseID = "";          // No se tiene ClaseID, lo dejamos vacío
                NivelAcceso = nivelAcceso;
            }
        }
}
