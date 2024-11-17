using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Controlador
{
    internal class controladorUsuario
    {

        private List<Usuario> usuarios;

        public controladorUsuario()
        {
            usuarios = new List<Usuario>();
            InicializarUsuarios();
        }

        private void InicializarUsuarios()
        {
            // Agregar 2 administradores
            usuarios.Add(new Usuario(1, "admin1", "Gimnacioñ12", "Administrador"));
            usuarios.Add(new Usuario(2, "admin2", "Gimnacioñ13", "Administrador"));

            // Agregar 6 entrenadores 
            usuarios.Add(new Entrenador(1, "Carlos", "password3", "08:00-12:00", "Cardio"));
            usuarios.Add(new Entrenador(2, "Tobias", "password4", "10:00-14:00", "Zumba"));
            usuarios.Add(new Entrenador(3, "Luis", "password4", "15:00-19:00", "funcionales"));
            usuarios.Add(new Entrenador(4, "Miguel", "password4", "08:00-12:00", "Cardio"));
            usuarios.Add(new Entrenador(5, "Raul", "password4", "10:00-14:00", "Pesas"));
            usuarios.Add(new Entrenador(6, "Gabril", "password4", "15:00-19:00", "Zumba"));

        }

        public Usuario IniciarSesion(string nombreUsuario, string contraseña)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.NombreUsuario == nombreUsuario && usuario.VerificarContraseña(contraseña))
                {
                    return usuario;
                }
            }
            return null; // Retorna null si no se encuentra el usuario o la contraseña es incorrecta
        }
    }
}

