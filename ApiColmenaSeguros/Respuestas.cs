using Contratos.Contratos;
using Microsoft.AspNetCore.Mvc;

namespace ApiColmenaSeguros
{

    public interface IRespuestas
    {
        public ActionResult<RespuestaGeneral<object>> Formato(RespuestaGeneral<object> respuesta);
    }
    public class Respuestas : ControllerBase,IRespuestas
    {
        public ActionResult<RespuestaGeneral<object>> Formato(RespuestaGeneral<object> respuesta)
        {
            switch (respuesta.StatusCode)
            {
                case StatusCodes.Status200OK:
                    return Ok(respuesta);
                case StatusCodes.Status401Unauthorized:
                    return Unauthorized(respuesta);
                case StatusCodes.Status500InternalServerError:
                    return StatusCode(StatusCodes.Status500InternalServerError, respuesta);
                default:
                    return NoContent();
            }
        }
    }
}
