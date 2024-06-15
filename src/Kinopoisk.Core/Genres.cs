using System.Text.Json.Serialization;

namespace Kinopoisk.Core
{
    public class Genres(string genre)
    {
        [JsonPropertyName("genre")]
        public string Genre { get; init; } = genre;
    }
}
