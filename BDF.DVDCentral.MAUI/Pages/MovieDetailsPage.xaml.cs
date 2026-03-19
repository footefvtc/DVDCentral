using BDF.DVDCentral.BL.Models;
using FVTC.Utility;
namespace BDF.DVDCentral.MAUI
{
    public partial class MovieDetailsPage : ContentPage
    {
        //string APIAddress = "https://fvtcdp.azurewebsites.net/api/Movie";
        string APIAddress = "https://dvdcentralapi-120212964.azurewebsites.net/api/";

        Movie movie;
        public MovieDetailsPage(Movie movie)
        {
            InitializeComponent();
            this.movie = movie;
            NameLabel.Text = movie.Title;
            //GenreLabel.Text = movie.GenreDescription;
            RatingLabel.Text = movie.RatingDescription;
            FormatLabel.Text = movie.FormatDescription;
            DirectorLabel.Text = movie.DirectorFullName;
            DescriptionLabel.Text = movie.Description;
            //MovieImage.Source = movie.ImagePath;
            txtTitle.Text = movie.Title;
            APIAddress = "https://dvdcentralapi-120212964.azurewebsites.net/api/";


        }

        private void btnEdit_Clicked(object sender, EventArgs e)
        {
            movie.Title = txtTitle.Text;
            ApiClient apiClient = new ApiClient(APIAddress);
            var response = apiClient.Put<Movie>(movie, "Movie", movie.Id);
            string result = response.Content.ReadAsStringAsync().Result;
            DisplayAlertAsync("Edit", result, "OK");
        }

        private void btnInsert_Clicked(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.Title = txtTitle.Text;
            ApiClient apiClient = new ApiClient(APIAddress);
            var response = apiClient.Post<Movie>(movie, "Movie");
            string result = response.Content.ReadAsStringAsync().Result;
            DisplayAlertAsync("Insert", result, "OK");
        }
    }
}
