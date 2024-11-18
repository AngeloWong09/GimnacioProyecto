using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Modelo
{
    internal class Administrador : Usuario
    {
        public string NivelAcceso { get; set; }

        public Administrador(int id, string nombreUsuario, string contraseña, string nivelAcceso)
            : base(id, nombreUsuario, contraseña, "Administrador")
        {
            NivelAcceso = nivelAcceso;
        }
    }
}
