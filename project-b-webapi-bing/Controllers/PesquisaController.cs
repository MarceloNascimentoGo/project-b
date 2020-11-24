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
using project_b_webapi_bing.Models;

namespace project_b_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PesquisaController : ControllerBase
    {
        [HttpGet]
        public IList<string> Get()
        {
            var result = new List<string> { "Marcelo", "Marcos", "Celma", "Valquiria" };

            return result.ToArray();
        }

        [HttpGet("{id}")]
        public async Task<BingNewsResponse> Get(int id)
        {
            var client = new BingSearchClient();
            var response = await client.Request("Bolsonaro");

            return response;
        }

        [HttpGet("query/{query}")]
        public async Task<List<Value>> GetAsync(string query)
        {
            var client = new BingSearchClient();
            var response = await client.Request(query);

            return response.Value;
        }
    }
}