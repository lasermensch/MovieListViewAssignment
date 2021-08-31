using MovieListViewAssignment.Model;
using System.Collections.Generic;
using System.Linq;

namespace MovieListViewAssignment.DataAccessLayer
{
    public interface IMovieDataService
    {
        IEnumerable<Movie> GetMovies();
    }
}