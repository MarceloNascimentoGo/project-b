using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project_b_webapi.Models;
using project_b_webapi_bing.Models;

namespace project_b_webapi_bing.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PoliticosController : ControllerBase
    {
        [HttpGet]
        public IList<DtoCandidato> Get()
        {
            var repositorio = new RepositorioDeCandidatos();
            var listaDeCantidados = repositorio.ObtenhaCandidatos();

            return listaDeCantidados;
        }

        [HttpGet("{id}")]
        public DtoCandidato Get(int id)
        {
            var repositorio = new RepositorioDeCandidatos();
            var listaDeCandidatos = repositorio.ObtenhaCandidatos();
            var candidato = listaDeCandidatos.Where(x => x.Id == id).FirstOrDefault();

            return candidato;
        }

        [HttpGet("uf/{uf}")]
        public IList<DtoCandidato> Get(string uf)
        {
            var repositorio = new RepositorioDeCandidatos();
            var listaDeCandidatos = repositorio.ObtenhaCandidatos();
            var candidato = listaDeCandidatos.Where(x => x.UF.ToUpper() == uf.ToUpper());

            return candidato.ToList();
        }
        [HttpGet("nome/{nome}")]
        public IList<DtoCandidato> GetCandidatos(string nome)
        {
            var repositorio = new RepositorioDeCandidatos();
            var listaDeCandidatos = repositorio.ObtenhaCandidatos();
            var candidato = listaDeCandidatos.Where(x => x.Nome.ToUpper().Contains(nome.ToUpper()));

            return candidato.ToList();
        }

        [HttpGet("exuf/{exuf}")]
        public IList<DtoCandidato> GetExclusaoDeUf(string exuf) 
        {
            var repositorio = new RepositorioDeCandidatos();
            var listaDeCandidatos = repositorio.ObtenhaCandidatos();
            var candidato = listaDeCandidatos.Where(x => x.UF.ToUpper() != exuf.ToUpper());

            return candidato.ToList();
        }

    }
}