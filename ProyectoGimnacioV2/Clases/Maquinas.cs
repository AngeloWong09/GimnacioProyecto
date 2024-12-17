namespace ProyectoGimnacioV2.Clases
{
    public class Maquinas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string FechaEntrada { get; set; }
        public int TiempoVida { get; set; }
        public int Ingresos { get; set; }
        public int Egresos { get; set; }
        public string RangoFechas { get; set; }

        // Método estático para obtener la lista de máquinas
        public static List<Maquinas> ObtenerMaquinas()
        {
            return new List<Maquinas>
            {

                new Maquinas { Id = 1, Nombre = "Peck Deck", FechaEntrada = "15/09/2024", TiempoVida = 3, Ingresos = 128270, Egresos = 4617, RangoFechas = "25/11/2024 - 15/02/2029" },
new Maquinas { Id = 2, Nombre = "Banca 1", FechaEntrada = "20/09/2024", TiempoVida = 3, Ingresos = 167860, Egresos = 3404, RangoFechas = "14/06/2024 - 15/04/2029" },
new Maquinas { Id = 3, Nombre = "Banca 2", FechaEntrada = "11/09/2024", TiempoVida = 3, Ingresos = 6390, Egresos = 974, RangoFechas = "01/11/2024 - 08/09/2029" },
new Maquinas { Id = 4, Nombre = "Press de Pecho", FechaEntrada = "10/09/2024", TiempoVida = 3, Ingresos = 6191, Egresos = 1582, RangoFechas = "09/02/2024 - 23/11/2029" },
new Maquinas { Id = 5, Nombre = "Polea Alta", FechaEntrada = "25/09/2024", TiempoVida = 3, Ingresos = 6734, Egresos = 3058, RangoFechas = "28/11/2024 - 11/02/2029" },
new Maquinas { Id = 6, Nombre = "Bicicleta Estática 1", FechaEntrada = "14/09/2024", TiempoVida = 3, Ingresos = 7265, Egresos = 2547, RangoFechas = "21/12/2024 - 27/05/2029" },
new Maquinas { Id = 7, Nombre = "Bicicleta Estática 2", FechaEntrada = "01/09/2024", TiempoVida = 3, Ingresos = 1466, Egresos = 3247, RangoFechas = "27/01/2024 - 19/04/2029" },
new Maquinas { Id = 8, Nombre = "Bicicleta Estática 3", FechaEntrada = "18/09/2024", TiempoVida = 3, Ingresos = 5426, Egresos = 1475, RangoFechas = "31/12/2024 - 16/06/2029" },
new Maquinas { Id = 9, Nombre = "Bicicleta Estática 4", FechaEntrada = "07/09/2024", TiempoVida = 3, Ingresos = 6578, Egresos = 2306, RangoFechas = "20/05/2024 - 13/10/2029" },
new Maquinas { Id = 10, Nombre = "Elíptica", FechaEntrada = "22/09/2024", TiempoVida = 3, Ingresos = 9322, Egresos = 6756789, RangoFechas = "25/08/2024 - 26/07/2030" },

new Maquinas { Id = 11, Nombre = "Máquina Smith 1", FechaEntrada = "10/02/2024", TiempoVida = 10, Ingresos = 2685, Egresos = 3234, RangoFechas = "16/06/2024 - 14/10/2031" },
new Maquinas { Id = 12, Nombre = "Máquina Smith 2", FechaEntrada = "05/04/2024", TiempoVida = 8, Ingresos = 1769, Egresos = 3505, RangoFechas = "07/09/2024 - 02/09/2029" },
new Maquinas { Id = 13, Nombre = "Máquina Hack 1", FechaEntrada = "15/06/2024", TiempoVida = 6, Ingresos = 7949, Egresos = 2399, RangoFechas = "14/09/2024 - 10/07/2027" },
new Maquinas { Id = 14, Nombre = "Máquina Hack 2", FechaEntrada = "25/03/2024", TiempoVida = 9, Ingresos = 3433, Egresos = 1767, RangoFechas = "18/09/2024 - 13/08/2029" },
new Maquinas { Id = 15, Nombre = "Prensa Pierna 1", FechaEntrada = "09/05/2024", TiempoVida = 7, Ingresos = 6311, Egresos = 2028, RangoFechas = "03/09/2024 - 06/07/2029" },
new Maquinas { Id = 16, Nombre = "Prensa Pierna 2", FechaEntrada = "12/08/2024", TiempoVida = 5, Ingresos = 6051, Egresos = 3702, RangoFechas = "06/01/2024 - 15/11/2031" },
new Maquinas { Id = 17, Nombre = "Caminadora 1", FechaEntrada = "25/07/2024", TiempoVida = 5, Ingresos = 7420, Egresos = 4056, RangoFechas = "02/05/2024 - 23/12/2032" },
new Maquinas { Id = 18, Nombre = "Caminadora 2", FechaEntrada = "01/01/2024", TiempoVida = 10, Ingresos = 2184, Egresos = 4390, RangoFechas = "18/03/2024 - 17/03/2027" },
new Maquinas { Id = 19, Nombre = "Máquina Remo 1", FechaEntrada = "12/02/2024", TiempoVida = 10, Ingresos = 5555, Egresos = 1146, RangoFechas = "11/06/2024 - 11/11/2028" },
new Maquinas { Id = 20, Nombre = "Máquina Remo 2", FechaEntrada = "03/03/2024", TiempoVida = 10, Ingresos = 4385, Egresos = 3388, RangoFechas = "28/06/2024 - 22/09/2029" }

            };
        }
    }
}
