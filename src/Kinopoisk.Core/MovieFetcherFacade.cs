using System.Net.Http;
using System.Diagnostics.Metrics;

namespace Kinopoisk.Core
{
    public record MovieFetcherFacade
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

    public class KinopoiskFetcher
    {
        private readonly HttpClient httpClient;

        public KinopoiskFetcher(IHttpClientFactory HttpFac)
        {
            httpClient = HttpFac.CreateClient();
        }


    }

    public interface IQueryOptions
    {
    }
}
