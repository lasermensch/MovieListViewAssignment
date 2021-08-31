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
        public object Genre { get; internal set; }
        public string MoviePicUri { get; set; }
        public string Synopsis { get; set; }
    }
}
