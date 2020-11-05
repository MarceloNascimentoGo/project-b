using project_b_webapi.Models;
using System.Collections.Generic;

namespace project_b_webapi_bing.Models
{
    public class RepositorioDeCandidatos
    {
        public IList<DtoCandidato> ObtenhaCandidatos()
        {
            var oriovisto = new DtoCandidato { Id = 1, Nome = "ORIOVISTO GUIMARÃES", Partido = "PODEMOS", UF = "PR" };
            var thiago = new DtoCandidato { Id = 2, Nome = "THIAGO MITRAUD", Partido = "NOVO", UF = "MG" };
            var adriana = new DtoCandidato { Id = 3, Nome = "ADRIANA VENTURA", Partido = "NOVO", UF = "SP" };
            var vinicius = new DtoCandidato { Id = 4, Nome = "VINICIUS POIT", Partido = "NOVO", UF = "SP" };
            var lucas = new DtoCandidato { Id = 5, Nome = "LUCAS GONZALEZ", Partido = "NOVO", UF = "MG" };

            var result = new List<DtoCandidato>();
            result.Add(oriovisto);
            result.Add(thiago);
            result.Add(adriana);
            result.Add(vinicius);
            result.Add(lucas);

            return result;
           

        }
    }
}
