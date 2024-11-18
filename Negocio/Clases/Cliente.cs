using Contratos;
using Contratos.Contratos;
using Datos.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio.Clases
{
    public class Cliente: ICliente
    {
        ColmenaSegurosContext colmenaSegurosContext;
        IConfiguration configuration;

        public Cliente(IConfiguration iconfiguration, ColmenaSegurosContext colmenaSegurosContext)
        {
            this.colmenaSegurosContext = colmenaSegurosContext;
            this.configuration = iconfiguration;
        }
        public RespuestaGeneral<object> CrearCuenta(PeticionGeneral<ParametrosCrearCuenta> peticionGeneral)
        {
            RespuestaGeneral<object> respuesta = new RespuestaGeneral<object>();
            try
            {
                Datos.Entidades.Cliente nuevoCliente= new Datos.Entidades.Cliente();
                nuevoCliente.Nombre = peticionGeneral.Datos.Nombre;
                nuevoCliente.Email = peticionGeneral.Datos.Email;
                nuevoCliente.Usuario = peticionGeneral.Datos.Usuario;
                nuevoCliente.Contraseña = peticionGeneral.Datos.Contraseña;
                nuevoCliente.Telefono = peticionGeneral.Datos.Telefono;
                nuevoCliente.Direccion = peticionGeneral.Datos.Direccion;
                
                colmenaSegurosContext.Clientes.Add(nuevoCliente);
                colmenaSegurosContext.SaveChanges();
                respuesta.StatusCode = StatusCodes.Status200OK;
                respuesta.Mensaje = "Operacion exitosa al momento de CrearCuenta";
                respuesta.Error = false;
                respuesta.Resultado = peticionGeneral.Datos;
            }
            catch (Exception ex)
            {
                respuesta.StatusCode = StatusCodes.Status500InternalServerError;
                respuesta.Mensaje = "Operacion fallida al momento de CrearCuenta";
                respuesta.Error = true;
                respuesta.Resultado = ex.Message;
            }
            return respuesta;
        }

        public RespuestaGeneral<object> ActualizarCuenta(PeticionGeneral<ParametrosActualizarCuenta> peticionGeneral)
        {
            RespuestaGeneral<object> respuesta = new RespuestaGeneral<object>();
            try
            {
                Datos.Entidades.Cliente? cliente = colmenaSegurosContext.Clientes.Find(peticionGeneral.Datos.Id);
                if (cliente!=null)
                {
                    cliente.Nombre = peticionGeneral.Datos.Nombre;
                    cliente.Email = peticionGeneral.Datos.Email;
                    cliente.Usuario = peticionGeneral.Datos.Usuario;
                    cliente.Contraseña = peticionGeneral.Datos.Contraseña;
                    cliente.Telefono = peticionGeneral.Datos.Telefono;
                    cliente.Direccion = peticionGeneral.Datos.Direccion;
                }
                else
                {
                    throw new Exception("No se encontro el cliente");
                }

                colmenaSegurosContext.Clientes.Update(cliente);
                colmenaSegurosContext.SaveChanges();
                respuesta.StatusCode = StatusCodes.Status200OK;
                respuesta.Mensaje = "Operacion exitosa al momento de ActualizarCuenta";
                respuesta.Error = false;
                respuesta.Resultado = peticionGeneral.Datos;
            }
            catch (Exception ex)
            {
                respuesta.StatusCode = StatusCodes.Status500InternalServerError;
                respuesta.Mensaje = "Operacion fallida al momento de ActualizarCuenta";
                respuesta.Error = true;
                respuesta.Resultado = ex.Message;
            }
            return respuesta;
        }

        public RespuestaGeneral<object> IniciarSesion(PeticionGeneral<ParametrosIniciarSesion> peticionGeneral)
        {
            RespuestaGeneral<object> respuesta = new RespuestaGeneral<object>();
            try
            {
                Datos.Entidades.Cliente? cliente = colmenaSegurosContext.Clientes.Where(
                    c=>c.Usuario== peticionGeneral.Datos.Usuario 
                    && c.Contraseña== peticionGeneral.Datos.Contraseña
                    ).FirstOrDefault();
                if (cliente != null)
                {
                    respuesta.StatusCode = StatusCodes.Status200OK;
                    respuesta.Mensaje = "Operacion exitosa al momento de IniciarSesion";
                    respuesta.Error = false;
                    AutenticacionJWT autenticacionJWT = new AutenticacionJWT(this.configuration);
                    respuesta.Resultado = autenticacionJWT.GenerarToken(cliente);
                }
                else
                {
                    throw new Exception("Ha introducido un nombre de usuario o una contraseña incorrectos.");
                }

                
                
            }
            catch (Exception ex)
            {
                respuesta.StatusCode = StatusCodes.Status500InternalServerError;
                respuesta.Mensaje = "Operacion fallida al momento de IniciarSesion";
                respuesta.Error = true;
                respuesta.Resultado = ex.Message;
            }
            return respuesta;
        }

        public RespuestaGeneral<object> RecuperarContraseña(PeticionGeneral<ParametrosRecuperarContraseña> peticionGeneral)
        {
            RespuestaGeneral<object> respuesta = new RespuestaGeneral<object>();
            try
            {
                Datos.Entidades.Cliente? cliente = colmenaSegurosContext.Clientes.Where(
                    c => c.Usuario == peticionGeneral.Datos.Usuario
                    ).FirstOrDefault();
                if (cliente != null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ejetutar proceso para recuperar contraseña");
                    Console.ForegroundColor = default;

                }
                respuesta.StatusCode = StatusCodes.Status200OK;
                respuesta.Mensaje = "Operacion exitosa al momento de RecuperarContraseña";
                respuesta.Error = false;
                respuesta.Resultado = "Enviamos un correo a tu cuenta, para que puedas recuperar tu contraseña.";
            }
            catch (Exception ex)
            {
                respuesta.StatusCode = StatusCodes.Status500InternalServerError;
                respuesta.Mensaje = "Operacion fallida al momento de RecuperarContraseña";
                respuesta.Error = true;
                respuesta.Resultado = ex.Message;
            }
            return respuesta;
        }

        public RespuestaGeneral<object> ConsultarPoliza()
        {
            RespuestaGeneral<object> respuesta = new RespuestaGeneral<object>();
            respuesta.StatusCode = 200;
            respuesta.Mensaje = "Operacion exitosa";
            respuesta.Error = false;
            respuesta.Resultado = "Operacion exitosa";
            return respuesta;
        }
        public RespuestaGeneral<object> CotizarPoliza()
        {
            RespuestaGeneral<object> respuesta = new RespuestaGeneral<object>();
            respuesta.StatusCode = 200;
            respuesta.Mensaje = "Operacion exitosa";
            respuesta.Error = false;
            respuesta.Resultado = "Operacion exitosa";
            return respuesta;
        }
        public RespuestaGeneral<object> MisCotizaciones()
        {
            RespuestaGeneral<object> respuesta = new RespuestaGeneral<object>();
            respuesta.StatusCode = 200;
            respuesta.Mensaje = "Operacion exitosa";
            respuesta.Error = false;
            respuesta.Resultado = "Operacion exitosa";
            return respuesta;
        }

        public RespuestaGeneral<object> TomarPoliza()
        {
            RespuestaGeneral<object> respuesta = new RespuestaGeneral<object>();
            respuesta.StatusCode = 200;
            respuesta.Mensaje = "Operacion exitosa";
            respuesta.Error = false;
            respuesta.Resultado = "Operacion exitosa";
            return respuesta;
        }

        public RespuestaGeneral<object> MisPolizas()
        {
            RespuestaGeneral<object> respuesta = new RespuestaGeneral<object>();
            respuesta.StatusCode = 200;
            respuesta.Mensaje = "Operacion exitosa";
            respuesta.Error = false;
            respuesta.Resultado = "Operacion exitosa";
            return respuesta;
        }

        public RespuestaGeneral<object> MisCoberturas()
        {
            RespuestaGeneral<object> respuesta = new RespuestaGeneral<object>();
            respuesta.StatusCode = 200;
            respuesta.Mensaje = "Operacion exitosa";
            respuesta.Error = false;
            respuesta.Resultado = true;
            return respuesta;
        }

        public RespuestaGeneral<object> AplicarCobertura()
        {
            RespuestaGeneral<object> respuesta = new RespuestaGeneral<object>();
            respuesta.StatusCode = 200;
            respuesta.Mensaje = "Operacion exitosa";
            respuesta.Error = false;
            respuesta.Resultado = true;
            return respuesta;
        }
    }
}
