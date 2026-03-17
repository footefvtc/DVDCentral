using BDF.DVDCentral.BL.Models;
using FVTC.Utility;
using Microsoft.Extensions.Logging;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BDF.DVDCentral.WPFUI
{

    public enum ScreenMode
    {
        Genre = 1,
        Format = 2,
        Rating = 3
    }

    /// <summary>
    /// Interaction logic for MaintainAttributes.xaml
    /// </summary>
    public partial class MaintainAttributes : Window
    {
        List<Genre> genres;
        List<Format> formats;
        List<Rating> ratings;
        ScreenMode screenMode;
        ILogger<MaintainAttributes> logger;
        string APIAddress = "https://fvtcdp.azurewebsites.net/api/";
        ApiClient apiClient;
        public MaintainAttributes(ScreenMode screenmode)
        {
            InitializeComponent();
            screenMode = screenmode;

            Reload();

            cboAttribute.DisplayMemberPath = "Description";
            cboAttribute.SelectedValuePath = "Id";
            lblAttribute.Content = screenMode.ToString() + "s:";
            this.Title = "Maintain " + screenMode.ToString() + "s";
        }

        public Color GetRandomColor()
        {
            Random random = new Random();
            
            // Generate a random value for each color component (0-255)
            int r = random.Next(256);
            int g = random.Next(256);
            int b = random.Next(256);

            // Create and return the Color object
            return Color.FromRgb((byte)r, (byte)g, (byte)b);
        }

        private async void Reload()
        {
            
            LinearGradientBrush myLinearGradientBrush = new LinearGradientBrush();

            myLinearGradientBrush.StartPoint = new Point(0.5, 0);
            myLinearGradientBrush.EndPoint = new Point(0.5, 1);

            myLinearGradientBrush.GradientStops.Add(
                new GradientStop(GetRandomColor(), 0.0)); // Start color at the top
            myLinearGradientBrush.GradientStops.Add(
                new GradientStop(GetRandomColor(), 1.0)); // En

            grdAttribute.Background = myLinearGradientBrush;

            cboAttribute.ItemsSource = null;
            apiClient = new ApiClient(APIAddress);
            switch (screenMode)
            {
                case ScreenMode.Genre:
                    genres = apiClient.GetList<Genre>("Genre");
                    cboAttribute.ItemsSource = genres;
                    break;
                case ScreenMode.Format:
                    formats = apiClient.GetList<Format>("Format");
                    cboAttribute.ItemsSource = formats;
                    break;
                case ScreenMode.Rating:
                    ratings = apiClient.GetList<Rating>("Rating");
                    cboAttribute.ItemsSource = ratings;
                    break;
            }
            cboAttribute.DisplayMemberPath = "Description";
            cboAttribute.SelectedValuePath = "Id";


        }

        private void Rebind(int index)
        {
            cboAttribute.ItemsSource = null;

            switch (screenMode)
            {
                case ScreenMode.Genre:
                    cboAttribute.ItemsSource = genres;
                    break;
                case ScreenMode.Format:
                    cboAttribute.ItemsSource = formats;
                    break;
                case ScreenMode.Rating:
                    cboAttribute.ItemsSource = ratings;
                    break;
                default:
                    break;
            }
            cboAttribute.DisplayMemberPath = "Description";
            cboAttribute.SelectedValuePath = "Id";
            cboAttribute.SelectedIndex = index;
           
        }

        private void BtnInsert_Click(object sender, RoutedEventArgs e)
        {
            switch (screenMode)
            {
                case ScreenMode.Genre:
                    Genre genre = new Genre { Description = txtDescription.Text };
                    var response = apiClient.Post<BL.Models.Genre>(genre, "Genre");
                    string result = response.Content.ReadAsStringAsync().Result;
                    result = result.Replace("\"", "");
                    genre.Id = Guid.Parse(result);
                    genres.Add(genre);
                    Rebind(genres.Count - 1);
                    break;
                case ScreenMode.Format:
                    Format format = new Format { Description = txtDescription.Text };
                    response = apiClient.Post<Format>(format, "Format");
                    result = response.Content.ReadAsStringAsync().Result;
                    result = result.Replace("\"", "");
                    format.Id = Guid.Parse(result);
                    formats.Add(format);
                    Rebind(formats.Count - 1);
                    break;
                case ScreenMode.Rating:
                    Rating rating = new Rating { Description = txtDescription.Text };
                    response = apiClient.Post<Rating>(rating, "Rating");
                    result = response.Content.ReadAsStringAsync().Result;
                    result = result.Replace("\"", "");
                    rating.Id = Guid.Parse(result);
                    ratings.Add(rating);
                    Rebind(ratings.Count - 1);
                    break;
            }
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            switch (screenMode)
            {
                case ScreenMode.Genre:
                    Genre genre = genres[cboAttribute.SelectedIndex];
                    genre.Description = txtDescription.Text;
                    //Task.Run(async () =>
                    //{
                    //    await new GenreManager(options).UpdateAsync(genre);
                    //});
                    genres[cboAttribute.SelectedIndex].Description = txtDescription.Text;
                    Rebind(cboAttribute.SelectedIndex);
                    break;
                case ScreenMode.Format:
                    Format format = formats[cboAttribute.SelectedIndex];
                    format.Description = txtDescription.Text;
                    //Task.Run(async () =>
                    //{
                    //    await new FormatManager(options).UpdateAsync(format);
                    //});
                    Rebind(cboAttribute.SelectedIndex);
                    formats[cboAttribute.SelectedIndex].Description = txtDescription.Text;
                    break;
                case ScreenMode.Rating:
                    Rating rating = ratings[cboAttribute.SelectedIndex];
                    rating.Description = txtDescription.Text;
                    //Task.Run(async () =>
                    //{
                    //    await new RatingManager(options).UpdateAsync(rating);
                    //});
                    Rebind(cboAttribute.SelectedIndex);
                    ratings[cboAttribute.SelectedIndex].Description = txtDescription.Text;
                    break;
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int results = 0;
                switch (screenMode)
                {
                    case ScreenMode.Genre:
                        Genre genre = genres[cboAttribute.SelectedIndex];
                        //Task.Run(async () =>
                        //{
                        //    results = await new GenreManager(options).DeleteAsync(genre.Id);

                        //});
                        genres.Remove(genre);
                        Rebind(0);
                        break;
                    case ScreenMode.Format:
                        Format format = formats[cboAttribute.SelectedIndex];
                        //Task.Run(async () =>
                        //{
                        //    await new FormatManager(options).DeleteAsync(format.Id);
                        //});
                        formats.Remove(format);
                        Rebind(0);
                        break;
                    case ScreenMode.Rating:
                        Rating rating = ratings[cboAttribute.SelectedIndex];
                        //Task.Run(async () =>
                        //{
                        //    await new RatingManager(options).DeleteAsync(rating.Id);
                        //});
                        ratings.Remove(rating);
                        Rebind(0);
                        break;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CboAttribute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboAttribute.SelectedIndex > -1)
            {
                if (screenMode == ScreenMode.Genre)
                    txtDescription.Text = genres[cboAttribute.SelectedIndex].Description;
                else if (screenMode == ScreenMode.Format)   
                    txtDescription.Text = formats[cboAttribute.SelectedIndex].Description;
                else
                    txtDescription.Text = ratings[cboAttribute.SelectedIndex].Description;
            }
        }
    }
}
