using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace MovieListViewAssignment.Model
{
    public class Movie
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("original_title")]
        public string Title { get; set; }
        [JsonProperty("genre_ids")]
        public ICollection<int> Genres { get; set; }
        [JsonProperty("overview")]
        public string Overview { get; set; }
        [JsonProperty("poster_path")]
        public string PosterSource { get; set; } //https://image.tmdb.org/t/p/w154 + relative-path
    }

    
}
