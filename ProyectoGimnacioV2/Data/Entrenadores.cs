using System;
using System.Collections.Generic;

namespace ManualInitializationV2 // Cambié el espacio de nombres
{
    // Clase que representa los datos del entrenador
    public class Entrenador
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id { get; set; }
        public string PuntosFuertes { get; set; }
    }

    public class Program // Clase principal única
    {
        static void Main(string[] args)
        {
            // Lista para inicializar los datos manualmente
            List<Entrenador> entrenadores = new List<Entrenador>
            {
                new Entrenador
                {
                    NombreUsuario = "Tobias1978",
                    Contraseña = "0",
                    Nombre = "Tobias",
                    Apellido = "Argba",
                    Id = 1237894,
                    PuntosFuertes = "CardioDance"
                },
                new Entrenador
                {
                    NombreUsuario = "Bonnie639",
                    Contraseña = "P35ñ08",
                    Nombre = "Bonnie",
                    Apellido = "Emeron",
                    Id = 1237895,
                    PuntosFuertes = "CardioDance"
                },
                new Entrenador
                {
                    NombreUsuario = "Ada1179",
                    Contraseña = "P35ñ09",
                    Nombre = "Ada",
                    Apellido = "Wong",
                    Id = 1237896,
                    PuntosFuertes = "Funcionales"
                },
                new Entrenador
                {
                    NombreUsuario = "Gabriel7794",
                    Contraseña = "P35ñ10",
                    Nombre = "Gabriel",
                    Apellido = "Mazariegos",
                    Id = 1237897,
                    PuntosFuertes = "Funcionales"
                },
                new Entrenador
                {
                    NombreUsuario = "Yalin1110",
                    Contraseña = "0",
                    Nombre = "Yalin",
                    Apellido = "Campos",
                    Id = 1237898,
                    PuntosFuertes = "Zumba"
                },
                new Entrenador
                {
                    NombreUsuario = "German15",
                    Contraseña = "P35ñ12",
                    Nombre = "German",
                    Apellido = "Perez",
                    Id = 1237899,
                    PuntosFuertes = "CardioDance"
                }
            };

            // Mostrar los datos en la consola
            Console.WriteLine("Lista de Entrenadores:\n");
            foreach (var entrenador in entrenadores)
            {
                Console.WriteLine($"Nombre de Usuario: {entrenador.NombreUsuario}");
                Console.WriteLine($"Contraseña: {entrenador.Contraseña}");
                Console.WriteLine($"Nombre: {entrenador.Nombre}");
                Console.WriteLine($"Apellido: {entrenador.Apellido}");
                Console.WriteLine($"ID: {entrenador.Id}");
                Console.WriteLine($"Puntos Fuertes: {entrenador.PuntosFuertes}\n");
            }
        }
    }
}
