using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Modelo que representa la estructura de un administrador en el sistema de el Gimnacio
/// </summary>
namespace Proyecto1.Modelo
{
        internal class administradorModelo
        {
            public string NombreUsuario { get; set; }
            public string Contraseña { get; set; }
            public string Nombre { get; set; }
            public string Apellido1 { get; set; }
            public int Id { get; set; }
     

        /// <summary>
        /// Constructor que inicializa las propiedades básicas del administrador con los valores proporcionados.
        /// </summary>
        public administradorModelo(int id, string nombreUsuario, string contraseña, string nivelAcceso, string nombre, string apellido)
            {
                NombreUsuario = nombreUsuario;
                Contraseña = contraseña;
                Nombre = nombre;
                Apellido1 = apellido;  // Utilizamos apellido para Apellido1
                Id = id;
        }
        }
}
