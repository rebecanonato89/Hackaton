using Hackaton.Dominio.hackaton;
using Hackaton.Repositorio.RepositorioEF;
using Hackaton.Repositorio.RepositorioGenerico;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Hackaton.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PessoaController : ApiController
    {
        // GET: Pessoa

        [HttpGet]
        [Route("api/pessoa")]
        public IEnumerable<Pessoa> Get()
        {
            IRepositorioGenerico<Pessoa> pessoa = new RepositorioPessoa();
            return pessoa.SelecionarTodos();
        }
    }
}