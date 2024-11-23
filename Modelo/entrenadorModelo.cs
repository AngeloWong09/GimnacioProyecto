

namespace Proyecto1.Modelo
{
    internal class entrenadorModelo
    {
        // Propiedades de la clase
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id { get; set; }  // El ID va después del Apellido
        public string PuntosFuertes { get; set; }
        public string Horario { get; set; }

        // Constructor actualizado, manteniendo el orden correcto
        public entrenadorModelo(string nombreUsuario, string contraseña, string nombre, string apellido, int id, string puntosFuertes, string horario)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Nombre = nombre;
            Apellido = apellido;
            Id = id;  // ID después del Apellido
            PuntosFuertes = puntosFuertes;
            Horario = horario;
        }
    }
}
