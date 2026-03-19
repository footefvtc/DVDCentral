using BDF.DVDCentral.BL.Models;
using FVTC.Utility;
using Microsoft.Extensions.Logging;
using System.Windows;
using System.Windows.Media;

namespace BDF.DVDCentral.WPFUI;

public partial class Movies : Window
{
    List<Movie> movies;
    List<Genre> genres;
    //MySettings mySettings;
    string APIAddress;
    private readonly ILogger<Movies> logger;


    public Movies()
    {
        InitializeComponent();
        //APIAddress = "https://localhost:7054/api/Movie";
        APIAddress = "https://fvtcdp.azurewebsites.net/api/Movie";
        //APIAddress = "https://d0a6-72-135-194-142.ngrok-free.app/api/Movie";




    }

    private async void Reload()
    {
        ApiClient apiClient = new ApiClient(APIAddress);
        movies = apiClient.GetList<Movie>("Movie");
        genres = apiClient.GetList<Genre>("Genre");
        Rebind(0);
    }

    private async void Rebind(int index)
    {
        dgMovies.ItemsSource = null;
        dgMovies.ItemsSource = movies;
        dgMovies.Columns[0].Visibility = Visibility.Hidden;
        dgMovies.Columns[2].Visibility = Visibility.Hidden;
        dgMovies.Columns[3].Visibility = Visibility.Hidden;
        dgMovies.Columns[4].Visibility = Visibility.Hidden;
        dgMovies.Columns[5].Visibility = Visibility.Hidden;

        cboFilter.ItemsSource = null;
        cboFilter.ItemsSource = genres;
        cboFilter.DisplayMemberPath = "Description";
        cboFilter.SelectedValuePath = "Id";


    }


    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        //Reload();
    }

    private void cboFilter_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {

        if (cboFilter.SelectedIndex > -1)
        {
            //TODO: bdf LINQ for Movie Genres
            //vehicles = vehicles.Where(v => v.ColorId == colors[cboFilter.SelectedIndex].Id).ToList();

            //movies = movies.Where(v => v.Genres.Contains(genres[cboFilter.SelectedIndex].Id)); 
            //Reload();
        }
    }

    private void btnGenres_Click(object sender, RoutedEventArgs e)
    {
        new MaintainAttributes(ScreenMode.Genre).ShowDialog();
        logger?.LogInformation("btnGenres_Click running at: {time}", DateTimeOffset.Now);
    }

    private void btnFormats_Click(object sender, RoutedEventArgs e)
    {
        new MaintainAttributes(ScreenMode.Format).ShowDialog();
        logger?.LogInformation("btnFormats_Click running at: {time}", DateTimeOffset.Now);
    }

    private void btnRating_Click(object sender, RoutedEventArgs e)
    {
        new MaintainAttributes(ScreenMode.Rating).ShowDialog();
        logger?.LogInformation("btnRating_Click running at: {time}", DateTimeOffset.Now);
    }

    private void btnLoad_Click(object sender, RoutedEventArgs e)
    {
        Reload();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {

    }

    //private async void Reload()
    //{
    //    try
    //    {
    //        Movies = (List<Movie>)await MovieManager.Load();

    //        dgMovies.ItemsSource = null;
    //        dgMovies.ItemsSource = Movies;

    //        dgMovies.Columns[0].Visibility = Visibility.Hidden;
    //        dgMovies.Columns[1].Visibility = Visibility.Hidden;
    //        dgMovies.Columns[2].Visibility = Visibility.Hidden;
    //        dgMovies.Columns[3].Visibility = Visibility.Hidden;


    //    }
    //    catch (Exception ex)
    //    {

    //        throw ex;
    //    }

    //}
}

