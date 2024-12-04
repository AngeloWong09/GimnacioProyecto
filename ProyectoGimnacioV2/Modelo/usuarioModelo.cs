
namespace Proyecto1.Modelo
{
    public class usuarioModelo
    {

        /// <summary>
        /// Modelo que representa la estructura de un usuario en el sistema.
        /// Contiene propiedades básicas, un constructor para inicializar los datos y métodos auxiliares.
        /// </summary>
        public string NombreUsuario { get; set; } // Nombre del cliente para iniciar sesión.
        public string Contraseña { get; set; }    // Contraseña del cliente.
        public string Rol { get; set; }           // Rol del cliente .
        public string Nombre { get; set; }        // Nombre personal del cliente.
        public string Apellido1 { get; set; }     // Primer apellido del cliente.
        public string Apellido2 { get; set; }     // Segundo apellido del cliente.
        public int Id { get; set; }               // Identificador único para el cliente.
        public string Membresia { get; set; }     // Tipo de membresía asociada al cliente.
        public string ClaseID { get; set; }       // Identificador de la clase relacionado con el cliente.


        /// <summary>
        /// Constructor que inicializa un objeto de tipo usuarioModelo.
        /// </summary>
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

        /// <summary>
        /// Método que verifica si una contraseña proporcionada coincide con la del usuario.
        /// </summary>
        /// <param name="contraseña">Contraseña a verificar.</param>
        /// <returns>True si las contraseñas coinciden; False en caso contrario.</returns>
        public bool VerificarContraseña(string contraseña)
        {
            return Contraseña == contraseña;
        }
    }
}

