using Contratos;
using Contratos.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Clases
{
    public interface ICliente
    {
        public RespuestaGeneral<object> CrearCuenta(PeticionGeneral<ParametrosCrearCuenta> peticionGeneral);
        public RespuestaGeneral<object> ActualizarCuenta(PeticionGeneral<ParametrosActualizarCuenta> peticionGeneral);
        public RespuestaGeneral<object> IniciarSesion(PeticionGeneral<ParametrosIniciarSesion> peticionGeneral);
        public RespuestaGeneral<object> RecuperarContraseña(PeticionGeneral<ParametrosRecuperarContraseña> peticionGeneral);
        public RespuestaGeneral<object> MisCotizaciones();
        public RespuestaGeneral<object> MisPolizas();
        public RespuestaGeneral<object> MisCoberturas();

    }
}
