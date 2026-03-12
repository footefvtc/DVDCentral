using BDF.DVDCentral.BL.Models;
namespace BDF.DVDCentral.MAUI
{
    public partial class MovieDetailsPage : ContentPage
    {
        Movie movie;
        public MovieDetailsPage(Movie movie)
        {
            InitializeComponent();
            this.movie = movie;
            NameLabel.Text = movie.Title;
            GenreLabel.Text = movie.GenreDescription;
            RatingLabel.Text = movie.RatingDescription;
            FormatLabel.Text = movie.FormatDescription;
            DirectorLabel.Text = movie.DirectorFullName;
            DescriptionLabel.Text = movie.Description;
            MovieImage.Source = movie.ImagePath;
        }
    }
}
