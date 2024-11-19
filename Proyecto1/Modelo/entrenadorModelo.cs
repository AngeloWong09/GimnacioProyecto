

namespace Proyecto1.Modelo
{
    internal class entrenadorModelo : usuarioModelo
    {
        public string Horario { get; set; }
        public string PuntosFuertes { get; set; }

        public entrenadorModelo(int id, string nombreUsuario, string contraseña, string horario, string puntosFuertes)
         : base(id, nombreUsuario, contraseña, "Entrenador")
        {
            Horario = horario;
            PuntosFuertes = puntosFuertes;
        }
    }
}
