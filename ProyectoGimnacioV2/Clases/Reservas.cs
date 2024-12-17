using System;
using System.Collections.Generic;


namespace ManualInitializationV7
{
    public class Reserva
    {
        public int UsuarioId { get; set; }
        public int ReservaId { get; set; }
        public string ClaseNombre { get; set; }
        public DateTime FechaReserva { get; set; }

        public Reserva(int usuarioId, int reservaId, string claseNombre, DateTime fechaReserva)
        {
            UsuarioId = usuarioId;
            ReservaId = reservaId;
            ClaseNombre = claseNombre;
            FechaReserva = fechaReserva;
        }
    }

    class Program
    {
        static void Main()
        {
            // Lista de reservas
            List<Reserva> reservas = new List<Reserva>
        {
            new Reserva(1, 123, "Zumba", new DateTime(2024, 11, 1)),
            new Reserva(1, 124, "Funcionales", new DateTime(2024, 11, 15))
        };

            // Ejemplo de cómo imprimir las reservas
            foreach (var reserva in reservas)
            {
                Console.WriteLine($"Usuario ID: {reserva.UsuarioId}, Reserva ID: {reserva.ReservaId}, Clase: {reserva.ClaseNombre}, Fecha de Reserva: {reserva.FechaReserva.ToString("dd/MM/yyyy")}");
            }
        }
    }
}
