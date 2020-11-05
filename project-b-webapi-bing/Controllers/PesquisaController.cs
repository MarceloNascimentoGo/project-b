using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project_b_webapi.Models;

namespace project_b_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PesquisaController : ControllerBase
    {
        [HttpGet]
        public IList<string> Get()
        {
            var result = new List<string> {"Marcelo", "Marcos", "Celma", "Valquiria"};

            return result.ToArray();
        }

        [HttpGet("{id}")]
        public async Task<DtoResultadoPesquisa> GetAsync(int id)
        {
            var result = new DtoResultadoPesquisa
            {
                Id = 145714,
                Candidato = new DtoCandidato { Id = 88, Nome = "LULULUL", Partido = "PT", UF = "RJ" },
                Noticias = new List<DtoNoticia> () 
                {
                    new DtoNoticia { Corpo = "Lula corrupto bla bla bla", Titulo = "Lula condenado bla bla bla", Imagem = "https://media.gazetadopovo.com.br/2018/04/db4331c5568be0a7a0a82602ff2f25a1-gpMedium.jpg"},
                    new DtoNoticia { Corpo = "Bolsonaro corrupto bla bla bla", Titulo = "Bolsonaro condenado bla bla bla", Imagem = "https://lh3.googleusercontent.com/proxy/CQNLceqsuuD3aRhxn9oKRBIONhWUeqMoLlEXRsDqomabPiUSZ2GNBXq47HWXHsRDP46XckwmxGGbkQHndfpeOwErluLwbDJp9AGO_yWkkdX9_1HK8NUSytWmGfoLTyldz5hWcx4"}
                }
            };

            return result;
        }
    }
}