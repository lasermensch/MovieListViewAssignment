using MovieListViewAssignment.DataAccessLayer;
using MovieListViewAssignment.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieListViewAssignment.ViewModel
{
    public class MovieViewModel : INotifyPropertyChanged
    {
        private IMovieDataService _movieDataService;
        private ObservableCollection<Movie> _movies;
        private ObservableCollection<Genre> _genres;
        private Movie selectedMovie;
        private Genre selectedGenre;
        public event PropertyChangedEventHandler PropertyChanged;

        public MovieViewModel(IMovieDataService movieDataService)
        {
            _movieDataService = movieDataService;
            _movies = new ObservableCollection<Movie>();
            _genres = new ObservableCollection<Genre>();
        }
        public void LoadMovies()
        {
            var movies = _movieDataService.GetMovies().Result;

            foreach (Movie m in movies)
            {
                _movies.Add(m);
            }
        }
        public void LoadGenres()
        {
            var genres = _movieDataService.GetGenres().Result;

            foreach (Genre g in genres)
            {
                _genres.Add(g);
            }
        }
        
        public Movie SelectedMovie
        {
            get { return selectedMovie; }
            set { selectedMovie = value; OnPropertyChanged(nameof(selectedMovie)); }
        }
        public Genre SelectedGenre
        {
            get { return selectedGenre; }
            set { selectedGenre = value; OnPropertyChanged(nameof(selectedGenre)); }
        }
        public ObservableCollection<Movie> Movies
        {
            get { return _movies; }
        }
        public ObservableCollection<Genre> Genres
        {
            get { return _genres; }
        }

        public void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
