using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Modelo
{
    internal class ReservaPagoModelo
    {

        public int UsuarioId { get; set; }
        public string MesPagado { get; set; }
        public string ReservaId { get; set; }
        public string ClaseNombre { get; set; }
        public DateTime FechaReserva { get; set; }

        public ReservaPagoModelo(int usuarioId, string mesPagado, string reservaId, string claseNombre, DateTime fechaReserva)
        {
            UsuarioId = usuarioId;
            MesPagado = mesPagado;
            ReservaId = reservaId;
            ClaseNombre = claseNombre;
            FechaReserva = fechaReserva;
        }
    }
}
