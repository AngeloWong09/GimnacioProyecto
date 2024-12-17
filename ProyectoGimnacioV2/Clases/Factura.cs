
using System;
using System.Collections.Generic;

namespace ProyectoGimnacioV2.Clases
{
    public class Factura
    {
        public int Id { get; set; }
        public string ClienteNombre { get; set; }
        public string Detalle { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        public override string ToString()
        {
            return $"{Id},{ClienteNombre},{Detalle},{Monto},{Fecha.ToShortDateString()},{Estado}";
        }
    }

    public static class Facturas
    {
        public static List<Factura> ObtenerFacturasEntrenador()
        {
            return new List<Factura>
            {
                new Factura { Id = 1, ClienteNombre = "Luis Mendoza", Detalle = "Entrenamiento Fuerza", Monto = 150.00M, Fecha = new DateTime(2024, 1, 5), Estado = "Pagada" },
                new Factura { Id = 2, ClienteNombre = "Andrea García", Detalle = "Entrenamiento Personalizado", Monto = 200.00M, Fecha = new DateTime(2024, 1, 7), Estado = "Pendiente" },
            };
        }

        public static List<Factura> ObtenerFacturasCliente()
        {
            return new List<Factura>
            {
                new Factura { Id = 1, ClienteNombre = "Lucas García", Detalle = "Membresía Mensual", Monto = 50.00M, Fecha = new DateTime(2024, 1, 10), Estado = "Pagada" },
                new Factura { Id = 2, ClienteNombre = "Ana López", Detalle = "Clase de Zumba", Monto = 20.00M, Fecha = new DateTime(2024, 1, 12), Estado = "Pendiente" },
                new Factura { Id = 3, ClienteNombre = "Carlos Jiménez", Detalle = "Entrenamiento Personal", Monto = 100.00M, Fecha = new DateTime(2024, 1, 15), Estado = "Pagada" }
            };
        }

        public static List<Factura> ObtenerFacturasMaquinas()
        {
            return new List<Factura>
            {
                new Factura { Id = 1, ClienteNombre = "Gimnasio Total", Detalle = "Máquina Cardio", Monto = 1000.00M, Fecha = new DateTime(2024, 1, 8), Estado = "Pagada" },
                new Factura { Id = 2, ClienteNombre = "Gimnasio Total", Detalle = "Máquina Fuerza", Monto = 1200.00M, Fecha = new DateTime(2024, 1, 10), Estado = "Pendiente" }
            };
        }
    }
}


