

namespace Proyecto1.Modelo
{
    /// <summary>
    /// Representa a un entrenador dentro del sistema del Gimnacio.
    /// </summary>
    internal class entrenadorModelo
    {
        // Propiedades del entrenador.
        public string NombreUsuario { get; private set; }
        public string Contraseña { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public int Id { get; private set; }
        public string PuntosFuertes { get; private set; }

        /// <summary>
        /// Constructor para inicializar un objeto de tipo EntrenadorModelo.
        /// </summary>
        /// <param name="nombreUsuario">Nombre de usuario del entrenador.</param>
        /// <param name="contraseña">Contraseña del entrenador.</param>
        /// <param name="nombre">Nombre del entrenador.</param>
        /// <param name="apellido">Apellido del entrenador.</param>
        /// <param name="id">ID único del entrenador.</param>
        /// <param name="puntosFuertes">Puntos fuertes del entrenador.</param>
        public entrenadorModelo(string nombreUsuario, string contraseña, string nombre, string apellido, int id, string puntosFuertes)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Nombre = nombre;
            Apellido = apellido;
            Id = id;
            PuntosFuertes = puntosFuertes;
        }
    }
}
