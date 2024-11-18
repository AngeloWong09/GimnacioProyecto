

namespace Proyecto1.Modelo
{
    internal class Entrenador : Usuario
    {
        public string Horario { get; set; }
        public string PuntosFuertes { get; set; }

        public Entrenador(int id, string nombreUsuario, string contraseña, string horario, string puntosFuertes)
         : base(id, nombreUsuario, contraseña, "Entrenador")
        {
            Horario = horario;
            PuntosFuertes = puntosFuertes;
        }
    }
}
