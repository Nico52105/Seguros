using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos
{
    public class ParametrosIniciarSesion:ParametrosRecuperarContraseña
    {
        public string? Contraseña { get; set; }
    }
}
