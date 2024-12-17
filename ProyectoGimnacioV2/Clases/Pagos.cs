using System;
using System.Collections.Generic;



namespace ManualInitializationV6
{
    public class Pago
    {
        public int UsuarioId { get; set; }
        public string MesPago { get; set; }
        public decimal Monto { get; set; }

        public Pago(int usuarioId, string mesPago, decimal monto)
        {
            UsuarioId = usuarioId;
            MesPago = mesPago;
            Monto = monto;
        }
    }

    class Program
    {
        static void Main()
        {
            // Lista de pagos
            List<Pago> pagos = new List<Pago>
        {
            new Pago(1, "ene-24", 20000),
            new Pago(1, "feb-24", 20000),
            new Pago(2, "ene-24", 20000)
        };

            // Ejemplo de cómo imprimir los pagos
            foreach (var pago in pagos)
            {
                Console.WriteLine($"Usuario ID: {pago.UsuarioId}, Mes de Pago: {pago.MesPago}, Monto: {pago.Monto:C}");
            }
        }
    }
}