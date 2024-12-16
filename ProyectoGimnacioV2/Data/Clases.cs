using System;
using System.Collections.Generic;



namespace ManualInitializationV5
{
    public class ClaseEntrenamiento
    {
        public int IDClase { get; set; }
        public int IDEntrenador { get; set; }
        public string NombreClase { get; set; }
        public DateTime Fecha { get; set; }
        public string Horario { get; set; }
        public int Cupos { get; set; }
        public decimal PrecioClase { get; set; }

        public ClaseEntrenamiento(int idClase, int idEntrenador, string nombreClase, DateTime fecha, string horario, int cupos, decimal precioClase)
        {
            IDClase = idClase;
            IDEntrenador = idEntrenador;
            NombreClase = nombreClase;
            Fecha = fecha;
            Horario = horario;
            Cupos = cupos;
            PrecioClase = precioClase;
        }
    }

    class Program
    {
        static void Main()
        {
            // Lista de clases
            List<ClaseEntrenamiento> clases = new List<ClaseEntrenamiento>
        {
            new ClaseEntrenamiento(497623, 1237894, "Zumba", new DateTime(2024, 11, 4), "8:00:00 a.m", 10, 2500),
            new ClaseEntrenamiento(497624, 1237895, "CardioDance", new DateTime(2024, 11, 2), "10:00:00 a.m.", 10, 3000),
            new ClaseEntrenamiento(497625, 1237896, "Funcionales", new DateTime(2024, 11, 3), "06:00:00 p.m.", 10, 4500),
            new ClaseEntrenamiento(497626, 1237897, "Zumba", new DateTime(2024, 11, 4), "06:00:00 a.m.", 10, 2500),
            new ClaseEntrenamiento(497627, 1237898, "CardioDance", new DateTime(2024, 11, 5), "10:00:00 a.m.", 10, 3000),
            new ClaseEntrenamiento(497628, 1237899, "Funcionales", new DateTime(2024, 11, 6), "07:00:00 a.m.", 10, 4500),
            new ClaseEntrenamiento(497629, 1237894, "Zumba", new DateTime(2024, 11, 7), "01:00:00 p.m.", 10, 2500),
            new ClaseEntrenamiento(497630, 1237895, "CardioDance", new DateTime(2024, 11, 8), "10:00:00 a.m.", 10, 3000),
            new ClaseEntrenamiento(497631, 1237896, "Funcionales", new DateTime(2024, 11, 9), "06:00:00 p.m.", 10, 4500),
            new ClaseEntrenamiento(497632, 1237897, "Zumba", new DateTime(2024, 11, 10), "06:00:00 a.m.", 10, 2500),
            new ClaseEntrenamiento(497633, 1237898, "CardioDance", new DateTime(2024, 11, 11), "03:30:00 p.m.", 10, 3000),
            new ClaseEntrenamiento(497634, 1237899, "Funcionales", new DateTime(2024, 11, 12), "07:00:00 a.m.", 10, 4500),
            new ClaseEntrenamiento(497635, 1237894, "Zumba", new DateTime(2024, 11, 13), "01:00:00 p.m.", 10, 2500),
            new ClaseEntrenamiento(497636, 1237895, "CardioDance", new DateTime(2024, 11, 14), "10:00:00 a.m.", 10, 3000),
            new ClaseEntrenamiento(497637, 1237896, "Funcionales", new DateTime(2024, 11, 15), "06:00:00 p.m.", 10, 4500),
            new ClaseEntrenamiento(497638, 1237897, "Zumba", new DateTime(2024, 11, 16), "03:30:00 p.m.", 10, 2500),
            new ClaseEntrenamiento(497639, 1237898, "CardioDance", new DateTime(2024, 11, 17), "07:00:00 a.m.", 10, 3000),
            new ClaseEntrenamiento(497640, 1237899, "Funcionales", new DateTime(2024, 11, 18), "01:00:00 p.m.", 10, 4500),
            new ClaseEntrenamiento(497641, 1237894, "Zumba", new DateTime(2024, 11, 19), "10:00:00 a.m.", 10, 2500),
            new ClaseEntrenamiento(497642, 1237895, "CardioDance", new DateTime(2024, 11, 20), "06:00:00 p.m.", 10, 3000),
            new ClaseEntrenamiento(497643, 1237896, "Funcionales", new DateTime(2024, 11, 21), "06:00:00 p.m.", 10, 4500),
            new ClaseEntrenamiento(497644, 1237897, "Zumba", new DateTime(2024, 11, 22), "03:30:00 p.m.", 10, 2500),
            new ClaseEntrenamiento(497645, 1237898, "CardioDance", new DateTime(2024, 11, 23), "07:00:00 a.m.", 10, 3000),
            new ClaseEntrenamiento(497646, 1237899, "Funcionales", new DateTime(2024, 11, 24), "01:00:00 p.m.", 10, 4500),
            new ClaseEntrenamiento(497647, 1237894, "Zumba", new DateTime(2024, 11, 25), "8:00:00 a.m", 10, 2500),
            new ClaseEntrenamiento(497648, 1237895, "CardioDance", new DateTime(2024, 11, 26), "10:00:00 a.m.", 10, 3000),
            new ClaseEntrenamiento(497649, 1237896, "Funcionales", new DateTime(2024, 11, 27), "06:00:00 p.m.", 10, 4500),
            new ClaseEntrenamiento(497650, 1237897, "Zumba", new DateTime(2024, 11, 28), "07:00:00 a.m.", 10, 2501),
            new ClaseEntrenamiento(497651, 1237898, "CardioDance", new DateTime(2024, 11, 29), "01:00:00 p.m.", 10, 3001),
            new ClaseEntrenamiento(497652, 1237899, "Funcionales", new DateTime(2024, 11, 30), "10:00:00 a.m.", 10, 4501),
            new ClaseEntrenamiento(497653, 1237894, "Zumba", new DateTime(2024, 12, 1), "8:00:00 a.m", 10, 2501),
            new ClaseEntrenamiento(497654, 1237895, "CardioDance", new DateTime(2024, 12, 2), "10:00:00 a.m.", 10, 3001),
            new ClaseEntrenamiento(497655, 1237896, "Funcionales", new DateTime(2024, 12, 3), "06:00:00 p.m.", 10, 4501),
            new ClaseEntrenamiento(497656, 1237897, "Zumba", new DateTime(2024, 12, 4), "07:00:00 a.m.", 10, 2502),
            new ClaseEntrenamiento(497657, 1237898, "CardioDance", new DateTime(2024, 12, 5), "01:00:00 p.m.", 10, 3002),
            new ClaseEntrenamiento(497658, 1237899, "Funcionales", new DateTime(2024, 12, 6), "10:00:00 a.m.", 10, 4502),
            new ClaseEntrenamiento(497659, 1237894, "Zumba", new DateTime(2024, 12, 7), "8:00:00 a.m", 10, 2502),
            new ClaseEntrenamiento(497660, 1237895, "CardioDance", new DateTime(2024, 12, 8), "10:00:00 a.m.", 10, 3002),
            new ClaseEntrenamiento(497661, 1237896, "Funcionales", new DateTime(2024, 12, 9), "06:00:00 p.m.", 10, 4502)
        };

            // Ejemplo de cómo imprimir las clases
            foreach (var clase in clases)
            {
                Console.WriteLine($"ID Clase: {clase.IDClase}, Nombre: {clase.NombreClase}, Fecha: {clase.Fecha.ToString("dd/MM/yyyy")}, Horario: {clase.Horario}, Cupos: {clase.Cupos}, Precio: {clase.PrecioClase:C}");
            }
        }
    }
}

