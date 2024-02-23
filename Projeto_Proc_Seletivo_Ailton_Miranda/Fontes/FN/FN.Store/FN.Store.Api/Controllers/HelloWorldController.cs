using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace FN.Store.Api.Controllers
{

    [RoutePrefix("api/v1/helloworld")]
    public class HelloWorldController:ApiController
    {
        //Verbo Get -> geralmente é só para obter informações
        //Só traféga dados pela URL

        [Route]
        public string Get()
        {
            return "Bateu no Get do HelloWorldController";
        }

        [Route("{id}")]
        public string Get(int id)
        {
            return $"Bateu no Get do HelloWorldController com o id {id}.";
        }

        //POST - Geralmente é usado só para adicionar algo
        //Para receber um tipo primitivo no parâmetro do POST, precisar ter o [FromBody]
        [Route]
        public string Post(HelloWorld model)
        {
            return $"POST - {model.Id} - {model.Nome} - {model.Idade}";
        }

        //PUT - Geralmente é usado para alterar um recurso
        //Vc pode enviar informações pelo Body e pela URL
        [Route("{id}")]
        public string Put(int id, HelloWorld model)
        {
            return $"PUT - {id} - {model.Nome} - {model.Idade}";
        }

        //Delete => Geralmente só para excluir recursos
        [Route("{id}")]
        public string Delete(int id)
        {
            return $"Delete - {id}";
        }


    }

    public class HelloWorld
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }


}
