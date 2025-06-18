using Newtonsoft.Json;
using RogueOne.Interfaces;
using RogueOne.ViewModels;

namespace RogueOne.Logic
{
    public class InstagramLooter : IInstagramLooter
    {
        private readonly HttpClient _httpClient;
        private static IConfiguration? _mySettings;
        private readonly string? _rapidApiUri;
        public InstagramLooter(IConfiguration mySettings)
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("x-rapidapi-key", _mySettings?.GetValue<string>("ApiCredentials:RapidApiKey"));
            _httpClient.DefaultRequestHeaders.Add("x-rapidapi-host", _mySettings?.GetValue<string>("ApiCredentials:RapidApiHost"));
            _mySettings = mySettings;
            _rapidApiUri = _mySettings.GetValue<string>("ApiCredentials:RapidApiUri");
        }
        public async Task<UserDescription> GetUserId(string username)
        {

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{_rapidApiUri}id?username={username}")
            };

            using (var response = await _httpClient.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<UserDescription>(body) ?? new();
            }
        }
        public async Task<UserDetails> GetUserDetailsFromUserId(string userId)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{_rapidApiUri}reels?id={userId}&count=5")
            };

            using (var response = await _httpClient.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<UserDetails>(body) ?? new();
            }
        }
    }
}
