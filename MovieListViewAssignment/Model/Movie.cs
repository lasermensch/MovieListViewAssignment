using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieListViewAssignment.Model
{
    public class Movie
    {
        public string MovieName { get; internal set; }
        public Genre Genre { get; set; }
        public string MoviePicUri { get; set; }
        public string Synopsis { get; set; }
    }

    public enum Genre
    {
        Horror,
        Thriller,
        Comedy,
        Drama
    }
}
