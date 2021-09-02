using MovieListViewAssignment.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieListViewAssignment.DataAccessLayer
{
    public interface IMovieDataService
    {
        Task<IEnumerable<Movie>> GetMovies();
        //IEnumerable<string> GetTitles();
        //IEnumerable<string> GetGenres();
        Movie GetMovie();


        //Här finns alla genrer listade: https://api.themoviedb.org/3/genre/movie/list?api_key=5b40569a2d41ea78d5234f14d761cb2f&language=en-US
        //Här finns alla titlar listade: 
    }
}