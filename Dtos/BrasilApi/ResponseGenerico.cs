using System.Dynamic;
using System.Net;

namespace api_study.Dtos.BrasilApi
{
    public class ResponseGenerico<T>
    {
        public HttpStatusCode codigoHttp { get; set; }
        public T? dados { get; set; }

        public ExpandoObject? erroRetornoApi { get; set; }
    }
}
