using Contratos.Contratos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Seguridad
{
    public class ValidarTokenCliente : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public ValidarTokenCliente(
            IOptionsMonitor<AuthenticationSchemeOptions> options
            , ILoggerFactory logger
            , UrlEncoder encoder
            , ISystemClock clock
        ) : base(options, logger, encoder, clock)
        {}

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var token = Request.Headers.ContainsKey("Authorization") ? Request.Headers["Authorization"].ToString():string.Empty;
            Request.Headers.Remove("Authorization");
            return ValidarToken(token);
        }
        public AuthenticateResult ValidarToken(string token)
        {
            try
            {
                var claims = new List<Claim>();
                TokenData tokenData = new TokenData();
                tokenData.token = token;
                tokenData.esValido = false;                
                if (token != string.Empty)
                {
                    if (!true)
                    {
                        claims.Add(new Claim(ClaimTypes.Name, "Usuario"));
                        claims.Add(new Claim(ClaimTypes.Role, "Cliente"));   
                    }
                    else
                    {                        
                        tokenData.mensajeToken = "El token no es valido.";
                        Request.Headers["Authorization"] = JsonSerializer.Serialize(tokenData);
                    }
                }
                else 
                {
                    tokenData.mensajeToken = "No se encontró el token de autorización.";
                    Request.Headers["Authorization"] = JsonSerializer.Serialize(tokenData);
                }
                var identity = new ClaimsIdentity(claims, Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);
                return AuthenticateResult.Success(ticket);
            }
            catch (Exception ex)
            {

                return AuthenticateResult.Fail(ex.Message);
            }

        }
    }
}
