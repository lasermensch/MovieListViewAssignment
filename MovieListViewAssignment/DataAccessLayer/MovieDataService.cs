using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MovieListViewAssignment.Model;
using Newtonsoft.Json;

namespace MovieListViewAssignment.DataAccessLayer
{
    public class MovieDataService : IMovieDataService
    {
        //public IEnumerable<Movie> GetMovies()
        //{
        //    yield return new Movie() { MovieName = "The Shining", Genre = Genre.Horror.ToString(), MoviePicUri = "https://m.media-amazon.com/images/I/518tcfY4LwL._AC_SY1000_.jpg" };
        //    yield return new Movie() { MovieName = "Gone Girl", Genre = Genre.Thriller.ToString(), MoviePicUri = "https://prod.cdn.bbaws.net/TDC_Blockbuster_-_Production/961/424/FO-0532_po-reg-medium_orig-1602598121139.jpg" };
        //    yield return new Movie() { MovieName = "As Good As It Gets", Genre = Genre.Comedy.ToString(), MoviePicUri = "https://m.media-amazon.com/images/M/MV5BNWMxZTgzMWEtMTU0Zi00NDc5LWFkZjctMzUxNDIyNzZiMmNjXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg" };
        //    yield return new Movie() { MovieName = "Anger Manageent", Genre = Genre.Comedy.ToString(), MoviePicUri = "https://m.media-amazon.com/images/M/MV5BMDg1YTNiODItZGYyOC00NGIwLWI3MjYtMTY3NDQ0ZDIwYjBiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg" };
        //    yield return new Movie() { MovieName = "The Bucket List", Genre = Genre.Comedy.ToString(), MoviePicUri = "https://i-viaplay-com.akamaized.net/viaplay-prod/144/704/1460108114-175f4237875ed4224f362d8927a31f2a22571662.jpg?width=400&height=600" };
        //    yield return new Movie() { MovieName = "The Departed", Genre = Genre.Thriller.ToString(), MoviePicUri = "https://m.media-amazon.com/images/M/MV5BMTI1MTY2OTIxNV5BMl5BanBnXkFtZTYwNjQ4NjY3._V1_.jpg" };
        //    yield return new Movie() { MovieName = "One Flew Over the Cuckoo's Nest", Genre = Genre.Drama.ToString(), MoviePicUri = "https://d2iltjk184xms5.cloudfront.net/uploads/photo/file/63055/small_original.jpg" };
        //}
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            IEnumerable<Movie> movies;
            using (HttpClient client = new HttpClient())
            {
                string url = "https://api.themoviedb.org/3/movie/popular?api_key=5b40569a2d41ea78d5234f14d761cb2f"; //lista över populära filmer
                HttpResponseMessage resp = await client.GetAsync(url);
                string jresp = await resp.Content.ReadAsStringAsync();
                ResponseDTO respDto = JsonConvert.DeserializeObject<ResponseDTO>(jresp);
                movies = respDto.Movies;
            }
            return movies;
        }
        public Movie GetMovie()
        {
            return null;
        }
    }
}
