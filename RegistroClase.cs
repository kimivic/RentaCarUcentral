using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;

namespace Proyecto
{
    internal class RegistroClase
    {
        private string nombreUsuario;
        private string contraseñaUsuario;
        private string contraseñaUsuarioConfirmacion;

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string ContraseñaUsuario { get => contraseñaUsuario; set => contraseñaUsuario = value; }
        public string ContraseñaUsuarioConfirmacion { get => contraseñaUsuarioConfirmacion; set => contraseñaUsuarioConfirmacion = value; }

    }
}
