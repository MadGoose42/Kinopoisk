using System.Text.Json.Serialization;

namespace Kinopoisk.Core
{
    public class Countries(string country)
    {
        [JsonPropertyName("country")]
        public string Country { get; init; } = country;
    }
}
