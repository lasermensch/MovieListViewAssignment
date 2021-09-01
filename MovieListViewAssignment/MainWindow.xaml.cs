using MovieListViewAssignment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;

namespace MovieListViewAssignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly HttpClient _httpClient;
        private readonly MovieViewModel _movieViewModel;
        public MainWindow(MovieViewModel movieViewModel)
        {
            InitializeComponent();
            _httpClient = new HttpClient(); //Vi ska lösa hur vi ska hitta filmerna från det nämnda api:et.
            _movieViewModel = movieViewModel;
            _movieViewModel.LoadMovies();
            DataContext = _movieViewModel;
        }
    }
}
