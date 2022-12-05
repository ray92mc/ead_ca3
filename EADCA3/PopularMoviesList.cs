using System.Text.Json.Serialization;

namespace EADCA3
{
    public class PopularMoviesList
    {
        public int? page { get; set;  }
        public List<Movie>? results { get; set;  }

        [JsonPropertyName("total_results")]
        public int? totalResults { get; set; }

        [JsonPropertyName("total_pages")]
        public int? totalPages { get; set;  }

    }
}
