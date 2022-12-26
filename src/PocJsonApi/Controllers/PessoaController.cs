using JsonApiSerializer.JsonApi;
using JsonApiSerializer.JsonConverters;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PocJsonApi.Models;

namespace PocJsonApi.Controllers
{
    [ApiController]
    [Route("pessoas")]
    public class PessoaController : Controller
    {
        [HttpGet]
        [ProducesResponseType(typeof(DocumentRoot<Pessoa>), 200)]
        public IActionResult Teste()
        {
            var pessoaExemplo = Pessoa.CriarExemplo(totalEnderecos: Random.Shared.Next(minValue: 1, maxValue: 5));

            return Ok(pessoaExemplo);
        }

        [HttpPost]
        [ProducesResponseType(typeof(DocumentRoot<Pessoa>), 200)]
        public IActionResult TestePost([FromBody] DocumentRoot<Pessoa> pessoa)
        {
            return Ok(pessoa);
        }
    }
}