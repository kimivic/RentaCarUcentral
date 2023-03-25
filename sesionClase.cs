using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class sesionClase
    {
        private string usuarioSesion;
        private string contrasenaSesion;

        public string Usuario { get => usuarioSesion; set => usuarioSesion = value; }
        public string Contrasena { get => contrasenaSesion; set => contrasenaSesion = value; }
    }
}
