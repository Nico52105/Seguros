namespace Contratos.Contratos
{
    public class RespuestaGeneral<T>
    {
        public bool Error { get; set; }
        public int StatusCode { get; set; }
        public string Mensaje { get; set; }
        public T Resultado { get; set; }    
    }
}
