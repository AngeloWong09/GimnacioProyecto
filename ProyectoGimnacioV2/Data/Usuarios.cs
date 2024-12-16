using System;
using System.Collections.Generic;




namespace ManualInitializationV4
{
    public class Usuario
    {
        public string UsuarioNombre { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Membresia { get; set; }
        public string ID { get; set; }
        public string ClaseID { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario { UsuarioNombre = "Lucas", Contraseña = "0", Nombre = "Lucas", Apellido1 = "García", Apellido2 = "García", Membresia = "", ID = "P1235", ClaseID = "" },
            new Usuario { UsuarioNombre = "Sofía", Contraseña = "P35ñ08", Nombre = "Sofía", Apellido1 = "Sánchez", Apellido2 = "González", Membresia = "", ID = "P1236", ClaseID = "" },
            new Usuario { UsuarioNombre = "Martín", Contraseña = "P35ñ09", Nombre = "Martín", Apellido1 = "Gutierrez", Apellido2 = "Castro", Membresia = "", ID = "P1237", ClaseID = "" },
            new Usuario { UsuarioNombre = "Ana", Contraseña = "0", Nombre = "Ana", Apellido1 = "Gutierrez", Apellido2 = "López", Membresia = "", ID = "P1238", ClaseID = "" },
            new Usuario { UsuarioNombre = "Pedro", Contraseña = "P35ñ11", Nombre = "Pedro", Apellido1 = "Torres", Apellido2 = "Martínez", Membresia = "", ID = "P1239", ClaseID = "" },
            new Usuario { UsuarioNombre = "Valentina", Contraseña = "P35ñ12", Nombre = "Valentina", Apellido1 = "Vargas", Apellido2 = "Sánchez", Membresia = "", ID = "P1240", ClaseID = "" },
            new Usuario { UsuarioNombre = "Diego", Contraseña = "P35ñ13", Nombre = "Diego", Apellido1 = "García", Apellido2 = "Rojas", Membresia = "", ID = "P1241", ClaseID = "" },
            new Usuario { UsuarioNombre = "Camila", Contraseña = "P35ñ14", Nombre = "Camila", Apellido1 = "Ramírez", Apellido2 = "Jiménez", Membresia = "", ID = "P1242", ClaseID = "" },
            new Usuario { UsuarioNombre = "Javier", Contraseña = "P35ñ15", Nombre = "Javier", Apellido1 = "González", Apellido2 = "Martínez", Membresia = "", ID = "P1243", ClaseID = "" },
            new Usuario { UsuarioNombre = "María", Contraseña = "P35ñ16", Nombre = "María", Apellido1 = "García", Apellido2 = "Rivera", Membresia = "", ID = "P1244", ClaseID = "" },
            new Usuario { UsuarioNombre = "Ricardo", Contraseña = "P35ñ17", Nombre = "Ricardo", Apellido1 = "Mendoza", Apellido2 = "Pérez", Membresia = "", ID = "P1245", ClaseID = "" },
            new Usuario { UsuarioNombre = "Natalia", Contraseña = "P35ñ18", Nombre = "Natalia", Apellido1 = "Martínez", Apellido2 = "Torres", Membresia = "", ID = "P1246", ClaseID = "" },
            new Usuario { UsuarioNombre = "Jorge", Contraseña = "P35ñ19", Nombre = "Jorge", Apellido1 = "Ortiz", Apellido2 = "Sánchez", Membresia = "", ID = "P1247", ClaseID = "" },
            new Usuario { UsuarioNombre = "Daniela", Contraseña = "P35ñ20", Nombre = "Daniela", Apellido1 = "Jiménez", Apellido2 = "López", Membresia = "", ID = "P1248", ClaseID = "" },
            new Usuario { UsuarioNombre = "Andrés", Contraseña = "P35ñ21", Nombre = "Andrés", Apellido1 = "Sánchez", Apellido2 = "Flores", Membresia = "", ID = "P1249", ClaseID = "" },
            new Usuario { UsuarioNombre = "Laura", Contraseña = "P35ñ22", Nombre = "Laura", Apellido1 = "Rivera", Apellido2 = "Vargas", Membresia = "", ID = "P1250", ClaseID = "" },
            // Puedes continuar agregando los demás usuarios aquí...
        };

            // Mostrar la lista de usuarios
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"Usuario: {usuario.UsuarioNombre}, Contraseña: {usuario.Contraseña}, Nombre: {usuario.Nombre}, Apellido1: {usuario.Apellido1}, Apellido2: {usuario.Apellido2}, ID: {usuario.ID}");
            }
        }
    }
}
