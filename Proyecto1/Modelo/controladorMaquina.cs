using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Controlador
{
    internal class controladorMaquina
    {

        public List<MaquinaModelo> Maquinas { get; private set; }

        public controladorMaquina()
        {
            InicializarMaquinas();
        }

        /// <summary>
        /// Inicializa manualmente las 20 máquinas con datos predefinidos.
        /// </summary>
        private void InicializarMaquinas()
        {
            Maquinas = new List<MaquinaModelo>
            {
                new MaquinaModelo("Peck Deck 1", new DateTime(2023, 1, 15), 24),
                new MaquinaModelo("Banca 1", new DateTime(2023, 3, 20), 18),
                new MaquinaModelo("Banca 2", new DateTime(2022, 11, 5), 36),
                new MaquinaModelo("Press de Pecho", new DateTime(2023, 5, 10), 12),
                new MaquinaModelo("Polea Alta", new DateTime(2021, 7, 25), 48),
                new MaquinaModelo("Bicicleta Estatica 1", new DateTime(2022, 6, 14), 30),
                new MaquinaModelo("Bicicleta Estatica 2", new DateTime(2023, 8, 1), 15),
                new MaquinaModelo("Bicicleta Estatica 3", new DateTime(2023, 9, 18), 20),
                new MaquinaModelo("Bicicleta Estatica 4", new DateTime(2022, 10, 7), 40),
                new MaquinaModelo("Eliptica", new DateTime(2021, 12, 22), 36),
                new MaquinaModelo("Máquina Smith 1", new DateTime(2023, 2, 10), 18),
                new MaquinaModelo("Máquina Smith 2", new DateTime(2023, 4, 5), 12),
                new MaquinaModelo("Máquina Hack 1", new DateTime(2023, 6, 15), 24),
                new MaquinaModelo("Máquina Hack 2", new DateTime(2023, 3, 25), 18),
                new MaquinaModelo("Prensa Pierna 1", new DateTime(2023, 5, 9), 12),
                new MaquinaModelo("Prensa Pierna 2", new DateTime(2022, 8, 12), 30),
                new MaquinaModelo("Caminadora 1", new DateTime(2021, 7, 25), 48),
                new MaquinaModelo("Caminadora 2", new DateTime(2023, 1, 1), 24),
                new MaquinaModelo("Máquina Remo 1", new DateTime(2023, 2, 12), 20),
                new MaquinaModelo("Máquina Remo 2", new DateTime(2023, 3, 3), 18)
            };
        }

        /// <summary>
        /// Obtiene la lista de máquinas que están por caducar en los próximos 3 meses.
        /// </summary>
        /// <returns>Lista de máquinas que requieren atención.</returns>
        public List<MaquinaModelo> ObtenerMaquinasPorCaducar()
        {
            DateTime fechaActual = DateTime.Now;
            return Maquinas.Where(m => (m.FechaCaducidad - fechaActual).TotalDays <= 90).ToList();
        }
    }
}
