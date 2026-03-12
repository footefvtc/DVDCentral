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
        APIAddress = "https://localhost:7156/api/Movie";
        //APIAddress = "https://fvtcdp.azurewebsites.net/api/Movie";
        //APIAddress = "https://d0a6-72-135-194-142.ngrok-free.app/api/Movie";

        NavigateCommand = new Command<Type>(
            async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });


        BindingContext = this;


    }

    async void OnItemClicked(object sender, EventArgs e)
    {
        string dataToPass = "Detailed Information";
        //Movie movie = (Movie)(sender).BindingContext;
        //await Navigation.PushAsync(new MovieDetailsPage(movie));
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

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        Reload();
    }

    async void cvMovies_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection != null && e.CurrentSelection.Any())
        {
            // Get the selected image data model
            var movie = (Movie)e.CurrentSelection.FirstOrDefault();

            // Handle the click (e.g., navigate to a detail page, show a popup)
            //DisplayAlert("Image Clicked", $"You clicked on image: {selectedImage.ImageSourceUrl}", "OK");

            // Optional: clear the selection so another click on the same item is registered
            ((CollectionView)sender).SelectedItem = null;
            await Navigation.PushAsync(new MovieDetailsPage(movie));
        }

        
    }
}

