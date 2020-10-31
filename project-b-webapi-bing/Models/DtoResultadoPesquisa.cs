using System.Collections.Generic;

namespace project_b_webapi.Models
{
    public class DtoResultadoPesquisa
    {
        public int Id { get; set; }
        public DtoCandidato Candidato { get; set; }
        public IList<DtoNoticia> Noticias { get; set; }
    }
}
