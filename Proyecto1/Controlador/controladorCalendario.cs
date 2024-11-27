using CalendarioPago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Controlador
{
    
    public class controladorCalendario
    {
        private readonly CalendarioModelo _modelo;


        public controladorCalendario(CalendarioModelo modelo)
        {
            _modelo = modelo;
        }



        public string ObtenerFechaPago()  //metodo que obtiene fecha pago
        {
            return _modelo.FechaPago.ToString("dd/MM/yyyy");
        }

        public string ObtenerFechaPreaviso()  //metodo que obtiene fecha preaviso
        {
            return _modelo.FechaPreaviso.ToString("dd/MM/yyyy");
        }
        public bool VerificarPreaviso()  //metodo de verificar preaviso
        {
            return _modelo.EsFechaPreaviso();
        }
        public bool VerificarFechaPago()  //metodo verificar fecha pago
        {
            return DateTime.Now.Date == _modelo.FechaPago.Date;
        }

        public void RealizarPago()  //metodo hacer pago
        {
            _modelo.RegistrarPago();
        }
    }
}

