using System.Text.Json.Serialization;

namespace Kinopoisk.Core
{
    public interface IKinoItem
    {
        [JsonPropertyName("kinopoiskId")]
        public int KinopoiskId { get; init; }

        [JsonPropertyName("kinopoiskHDId")]
        public string? KinopoiskHDId { get; init; }

        [JsonPropertyName("imdbId")]
        public string? ImdbId { get; init; }

        [JsonPropertyName("nameRu")]
        public string? NameRu { get; init; }

        [JsonPropertyName("nameEn")]
        public string? NameEn { get; init; }

        [JsonPropertyName("nameOriginal")]
        public string? NameOriginal { get; init; }

        [JsonPropertyName("posterUrl")]
        public string PosterUrl { get; init; }

        [JsonPropertyName("posterUrlPreview")]
        public string PosterUrlPreview { get; init; }

        [JsonPropertyName("coverUrl")]
        public string? CoverUrl { get; init; }

        [JsonPropertyName("logoUrl")]
        public string? LogoUrl { get; init; }

        [JsonPropertyName("reviewsCount")]
        public int ReviewsCount { get; init; }

        [JsonPropertyName("ratingGoodReview")]
        public double? RatingGoodReview { get; init; }

        [JsonPropertyName("ratingGoodReviewVoteCount")]
        public int? RatingGoodReviewVoteCount { get; init; }

        [JsonPropertyName("ratingKinopoisk")]
        public double? RatingKinopoisk { get; init; }

        [JsonPropertyName("ratingKinopoiskVoteCount")]
        public int? RatingKinopoiskVoteCount { get; init; }

        [JsonPropertyName("ratingImdb")]
        public double? RatingImdb { get; init; }

        [JsonPropertyName("ratingImdbVoteCount")]
        public int? RatingImdbVoteCount { get; init; }

        [JsonPropertyName("ratingFilmCritics")]
        public double? RatingFilmCritics { get; init; }

        [JsonPropertyName("ratingFilmCriticsVoteCount")]
        public int? RatingFilmCriticsVoteCount { get; init; }

        [JsonPropertyName("ratingAwait")]
        public double? RatingAwait { get; init; }

        [JsonPropertyName("ratingAwaitCount")]
        public int? RatingAwaitCount { get; init; }

        [JsonPropertyName("ratingRfCritics")]
        public double? RatingRfCritics { get; init; }

        [JsonPropertyName("ratingRfCriticsVoteCount")]
        public int? RatingRfCriticsVoteCount { get; init; }

        [JsonPropertyName("webUrl")]
        public string WebUrl { get; init; }

        [JsonPropertyName("year")]
        public int? Year { get; init; }

        [JsonPropertyName("filmLength")]
        public int? FilmLength { get; init; }

        [JsonPropertyName("slogan")]
        public string? Slogan { get; init; }

        [JsonPropertyName("description")]
        public string? Description { get; init; }

        [JsonPropertyName("shortDescription")]
        public string? ShortDescription { get; init; }

        [JsonPropertyName("editorAnnotation")]
        public string? EditorAnnotation { get; init; }

        [JsonPropertyName("isTicketsAvailable")]
        public bool IsTicketsAvailable { get; init; }

        [JsonPropertyName("productionStatus")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ProductionStatus? ProductionStatus { get; init; }

        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MovieType Type { get; init; }

        [JsonPropertyName("ratingMpaa")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MpaaRating? RatingMpaa { get; init; }

        [JsonPropertyName("ratingAgeLimits")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public AgeRating? RatingAgeLimits { get; init; }

        [JsonPropertyName("hasImax")]
        public bool? HasImax { get; init; }

        [JsonPropertyName("has3D")]
        public bool? Has3D { get; init; }

        [JsonPropertyName("lastSync")]
        public string LastSync { get; init; }

        [JsonPropertyName("countries")]
        public List<Countries> Countries { get; init; }

        [JsonPropertyName("genres")]
        public List<Genres> Genres { get; init; }

        [JsonPropertyName("startYear")]
        public int? StartYear { get; init; }

        [JsonPropertyName("endYear")]
        public int? EndYear { get; init; }

        [JsonPropertyName("serial")]
        public bool? Serial { get; init; }

        [JsonPropertyName("shortFilm")]
        public bool? ShortFilm { get; init; }

        [JsonPropertyName("completed")]
        public bool? Completed { get; init; }
    }
}
