using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioPago
{
    public class calendarioControlador
    {
        private readonly CalendarioModelo _modelo;

        public calendarioControlador(CalendarioModelo modelo)
        {
            _modelo = modelo;
        }

        public string ObtenerFechaPago()
        {
            return _modelo.FechaPago.ToString("dd/MM/yyyy");
        }

        public string ObtenerFechaPreaviso()
        {
            return _modelo.FechaPreaviso.ToString("dd/MM/yyyy");
        }

        public bool VerificarPreaviso()
        {
            return _modelo.EsFechaPreaviso();
        }

        public bool VerificarFechaPago()
        {
            return DateTime.Now.Date == _modelo.FechaPago.Date;
        }

        public void RealizarPago()
        {
            _modelo.RegistrarPago();
        }
    }
}