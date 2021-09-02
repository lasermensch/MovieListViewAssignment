using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MovieListViewAssignment.Model
{
    public class Movie
    {
        public string Id { get; set; }
        [JsonPropertyName("original_title")]
        public string Title { get; set; }
        public int[] Genres { get; set; }
        public string Overview { get; set; }
        [JsonPropertyName("poser_source")]
        public string PosterSource { get; set; } //https://image.tmdb.org/t/p/w154 + relative-path
    }

    
}
