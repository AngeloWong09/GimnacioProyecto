namespace ProyectoGimnacioV2.Clases
{
    public class Usuario
    {
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string Password { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public DateTime Membresia { get; set; }
        public string ClaseId { get; set; }

        // Nueva propiedad Rutina
        public Rutina Rutina { get; set; }
    }

    public class Rutina
    {
        public string Nombre { get; set; }
        public int Series { get; set; }
        public int Repeticiones { get; set; }
    }

    public static class Usuarios
    {
        private static Random random = new Random();

        public static List<Usuario> ListaUsuarios = new List<Usuario>
        {
            new Usuario { ClientId = "1", ClientName = "Lucas", Password = "0", Apellido1 = "García", Apellido2 = "García", Membresia = DateTime.Parse("2024-02-15"), ClaseId = "C001", Rutina = new Rutina { Nombre = "Pecho", Series = 3, Repeticiones = 10 } },
            new Usuario { ClientId = "2", ClientName = "Sofía", Password = "P35ñ08", Apellido1 = "Sánchez", Apellido2 = "González", Membresia = DateTime.Parse("2024-03-20"), ClaseId = "C002", Rutina = new Rutina { Nombre = "Bíceps", Series = 4, Repeticiones = 12 } },
            new Usuario { ClientId = "3", ClientName = "Martín", Password = "P35ñ09", Apellido1 = "Gutierrez", Apellido2 = "Castro", Membresia = DateTime.Parse("2024-05-10"), ClaseId = "C003", Rutina = new Rutina { Nombre = "Tríceps", Series = 5, Repeticiones = 8 } },
            new Usuario { ClientId = "4", ClientName = "Ana", Password = "J8dPl0", Apellido1 = "Martínez", Apellido2 = "Ramírez", Membresia = DateTime.Parse("2024-06-11"), ClaseId = "C004", Rutina = new Rutina { Nombre = "Piernas", Series = 6, Repeticiones = 15 } },
            new Usuario { ClientId = "5", ClientName = "Pedro", Password = "X04tD1", Apellido1 = "Rodríguez", Apellido2 = "Fernández", Membresia = DateTime.Parse("2024-07-22"), ClaseId = "C005", Rutina = new Rutina { Nombre = "Pecho", Series = 3, Repeticiones = 10 } },
            new Usuario { ClientId = "6", ClientName = "Juan", Password = "Q12zJ7", Apellido1 = "López", Apellido2 = "González", Membresia = DateTime.Parse("2024-08-30"), ClaseId = "C006", Rutina = new Rutina { Nombre = "Bíceps", Series = 4, Repeticiones = 12 } },
            new Usuario { ClientId = "7", ClientName = "María", Password = "T9kH5", Apellido1 = "Pérez", Apellido2 = "Vázquez", Membresia = DateTime.Parse("2024-09-14"), ClaseId = "C007", Rutina = new Rutina { Nombre = "Tríceps", Series = 5, Repeticiones = 8 } },
            new Usuario { ClientId = "8", ClientName = "Carlos", Password = "M25pL8", Apellido1 = "Gómez", Apellido2 = "Martínez", Membresia = DateTime.Parse("2024-10-02"), ClaseId = "C008", Rutina = new Rutina { Nombre = "Piernas", Series = 6, Repeticiones = 15 } },
            new Usuario { ClientId = "9", ClientName = "Laura", Password = "P35o9E", Apellido1 = "Fernández", Apellido2 = "Castro", Membresia = DateTime.Parse("2024-11-05"), ClaseId = "C009", Rutina = new Rutina { Nombre = "Pecho", Series = 3, Repeticiones = 10 } },
            new Usuario { ClientId = "10", ClientName = "Pablo", Password = "X7rM8a", Apellido1 = "García", Apellido2 = "Rodríguez", Membresia = DateTime.Parse("2024-12-16"), ClaseId = "C010", Rutina = new Rutina { Nombre = "Bíceps", Series = 4, Repeticiones = 12 } },
            new Usuario { ClientId = "11", ClientName = "Raúl", Password = "N4uKl0", Apellido1 = "Méndez", Apellido2 = "Gómez", Membresia = DateTime.Parse("2024-03-25"), ClaseId = "C011", Rutina = new Rutina { Nombre = "Tríceps", Series = 5, Repeticiones = 8 } },
            new Usuario { ClientId = "12", ClientName = "Lucía", Password = "H2jDs9", Apellido1 = "Vázquez", Apellido2 = "Hernández", Membresia = DateTime.Parse("2024-04-18"), ClaseId = "C012", Rutina = new Rutina { Nombre = "Piernas", Series = 6, Repeticiones = 15 } },
            new Usuario { ClientId = "13", ClientName = "David", Password = "J3xHk8", Apellido1 = "Lopez", Apellido2 = "Romero", Membresia = DateTime.Parse("2024-06-19"), ClaseId = "C013", Rutina = new Rutina { Nombre = "Pecho", Series = 3, Repeticiones = 10 } },
            new Usuario { ClientId = "14", ClientName = "Isabel", Password = "Z7gWk5", Apellido1 = "Sánchez", Apellido2 = "Vega", Membresia = DateTime.Parse("2024-07-30"), ClaseId = "C014", Rutina = new Rutina { Nombre = "Bíceps", Series = 4, Repeticiones = 12 } },
            new Usuario { ClientId = "15", ClientName = "José", Password = "R1m9Gd", Apellido1 = "Alonso", Apellido2 = "Morales", Membresia = DateTime.Parse("2024-09-01"), ClaseId = "C015", Rutina = new Rutina { Nombre = "Tríceps", Series = 5, Repeticiones = 8 } },
            new Usuario { ClientId = "16", ClientName = "Marcos", Password = "A4nJt7", Apellido1 = "Ramírez", Apellido2 = "Paredes", Membresia = DateTime.Parse("2024-10-10"), ClaseId = "C016", Rutina = new Rutina { Nombre = "Piernas", Series = 6, Repeticiones = 15 } },
            new Usuario { ClientId = "17", ClientName = "Sandra", Password = "I8kRt5", Apellido1 = "Castro", Apellido2 = "López", Membresia = DateTime.Parse("2024-11-13"), ClaseId = "C017", Rutina = new Rutina { Nombre = "Pecho", Series = 3, Repeticiones = 10 } },
            new Usuario { ClientId = "18", ClientName = "Felipe", Password = "T9oMk2", Apellido1 = "Fernández", Apellido2 = "Pérez", Membresia = DateTime.Parse("2024-12-05"), ClaseId = "C018", Rutina = new Rutina { Nombre = "Bíceps", Series = 4, Repeticiones = 12 } },
            new Usuario { ClientId = "19", ClientName = "Beatriz", Password = "A5nFr8", Apellido1 = "Gómez", Apellido2 = "Sánchez", Membresia = DateTime.Parse("2024-03-12"), ClaseId = "C019", Rutina = new Rutina { Nombre = "Tríceps", Series = 5, Repeticiones = 8 } },
            new Usuario { ClientId = "20", ClientName = "Víctor", Password = "D6rMq3", Apellido1 = "Morales", Apellido2 = "Vázquez", Membresia = DateTime.Parse("2024-04-27"), ClaseId = "C020", Rutina = new Rutina { Nombre = "Piernas", Series = 6, Repeticiones = 15 } },
            new Usuario { ClientId = "21", ClientName = "Álvaro", Password = "H5sKb0", Apellido1 = "Martínez", Apellido2 = "Méndez", Membresia = DateTime.Parse("2024-06-15"), ClaseId = "C021", Rutina = new Rutina { Nombre = "Pecho", Series = 3, Repeticiones = 10 } },
            new Usuario { ClientId = "22", ClientName = "Marta", Password = "J8lNz1", Apellido1 = "Hernández", Apellido2 = "Castro", Membresia = DateTime.Parse("2024-07-20"), ClaseId = "C022", Rutina = new Rutina { Nombre = "Bíceps", Series = 4, Repeticiones = 12 } },
            new Usuario { ClientId = "23", ClientName = "Javier", Password = "P9mHt7", Apellido1 = "Lopez", Apellido2 = "García", Membresia = DateTime.Parse("2024-09-23"), ClaseId = "C023", Rutina = new Rutina { Nombre = "Tríceps", Series = 5, Repeticiones = 8 } },
            new Usuario { ClientId = "24", ClientName = "Patricia", Password = "R0tI3F", Apellido1 = "González", Apellido2 = "Romero", Membresia = DateTime.Parse("2024-10-11"), ClaseId = "C024", Rutina = new Rutina { Nombre = "Piernas", Series = 6, Repeticiones = 15 } },
            new Usuario { ClientId = "25", ClientName = "Ricardo", Password = "V8nUq1", Apellido1 = "Alonso", Apellido2 = "Morales", Membresia = DateTime.Parse("2024-11-17"), ClaseId = "C025", Rutina = new Rutina { Nombre = "Pecho", Series = 3, Repeticiones = 10 } }
        };
    }
}

