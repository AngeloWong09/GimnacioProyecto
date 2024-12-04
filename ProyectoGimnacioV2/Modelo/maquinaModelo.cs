using System;

namespace Proyecto1.Controlador
{
    internal class MaquinaModelo
    {
        //propiedades
        public string Nombre { get; set; }
        public DateTime FechaEntrada { get; private set; }
        public int TiempoVidaMeses { get; private set; }
        public DateTime FechaCaducidad { get; private set; }

        public MaquinaModelo(string nombre, DateTime fechaEntrada, int tiempoVidaMeses)
        { //contructor con los valores requeridos
            Nombre = nombre;
            FechaEntrada = fechaEntrada;
            TiempoVidaMeses = tiempoVidaMeses;
            FechaCaducidad = FechaEntrada.AddMonths(TiempoVidaMeses);
        }

        public bool QuedanTresMeses()
        {
            return FechaCaducidad <= DateTime.Now.AddMonths(3);
        }
}
}