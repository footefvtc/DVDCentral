using BDF.DVDCentral.BL.Models;
using System.Diagnostics.CodeAnalysis;

namespace BDF.DVDCentral.UI.ViewModels
{
    public class MovieVM
    {
        public required Movie Movie { get; set; }
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public List<Director> Directors { get; set; } = new List<Director>();
        public List<Rating> Ratings { get; set; } = new List<Rating>();
        public List<Format> Formats { get; set; } = new List<Format>();
        public required IFormFile File { get; set; }
        public IEnumerable<int> GenreIds { get; set; } // new genres for the movies
        [SetsRequiredMembers]
        public MovieVM()
        {
            Genres = GenreManager.Load();
            Directors = DirectorManager.Load();
            Ratings = RatingManager.Load();
            Formats = FormatManager.Load();
        }
        [SetsRequiredMembers]
        public MovieVM(int id)
        {
            Movie = MovieManager.LoadById(id);
            Directors = DirectorManager.Load();
            Ratings = RatingManager.Load();
            Formats = FormatManager.Load();
            Genres = GenreManager.Load();
            GenreIds = Movie.Genres.Select(g => g.Id);
        }
    }
}
