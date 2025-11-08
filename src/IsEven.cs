using System.Net.Http;

namespace IsEvenApi
{
    public class IsEven
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://api.isevenapi.xyz/api";
        public IsEven()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> CheckNumber(int number)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/iseven/{number}/");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
