using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiColmenaSeguros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        IRespuestas iRespuestas;
        public ClienteController(IRespuestas irespuestas)
        {
            this.iRespuestas = irespuestas;
        }

        [HttpGet("/[Action]")]
        public ActionResult<string> CrearCuenta()
        {
            return iRespuestas.Formato("Operacion exitosa");            
        }

        [HttpGet("/[Action]")]
        public ActionResult<string> ActualizarCuenta()
        {
            return iRespuestas.Formato("Operacion exitosa");
        }

        [HttpGet("/[Action]")]
        public ActionResult<string> IniciarSesion()
        {
            return iRespuestas.Formato("Operacion exitosa");
        }

        [HttpGet("/[Action]")]
        public ActionResult<string> RecuperarContraseña()
        {
            return iRespuestas.Formato("Operacion exitosa");
        }        

        [HttpGet("/[Action]")]
        public ActionResult<string> MisCotizaciones()
        {
            return iRespuestas.Formato("Operacion exitosa");
        }

        [HttpGet("/[Action]")]
        public ActionResult<string> MisPolizas()
        {
            return iRespuestas.Formato("Operacion exitosa");
        }

        [HttpGet("/[Action]")]
        public ActionResult<string> MisCoberturas()
        {
            return iRespuestas.Formato("Operacion exitosa");
        }
    }
}
