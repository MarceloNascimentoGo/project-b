using System.Threading;
using System.Threading.Tasks;
using RestSharp;

namespace project_b_webapi_bing.Models
{
    public class BingSearchClient
    {
        private const string BASE_URL = "https://api.bing.microsoft.com/v7.0/news/search";

        private RestClient Client = new RestClient(BASE_URL);

        public async Task<BingNewsResponse> Request(string query)
        {
            var request = new RestRequest();
            var cancellationTokenSource = new CancellationTokenSource();

            request.AddHeader("Ocp-Apim-Subscription-Key", "{KEY}");
            request.AddParameter("q", query);

            var response = await Client.GetAsync<BingNewsResponse>(request, cancellationTokenSource.Token);

            return response;
        }
    }
}