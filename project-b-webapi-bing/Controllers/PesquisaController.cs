using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.CognitiveServices.Search.CustomSearch;
using Microsoft.Azure.CognitiveServices.Search.CustomSearch.Models;
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
            var result = new List<string> {"Marcelo", "Marcos", "Celma"};

            return result.ToArray();
        }

        [HttpGet("{id}")]
        public async Task<DtoResultadoPesquisa> GetAsync(int id)
        {
            string subscriptionKey = "04320c3a-437f-4a75-af5f-e5e2b6aaf002";
            var credential = new ApiKeyServiceClientCredentials(subscriptionKey);
            var client = new CustomSearchClient(credential);
            var webData = await client.CustomInstance.SearchAsync("0", "Bolsonaro");
            if (webData?.WebPages?.Value?.Count > 0)
            {
                var firstWebPagesResult = webData.WebPages.Value.FirstOrDefault();

                if (firstWebPagesResult != null)
                {
                    Console.WriteLine(firstWebPagesResult.WebSearchUrl);
                }
                else
                {
                    Console.WriteLine("Couldn't find web results!");
                }
            }
            else
            {
                Console.WriteLine("Didn't see any Web data..");
            }

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