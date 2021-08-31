﻿using MovieListViewAssignment.DataAccessLayer;
using MovieListViewAssignment.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MovieListViewAssignment
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainWindow = new MainWindow(new MovieViewModel(new MovieDataService()));
            mainWindow.Show();
        }
    }
}
