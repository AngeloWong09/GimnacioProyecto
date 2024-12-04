using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioPago
{
    public class CalendarioModelo   
    {
        public DateTime FechaPago { get; private set; }
        public DateTime FechaPreaviso { get; private set; }
        public bool PagoRealizado { get; private set; }

        public CalendarioModelo()
        {
            InicializarFechas();
            PagoRealizado = false;
        }

        private void InicializarFechas()  //inicializamos valores a usar 
        {
            var hoy = DateTime.Now;
            FechaPago = new DateTime(hoy.Year, hoy.Month, 29);
            FechaPreaviso = new DateTime(hoy.Year, hoy.Month, 24);

            // Ajustar si hoy es después del día 29 (ir al próximo mes)
            if (hoy > FechaPago)
            {
                FechaPago = FechaPago.AddMonths(1);
                FechaPreaviso = FechaPreaviso.AddMonths(1);
            }
        }

        public bool EsFechaPreaviso()
        {
            return DateTime.Now.Date == FechaPreaviso.Date;
        }

        public void RegistrarPago()  //revisa si el pago se realizo
        {
            PagoRealizado = true;
        }


    }
}
