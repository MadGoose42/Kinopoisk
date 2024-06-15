namespace Kinopoisk.Core
{
    public class KinopoiskFetcher
    {
        private readonly HttpClient httpClient;

        private const string _baseUrl = "https://kinopoiskapiunofficial.tech/api/v2.2";


        public KinopoiskFetcher(IHttpClientFactory HttpFac)
        {
            httpClient = HttpFac.CreateClient();
        }



    }
}
