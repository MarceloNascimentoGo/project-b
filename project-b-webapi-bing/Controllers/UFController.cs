using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project_b_webapi.Models;


namespace project_b_webapi_bing.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UFController : ControllerBase
    {
        [HttpGet]
        public IList<string> Get()
        {
            var result = new List<string> {"ORIOVISTO GUIMARÃES", "THIAGO MITRAUD", "ADRIANA VENTURA", "VINICIUS POIT", "LUCAS GONZALEZ"};

            return result.ToArray();
        }

        [HttpGet("{uf}")]
        public async Task<DtoCandidato> GetAsync(string uf)
        {

                return null;
           
        }
        
    }
}