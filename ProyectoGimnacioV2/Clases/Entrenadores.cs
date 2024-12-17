using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoGimnacioV2
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
        public string CorreoElectronico { get; set; }  // Nueva propiedad
        public string Telefono { get; set; }           // Nueva propiedad
        public DateTime FechaIngreso { get; set; }     // Nueva propiedad
        public string Especialidad { get; set; }       // Nueva propiedad opcional
    }

    // Clase estática para manejar la lista de entrenadores
    public static class EntrenadoresData
    {
        public static List<Entrenador> ListaEntrenadores { get; set; } = new List<Entrenador>
        {
            new Entrenador
            {
                NombreUsuario = "Tobias1978",
                Contraseña = "0",
                Nombre = "Tobias",
                Apellido = "Argba",
                Id = 1237894,
                PuntosFuertes = "CardioDance",
                CorreoElectronico = "tobias.argba@email.com",  // Nuevo campo
                Telefono = "555-1234",                          // Nuevo campo
                FechaIngreso = new DateTime(2019, 5, 20),       // Nuevo campo
                Especialidad = "Cardio"
            },
            new Entrenador
            {
                NombreUsuario = "Bonnie639",
                Contraseña = "P35ñ08",
                Nombre = "Bonnie",
                Apellido = "Emeron",
                Id = 1237895,
                PuntosFuertes = "CardioDance",
                CorreoElectronico = "bonnie.emeron@email.com",
                Telefono = "555-5678",
                FechaIngreso = new DateTime(2020, 3, 15),
                Especialidad = "Zumba"
            },
            new Entrenador
            {
                NombreUsuario = "Ada1179",
                Contraseña = "P35ñ09",
                Nombre = "Ada",
                Apellido = "Wong",
                Id = 1237896,
                PuntosFuertes = "Funcionales",
                CorreoElectronico = "ada.wong@email.com",
                Telefono = "555-8765",
                FechaIngreso = new DateTime(2021, 8, 10),
                Especialidad = "Entrenamiento Funcional"
            },
            new Entrenador
            {
                NombreUsuario = "Gabriel7794",
                Contraseña = "P35ñ10",
                Nombre = "Gabriel",
                Apellido = "Mazariegos",
                Id = 1237897,
                PuntosFuertes = "Funcionales",
                CorreoElectronico = "gabriel.mazariegos@email.com",
                Telefono = "555-6543",
                FechaIngreso = new DateTime(2018, 12, 5),
                Especialidad = "Entrenamiento Funcional"
            },
            new Entrenador
            {
                NombreUsuario = "Yalin1110",
                Contraseña = "0",
                Nombre = "Yalin",
                Apellido = "Campos",
                Id = 1237898,
                PuntosFuertes = "Zumba",
                CorreoElectronico = "yalin.campos@email.com",
                Telefono = "555-4321",
                FechaIngreso = new DateTime(2022, 11, 1),
                Especialidad = "Zumba Fitness"
            },
            new Entrenador
            {
                NombreUsuario = "German15",
                Contraseña = "P35ñ12",
                Nombre = "German",
                Apellido = "Perez",
                Id = 1237899,
                PuntosFuertes = "CardioDance",
                CorreoElectronico = "german.perez@email.com",
                Telefono = "555-8760",
                FechaIngreso = new DateTime(2017, 6, 30),
                Especialidad = "Cardio Dance"
            }
        };
    }
}


