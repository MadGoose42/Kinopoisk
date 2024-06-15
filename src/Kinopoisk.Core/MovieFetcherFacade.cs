using System.Net.Http;
using System.Diagnostics.Metrics;
using static System.Net.WebRequestMethods;

namespace Kinopoisk.Core
{
    public record MovieFetcherFacade (IMovieApiFetcher Fetcher)
    {
        //private readonly HttpClient httpClient;

        //public MovieFetcherFacade(IHttpClientFactory HttpFac)
        //{
        //    httpClient = HttpFac.CreateClient();
        //}

        public IEnumerable<IKinoItem> GetMovieSet()
        {
            throw null;
        }

        public IEnumerable<IKinoItem> GetMovieSet(IQueryOptions options)
        {
            throw null;
        }
    }
}
