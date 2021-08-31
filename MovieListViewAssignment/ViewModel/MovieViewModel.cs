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
        private ObservableCollection<Movie> Movies;

        public MovieViewModel(IMovieDataService movieDataService)
        {
            _movieDataService = movieDataService;
            Movies = new ObservableCollection<Movie>();
        }

        public void LoadMovies()
        {
            var movies = _movieDataService.GetMovies();

            foreach (Movie m in movies)
            {
                Movies.Add(m);
            }
        }

        private Movie selectedMovie;
        public event PropertyChangedEventHandler PropertyChanged;
        public Movie SelectedMovie
        {
            get { return selectedMovie; }
            set { selectedMovie = value; OnPropertyChanged(nameof(selectedMovie)); }
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
