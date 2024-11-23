
namespace Proyecto1.Modelo
{
    public class usuarioModelo
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int Id { get; set; }
        public string Membresia { get; set; }
        public string ClaseID { get; set; }

        public usuarioModelo(
            string nombreUsuario,
            string contraseña,
            string rol,
            string nombre,
            string apellido1,
            string apellido2,
            int id,
            string membresia,
            string usuarioID,
            string claseID)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Rol = rol;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Id = id;
            Membresia = membresia;
            ClaseID = claseID;
        }

        public bool VerificarContraseña(string contraseña)
        {
            return Contraseña == contraseña;
        }
    }
}

