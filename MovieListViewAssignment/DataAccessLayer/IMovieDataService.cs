using MovieListViewAssignment.Model;
using System.Collections.Generic;


namespace MovieListViewAssignment.DataAccessLayer
{
    public interface IMovieDataService
    {
        IEnumerable<Movie> GetMovies();
    }
}