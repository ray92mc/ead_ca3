using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace EADCA3
{
    public class Movie
    {
        [JsonPropertyName("poster_path")]
        public String? posterPath {get; set;}
        public bool? adult { get; set; }
        [JsonPropertyName("release_date")]
        public String? releaseDate { get; set; }
        [JsonPropertyName("genre_ids")]
        public List<int>? genreIds { get; set; }
        public int? id { get; set; }
        [JsonPropertyName("original_title")]
        public String? originalTitle { get; set; }
        [JsonPropertyName("original_language")]
        public String? originalLanguage { get; set; }
        public String? title { get; set; }
        [JsonPropertyName("backdrop_path")]
        public String? backdropPath { get; set; }
        public float? popularity { get; set; }
        [JsonPropertyName("vote_count")]
        public int? voteCount { get; set; }
        public bool? video { get; set; }
        [JsonPropertyName("vote_average")]
        public float? voteAverage { get; set; }

    }
}
