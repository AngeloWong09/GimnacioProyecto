
namespace Proyecto1.Modelo
{
    internal class usuarioModelo
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }

        public usuarioModelo(int id, string nombreUsuario, string contraseña, string rol)
        {
            Id = id;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Rol = rol;
        }

        public bool VerificarContraseña(string contraseña)
        {
            return Contraseña == contraseña;
        }
    }
}
