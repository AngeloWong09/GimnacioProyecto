using System;
using System.Collections.Generic;

namespace ManualInitialization
{
    // Clase que representa los datos del administrador
    public class Administrador
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Inicialización manual de los datos
            Administrador admin1 = new Administrador
            {
                Usuario = "Leinix0906",
                Contraseña = "0",
                Nombre = "Angelo",
                Apellido = "Wong",
                Id = 149486
            };

            Administrador admin2 = new Administrador
            {
                Usuario = "C",
                Contraseña = "0",
                Nombre = "Christopher",
                Apellido = "Calvo",
                Id = 149487
            };

            // Lista de administradores
            List<Administrador> administradores = new List<Administrador>
            {
                admin1,
                admin2
            };

            // Mostrar los datos
            Console.WriteLine("Datos de Administradores:\n");
            foreach (var admin in administradores)
            {
                Console.WriteLine($"Usuario: {admin.Usuario}");
                Console.WriteLine($"Contraseña: {admin.Contraseña}");
                Console.WriteLine($"Nombre: {admin.Nombre}");
                Console.WriteLine($"Apellido: {admin.Apellido}");
                Console.WriteLine($"ID: {admin.Id}\n");
            }
        }
    }
}

