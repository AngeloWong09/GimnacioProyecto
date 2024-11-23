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

        public List<maquinaModelo> Maquinas { get; private set; }

        public controladorMaquina()
        {
            InicializarMaquinas();
        }

        /// <summary>
        /// Inicializa manualmente las 20 máquinas con datos predefinidos.
        /// </summary>
        private void InicializarMaquinas()
        {
            Maquinas = new List<maquinaModelo>
            {
                new maquinaModelo("Peck Deck 1", new DateTime(2023, 1, 15), 24),
                new maquinaModelo("Banca 1", new DateTime(2023, 3, 20), 18),
                new maquinaModelo("Banca 2", new DateTime(2022, 11, 5), 36),
                new maquinaModelo("Press de Pecho", new DateTime(2023, 5, 10), 12),
                new maquinaModelo("Polea Alta", new DateTime(2021, 7, 25), 48),
                new maquinaModelo("Bicicleta Estatica 1", new DateTime(2022, 6, 14), 30),
                new maquinaModelo("Bicicleta Estatica 2", new DateTime(2023, 8, 1), 15),
                new maquinaModelo("Bicicleta Estatica 3", new DateTime(2023, 9, 18), 20),
                new maquinaModelo("Bicicleta Estatica 4", new DateTime(2022, 10, 7), 40),
                new maquinaModelo("Eliptica", new DateTime(2021, 12, 22), 36),
                new maquinaModelo("Máquina Smith 1", new DateTime(2023, 2, 10), 18),
                new maquinaModelo("Máquina Smith 2", new DateTime(2023, 4, 5), 12),
                new maquinaModelo("Máquina Hack 1", new DateTime(2023, 6, 15), 24),
                new maquinaModelo("Máquina Hack 2", new DateTime(2023, 3, 25), 18),
                new maquinaModelo("Prensa Pierna 1", new DateTime(2023, 5, 9), 12),
                new maquinaModelo("Prensa Pierna 2", new DateTime(2022, 8, 12), 30),
                new maquinaModelo("Caminadora 1", new DateTime(2021, 7, 25), 48),
                new maquinaModelo("Caminadora 2", new DateTime(2023, 1, 1), 24),
                new maquinaModelo("Máquina Remo 1", new DateTime(2023, 2, 12), 20),
                new maquinaModelo("Máquina Remo 2", new DateTime(2023, 3, 3), 18)
            };
        }

        /// <summary>
        /// Obtiene la lista de máquinas que están por caducar en los próximos 3 meses.
        /// </summary>
        /// <returns>Lista de máquinas que requieren atención.</returns>
        public List<maquinaModelo> ObtenerMaquinasPorCaducar()
        {
            DateTime fechaActual = DateTime.Now;
            return Maquinas.Where(m => (m.FechaCaducidad - fechaActual).TotalDays <= 90).ToList();
        }
    }
}
