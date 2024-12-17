
using System;
using System.Collections.Generic;

public class ClaseEntrenamiento
{
    public int ClaseId { get; set; }
    public int EntrenadorId { get; set; }
    public string NombreClase { get; set; }
    public DateTime Fecha { get; set; }
    public string Hora { get; set; }
    public int Capacidad { get; set; }
    public decimal Precio { get; set; }
    public string NombreEntrenador { get; set; } // Se agrega el nombre del entrenador

    public ClaseEntrenamiento(int claseId, int entrenadorId, string nombreClase, DateTime fecha, string hora, int capacidad, decimal precio, string nombreEntrenador)
    {
        ClaseId = claseId;
        EntrenadorId = entrenadorId;
        NombreClase = nombreClase;
        Fecha = fecha;
        Hora = hora;
        Capacidad = capacidad;
        Precio = precio;
        NombreEntrenador = nombreEntrenador; // Asignación del nombre del entrenador
    }

    // Método para obtener todas las clases
    public static List<ClaseEntrenamiento> ObtenerClases()
    {
        return new List<ClaseEntrenamiento>
        {
            new ClaseEntrenamiento(1, 123, "Zumba", new DateTime(2024, 11, 4), "8:00:00 a. m.", 10, 2500, "Tobias"),
            new ClaseEntrenamiento(2, 124, "CardioDance", new DateTime(2024, 11, 2), "10:00:00 a. m.", 10, 3000, "Bonnie"),
            new ClaseEntrenamiento(3, 125, "Funcionales", new DateTime(2024, 11, 3), "06:00:00 p. m.", 10, 4500, "Ada"),
            new ClaseEntrenamiento(4, 126, "Zumba", new DateTime(2024, 11, 4), "06:00:00 a. m.", 10, 2500, "Gabriel"),
            new ClaseEntrenamiento(5, 127, "CardioDance", new DateTime(2024, 11, 5), "10:00:00 a. m.", 10, 3000, "Yalin"),
            new ClaseEntrenamiento(6, 128, "Funcionales", new DateTime(2024, 11, 6), "07:00:00 a. m.", 10, 4500, "German"),
            new ClaseEntrenamiento(7, 123, "Zumba", new DateTime(2024, 11, 7), "01:00:00 p. m.", 10, 2500, "Tobias"),
            new ClaseEntrenamiento(8, 124, "CardioDance", new DateTime(2024, 11, 8), "10:00:00 a. m.", 10, 3000, "Bonnie"),
            new ClaseEntrenamiento(9, 125, "Funcionales", new DateTime(2024, 11, 9), "06:00:00 p. m.", 10, 4500, "Ada"),
            new ClaseEntrenamiento(10, 126, "Zumba", new DateTime(2024, 11, 10), "06:00:00 a. m.", 10, 2500, "Gabriel"),
            new ClaseEntrenamiento(11, 127, "CardioDance", new DateTime(2024, 11, 11), "03:30:00 p. m.", 10, 3000, "Yalin"),
            new ClaseEntrenamiento(12, 128, "Funcionales", new DateTime(2024, 11, 12), "07:00:00 a. m.", 10, 4500, "German"),
            new ClaseEntrenamiento(13, 123, "Zumba", new DateTime(2024, 11, 13), "01:00:00 p. m.", 10, 2500, "Tobias"),
            new ClaseEntrenamiento(14, 124, "CardioDance", new DateTime(2024, 11, 14), "10:00:00 a. m.", 10, 3000, "Bonnie"),
            new ClaseEntrenamiento(15, 125, "Funcionales", new DateTime(2024, 11, 15), "06:00:00 p. m.", 10, 4500, "Ada"),
            new ClaseEntrenamiento(16, 126, "Zumba", new DateTime(2024, 11, 16), "03:30:00 p. m.", 10, 2500, "Gabriel"),
            new ClaseEntrenamiento(17, 127, "CardioDance", new DateTime(2024, 11, 17), "07:00:00 a. m.", 10, 3000, "Yalin"),
            new ClaseEntrenamiento(18, 128, "Funcionales", new DateTime(2024, 11, 18), "01:00:00 p. m.", 10, 4500, "German"),
            new ClaseEntrenamiento(19, 123, "Zumba", new DateTime(2024, 11, 19), "10:00:00 a. m.", 10, 2500, "Tobias"),
            new ClaseEntrenamiento(20, 124, "CardioDance", new DateTime(2024, 11, 20), "06:00:00 p. m.", 10, 3000, "Bonnie"),
            new ClaseEntrenamiento(21, 125, "Funcionales", new DateTime(2024, 11, 21), "06:00:00 p. m.", 10, 4500, "Ada"),
            new ClaseEntrenamiento(22, 126, "Zumba", new DateTime(2024, 11, 22), "03:30:00 p. m.", 10, 2500, "Gabriel"),
            new ClaseEntrenamiento(23, 127, "CardioDance", new DateTime(2024, 11, 23), "07:00:00 a. m.", 10, 3000, "Yalin"),
            new ClaseEntrenamiento(24, 128, "Funcionales", new DateTime(2024, 11, 24), "01:00:00 p. m.", 10, 4500, "German"),
            new ClaseEntrenamiento(25, 123, "Zumba", new DateTime(2024, 11, 25), "8:00:00 a. m.", 10, 2500, "Tobias"),
            new ClaseEntrenamiento(26, 124, "CardioDance", new DateTime(2024, 11, 26), "10:00:00 a. m.", 10, 3000, "Bonnie"),
            new ClaseEntrenamiento(27, 125, "Funcionales", new DateTime(2024, 11, 27), "06:00:00 p. m.", 10, 4500, "Ada"),
            new ClaseEntrenamiento(28, 126, "Zumba", new DateTime(2024, 11, 28), "07:00:00 a. m.", 10, 2501, "Gabriel"),
            new ClaseEntrenamiento(29, 127, "CardioDance", new DateTime(2024, 11, 29), "01:00:00 p. m.", 10, 3001, "Yalin"),
            new ClaseEntrenamiento(30, 128, "Funcionales", new DateTime(2024, 11, 30), "10:00:00 a. m.", 10, 4501, "German"),
            new ClaseEntrenamiento(31, 123, "Zumba", new DateTime(2024, 12, 1), "8:00:00 a. m.", 10, 2501, "Tobias"),
            new ClaseEntrenamiento(32, 124, "CardioDance", new DateTime(2024, 12, 2), "10:00:00 a. m.", 10, 3001, "Bonnie"),
            new ClaseEntrenamiento(33, 125, "Funcionales", new DateTime(2024, 12, 3), "06:00:00 p. m.", 10, 4501, "Ada"),
            new ClaseEntrenamiento(34, 126, "Zumba", new DateTime(2024, 12, 4), "07:00:00 a. m.", 10, 2502, "Gabriel"),
            new ClaseEntrenamiento(35, 127, "CardioDance", new DateTime(2024, 12, 5), "01:00:00 p. m.", 10, 3002, "Yalin"),
            new ClaseEntrenamiento(36, 128, "Funcionales", new DateTime(2024, 12, 6), "10:00:00 a. m.", 10, 4502, "German"),
            new ClaseEntrenamiento(37, 123, "Zumba", new DateTime(2024, 12, 7), "8:00:00 a. m.", 10, 2502, "Tobias"),
            new ClaseEntrenamiento(38, 124, "CardioDance", new DateTime(2024, 12, 8), "10:00:00 a. m.", 10, 3002, "Bonnie"),
            new ClaseEntrenamiento(39, 125, "Funcionales", new DateTime(2024, 12, 9), "06:00:00 p. m.", 10, 4502, "Ada")
        };
    }
}

