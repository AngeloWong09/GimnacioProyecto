using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Modelo
{
    internal class maquinaModelo
    {//propiedades
        public string Nombre { get; set; }
        public DateTime FechaEntrada { get; private set; }
        public int TiempoVidaMeses { get; private set; }
        public DateTime FechaCaducidad { get; private set; }

        public maquinaModelo(string nombre, DateTime fechaEntrada, int tiempoVidaMeses)
        { //contructor con los valores requeridos
            Nombre = nombre;
            FechaEntrada = fechaEntrada;
            TiempoVidaMeses = tiempoVidaMeses;
            FechaCaducidad = FechaEntrada.AddMonths(TiempoVidaMeses);
        }

        public bool QuedanTresMeses()
        {
            return FechaCaducidad <= DateTime.Now.AddMonths(3);
        }}}

  