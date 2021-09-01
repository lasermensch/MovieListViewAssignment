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
        private string[] _genres;

        public MovieViewModel(IMovieDataService movieDataService)
        {
            _movieDataService = movieDataService;
            _movies = new ObservableCollection<Movie>();
        }

        public void LoadMovies()
        {
            var movies = _movieDataService.GetMovies();

            foreach (Movie m in movies)
            {
                _movies.Add(m);
            }
        }
        public string[] Genres
        {
            get{ return _genres; }
            set { _genres = value}
        }

        private Movie selectedMovie;
        public event PropertyChangedEventHandler PropertyChanged;
        public Movie SelectedMovie
        {
            get { return selectedMovie; }
            set { selectedMovie = value; OnPropertyChanged(nameof(selectedMovie)); }
        }
        public ObservableCollection<Movie> Movies
        {
            get { return _movies; }
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
