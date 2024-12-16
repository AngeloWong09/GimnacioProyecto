using System;
using System.Collections.Generic;

namespace ManualInitializationV3
{
    // Clase que representa los datos de las máquinas
    public class Maquina
    {
        public string Nombre { get; set; }
        public string FechaEntrada { get; set; }
        public int TiempoVida { get; set; }
        public int Ingresos { get; set; }
        public int Egresos { get; set; }
        public string RangoFechas { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Lista para inicializar los datos manualmente
            List<Maquina> maquinas = new List<Maquina>
            {
                new Maquina { Nombre = "Peck Deck", FechaEntrada = "15/01/2024", TiempoVida = 24, Ingresos = 128270, Egresos = 4617, RangoFechas = "25/02/2024 - 15/02/2029" },
                new Maquina { Nombre = "Banca 1", FechaEntrada = "20/03/2024", TiempoVida = 18, Ingresos = 167860, Egresos = 3404, RangoFechas = "14/08/2024 - 15/04/2029" },
                new Maquina { Nombre = "Banca 2", FechaEntrada = "11/05/2024", TiempoVida = 3567686, Ingresos = 6390, Egresos = 974, RangoFechas = "01/02/2024 - 08/09/2029" },
                new Maquina { Nombre = "Press de Pecho", FechaEntrada = "10/05/2024", TiempoVida = 126743, Ingresos = 6191, Egresos = 1582, RangoFechas = "09/03/2024 - 23/11/2029" },
                new Maquina { Nombre = "Polea Alta", FechaEntrada = "25/07/2024", TiempoVida = 468788, Ingresos = 6734, Egresos = 3058, RangoFechas = "28/08/2024 - 11/02/2029" },
                new Maquina { Nombre = "Bicicleta Estática 1", FechaEntrada = "14/06/2024", TiempoVida = 36860, Ingresos = 7265, Egresos = 2547, RangoFechas = "21/09/2024 - 27/05/2029" },
                new Maquina { Nombre = "Bicicleta Estática 2", FechaEntrada = "01/08/2024", TiempoVida = 16585, Ingresos = 1466, Egresos = 3247, RangoFechas = "27/06/2024 - 19/04/2029" },
                new Maquina { Nombre = "Bicicleta Estática 3", FechaEntrada = "18/09/2024", TiempoVida = 2098760, Ingresos = 5426, Egresos = 1475, RangoFechas = "31/03/2024 - 16/06/2029" },
                new Maquina { Nombre = "Bicicleta Estática 4", FechaEntrada = "07/10/2024", TiempoVida = 454880, Ingresos = 6578, Egresos = 2306, RangoFechas = "20/02/2024 - 13/10/2029" },
                new Maquina { Nombre = "Elíptica", FechaEntrada = "22/12/2024", TiempoVida = 36, Ingresos = 9322, Egresos = 6756789, RangoFechas = "25/05/2024 - 26/07/2030" },
                new Maquina { Nombre = "Máquina Smith 1", FechaEntrada = "10/02/2024", TiempoVida = 1845478, Ingresos = 2685, Egresos = 3234, RangoFechas = "16/03/2024 - 14/10/2031" },
                new Maquina { Nombre = "Máquina Smith 2", FechaEntrada = "05/04/2024", TiempoVida = 1243654, Ingresos = 1769, Egresos = 3505, RangoFechas = "07/06/2024 - 02/09/2029" },
                new Maquina { Nombre = "Máquina Hack 1", FechaEntrada = "15/06/2024", TiempoVida = 248756, Ingresos = 7949, Egresos = 2399, RangoFechas = "14/07/2024 - 10/07/2027" },
                new Maquina { Nombre = "Máquina Hack 2", FechaEntrada = "25/03/2024", TiempoVida = 188676, Ingresos = 3433, Egresos = 1767, RangoFechas = "18/12/2024 - 13/08/2029" },
                new Maquina { Nombre = "Prensa Pierna 1", FechaEntrada = "09/05/2024", TiempoVida = 1246547, Ingresos = 6311, Egresos = 2028, RangoFechas = "03/06/2024 - 06/07/2029" },
                new Maquina { Nombre = "Prensa Pierna 2", FechaEntrada = "12/08/2024", TiempoVida = 3085774, Ingresos = 6051, Egresos = 3702, RangoFechas = "06/05/2024 - 15/11/2031" },
                new Maquina { Nombre = "Caminadora 1", FechaEntrada = "25/07/2024", TiempoVida = 4857747, Ingresos = 7420, Egresos = 4056, RangoFechas = "02/11/2024 - 23/12/2032" },
                new Maquina { Nombre = "Caminadora 2", FechaEntrada = "01/01/2024", TiempoVida = 244739, Ingresos = 2184, Egresos = 4390, RangoFechas = "18/09/2024 - 17/03/2027" },
                new Maquina { Nombre = "Máquina Remo 1", FechaEntrada = "12/02/2024", TiempoVida = 209790, Ingresos = 5555, Egresos = 1146, RangoFechas = "11/04/2024 - 11/11/2028" },
                new Maquina { Nombre = "Máquina Remo 2", FechaEntrada = "03/03/2024", TiempoVida = 183354, Ingresos = 4385, Egresos = 3388, RangoFechas = "28/12/2024 - 22/09/2029" }
            };

            // Mostrar los datos en la consola
            Console.WriteLine("Lista de Máquinas:\n");
            foreach (var maquina in maquinas)
            {
                Console.WriteLine($"Nombre: {maquina.Nombre}");
                Console.WriteLine($"Fecha Entrada: {maquina.FechaEntrada}");
                Console.WriteLine($"Tiempo de Vida: {maquina.TiempoVida}");
                Console.WriteLine($"Ingresos: {maquina.Ingresos}");
                Console.WriteLine($"Egresos: {maquina.Egresos}");
                Console.WriteLine($"Rango de Fechas: {maquina.RangoFechas}\n");
            }
        }
    }
}

