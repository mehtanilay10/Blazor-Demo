using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorClientSide.Pages.Session33
{
    public interface IGithubService
    {
        Task<GithubProfileDetailsModel> GetProfileDetails(string username);
    }

    public class GithubService : IGithubService
    {
        private readonly HttpClient _client;

        public GithubService(HttpClient client)
        {
            _client = client;
        }

        public async Task<GithubProfileDetailsModel> GetProfileDetails(string username)
        {
            string response = await _client.GetStringAsync($"https://api.github.com/users/{username}");
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GithubProfileDetailsModel>(response);
        }
    }
}
