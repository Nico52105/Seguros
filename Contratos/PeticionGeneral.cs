using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace Contratos.Contratos
{
    public class PeticionGeneral<T>
    {
        [FromHeader]
        public string Authorization { get; set; }

        [FromBody]
        public T Datos { get; set; }
    }

    public class TokenData
    {
        public string token { get; set; }
        public bool esValido { get; set; }
        public string mensajeToken { get; set; }

        public RespuestaGeneral<object> ErrorToken() { 
            return new RespuestaGeneral<object>() { StatusCode = 401, Mensaje = mensajeToken, Error = true,Resultado=token };
        }
    }
}
