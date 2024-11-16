using Microsoft.AspNetCore.Mvc;

namespace ApiColmenaSeguros
{

    public interface IRespuestas
    {
        public ActionResult<string> Formato(string data);
    }
    public class Respuestas : ControllerBase,IRespuestas
    {
        public ActionResult<string> Formato(string data)
        {
            return Ok(data);
        }
    }
}
