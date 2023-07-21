using System.Dynamic;
using System.Net;

namespace ConsumirAPI.Dtos
{
    public class ResponseGenerico<T> where T : class
    {
        public HttpStatusCode CodigoHttp {get; set;}
        public T? DadosRetorno {get; set;}
        public ExpandoObject? ErroRetorno {get; set;} //ExpandoObjct - representa um objeto dinamico, ao qual em tempo de execução ele recebe algum objeto dentro dele    
        

    }
}
