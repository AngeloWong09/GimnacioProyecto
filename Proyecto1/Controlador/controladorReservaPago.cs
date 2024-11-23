using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto1.Controlador
{
    internal class controladorReservaPago
    {
        private List<ReservaPagoModelo> datos;

        public controladorReservaPago()
        {
            datos = new List<ReservaPagoModelo>();
            CargarDatos();
        }

        private void CargarDatos()
        {
            string rutaPagos = @"Assets/Pagos.csv"; // Archivo con meses pagados
            string rutaReservas = @"Assets/Reservas.csv"; // Archivo con reservas

            if (File.Exists(rutaPagos))
            {
                foreach (var linea in File.ReadAllLines(rutaPagos))
                {
                    var columnas = linea.Split(';');
                    if (columnas.Length >= 3) // Validar que tenga datos suficientes
                    {
                        int usuarioId = int.TryParse(columnas[0], out int tempId) ? tempId : 0;
                        string mesPagado = columnas[1].Trim();
                        string reservaId = columnas[2].Trim();

                        datos.Add(new ReservaPagoModelo(usuarioId, mesPagado, reservaId, null, DateTime.MinValue));
                    }
                }
            }

            if (File.Exists(rutaReservas))
            {
                foreach (var linea in File.ReadAllLines(rutaReservas))
                {
                    var columnas = linea.Split(';');
                    if (columnas.Length >= 5)
                    {
                        int usuarioId = int.TryParse(columnas[0], out int tempId) ? tempId : 0;
                        string reservaId = columnas[1].Trim();
                        string claseNombre = columnas[2].Trim();
                        DateTime fechaReserva = DateTime.TryParse(columnas[3].Trim(), out var tempFecha) ? tempFecha : DateTime.MinValue;

                        var reserva = datos.FirstOrDefault(d => d.UsuarioId == usuarioId && d.ReservaId == reservaId);
                        if (reserva != null)
                        {
                            reserva.ClaseNombre = claseNombre;
                            reserva.FechaReserva = fechaReserva;
                        }
                    }
                }
            }
        }

        public List<string> ObtenerMesesPagados(int usuarioId)
        {
            return datos
                .Where(d => d.UsuarioId == usuarioId && !string.IsNullOrEmpty(d.MesPagado))
                .Select(d => d.MesPagado)
                .Distinct()
                .ToList();
        }

        public List<string> ObtenerReservasDelMes(int usuarioId, string mes)
        {
            return datos
                .Where(d => d.UsuarioId == usuarioId && d.FechaReserva.ToString("MMMM") == mes)
                .Select(d => $"Clase: {d.ClaseNombre}, Fecha: {d.FechaReserva:dd/MM/yyyy}")
                .ToList();
        }
    }
}
