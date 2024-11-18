using Contratos;
using Contratos.Contratos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Negocio.Clases;
using System.Security.Permissions;
using System.Text.Json;

namespace ApiColmenaSeguros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        IRespuestas iRespuestas;
        ICliente iCliente;
        public ClienteController(
            IRespuestas irespuestas
            , ICliente icliente
        )
        {
            this.iRespuestas = irespuestas;
            this.iCliente = icliente;
        }

        [HttpPost("/[Action]")]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 200)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 401)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 500)]
        public ActionResult<RespuestaGeneral<object>> CrearCuenta(PeticionGeneral<ParametrosCrearCuenta> peticionGeneral)
        {
            return iRespuestas.Formato(this.iCliente.CrearCuenta(peticionGeneral));            
        }

        [HttpPost("/[Action]")]
        [Authorize]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 200)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 401)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 500)]
        public ActionResult<RespuestaGeneral<object>> ActualizarCuenta(PeticionGeneral<ParametrosActualizarCuenta> peticionGeneral)
        {
            TokenData tokenData= JsonSerializer.Deserialize<TokenData>(peticionGeneral.Authorization);
            return iRespuestas.Formato(tokenData.esValido? this.iCliente.ActualizarCuenta(peticionGeneral):tokenData.ErrorToken());
        }

        [HttpPost("/[Action]")]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 200)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 401)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 500)]
        public ActionResult<RespuestaGeneral<object>> IniciarSesion(PeticionGeneral<ParametrosIniciarSesion> peticionGeneral)
        {
            return iRespuestas.Formato(this.iCliente.IniciarSesion(peticionGeneral));
        }

        [HttpPost("/[Action]")]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 200)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 401)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 500)]
        public ActionResult<RespuestaGeneral<object>> RecuperarContraseña(PeticionGeneral<ParametrosRecuperarContraseña> peticionGeneral)
        {
            return iRespuestas.Formato(this.iCliente.RecuperarContraseña(peticionGeneral));
        }

        [HttpGet("/[Action]")]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 200)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 401)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 500)]
        public ActionResult<RespuestaGeneral<object>> ConsultarPoliza(PeticionGeneral<ParametrosRecuperarContraseña> peticionGeneral)
        {
            return iRespuestas.Formato(this.iCliente.ConsultarPoliza());
        }

        [HttpGet("/[Action]")]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 200)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 401)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 500)]
        public ActionResult<RespuestaGeneral<object>> CotizarPoliza(PeticionGeneral<ParametrosRecuperarContraseña> peticionGeneral)
        {
            return iRespuestas.Formato(this.iCliente.CotizarPoliza());
        }

        [HttpPost("/[Action]")]
        [Authorize]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 200)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 401)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 500)]
        public ActionResult<RespuestaGeneral<object>> MisCotizaciones(PeticionGeneral<string> peticionGeneral)
        {
            TokenData tokenData = JsonSerializer.Deserialize<TokenData>(peticionGeneral.Authorization);
            return iRespuestas.Formato(tokenData.esValido ? this.iCliente.MisCotizaciones() : tokenData.ErrorToken());
        }

        [HttpPost("/[Action]")]
        [Authorize]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 200)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 401)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 500)]
        public ActionResult<RespuestaGeneral<object>> TomarPoliza(PeticionGeneral<string> peticionGeneral)
        {
            TokenData tokenData = JsonSerializer.Deserialize<TokenData>(peticionGeneral.Authorization);
            return iRespuestas.Formato(tokenData.esValido ? this.iCliente.TomarPoliza() : tokenData.ErrorToken());
        }

        [HttpPost("/[Action]")]
        [Authorize]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 200)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 401)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 500)]
        public ActionResult<RespuestaGeneral<object>> MisPolizas(PeticionGeneral<string> peticionGeneral)
        {
            TokenData tokenData = JsonSerializer.Deserialize<TokenData>(peticionGeneral.Authorization);
            return iRespuestas.Formato(tokenData.esValido ? this.iCliente.MisPolizas() : tokenData.ErrorToken());
        }

        [HttpPost("/[Action]")]
        [Authorize]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 200)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 401)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 500)]
        public ActionResult<RespuestaGeneral<object>> MisCoberturas(PeticionGeneral<string> peticionGeneral)
        {
            TokenData tokenData = JsonSerializer.Deserialize<TokenData>(peticionGeneral.Authorization);
            return iRespuestas.Formato(tokenData.esValido ? this.iCliente.MisCoberturas() : tokenData.ErrorToken());
        }

        [HttpPost("/[Action]")]
        [Authorize]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 200)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 401)]
        [ProducesResponseType(typeof(RespuestaGeneral<object>), 500)]
        public ActionResult<RespuestaGeneral<object>> AplicarCobertura(PeticionGeneral<string> peticionGeneral)
        {
            TokenData tokenData = JsonSerializer.Deserialize<TokenData>(peticionGeneral.Authorization);
            return iRespuestas.Formato(tokenData.esValido ? this.iCliente.AplicarCobertura() : tokenData.ErrorToken());
        }
    }
}
