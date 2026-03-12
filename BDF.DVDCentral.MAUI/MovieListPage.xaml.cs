using FVTC.Utility;
using BDF.DVDCentral.BL.Models;
using Microsoft.Extensions.Logging;
using System.Windows.Input;

namespace BDF.DVDCentral.MAUI;

public partial class MovieListPage : ContentPage
{
    List<Movie> movies;
    //MySettings mySettings;
    string APIAddress;
    private readonly ILogger<MovieListPage> _logger;

    public ICommand NavigateCommand { get; private set; }

    public MovieListPage()
    {
        InitializeComponent();
        //APIAddress = "https://localhost:7054/api/Movie";
        APIAddress = "https://fvtcdp.azurewebsites.net/api/Movie";
        //APIAddress = "https://d0a6-72-135-194-142.ngrok-free.app/api/Movie";

        NavigateCommand = new Command<Type>(
            async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });


        BindingContext = this;


    }

    private async void Reload()
    {
        ApiClient apiClient = new ApiClient(APIAddress);
        movies = apiClient.GetList<Movie>("Movie");
        Rebind(0);
    }

    private void Rebind(int index)
    {
        cvMovies.ItemsSource = null;
        cvMovies.ItemsSource = movies;
    }

    private void StackLayout_Loaded(object sender, EventArgs e)
    {

    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        Reload();
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

