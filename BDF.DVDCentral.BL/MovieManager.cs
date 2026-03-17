namespace BDF.DVDCentral.BL
{
    public class MovieManager : GenericManager<tblMovie>
    {
        public MovieManager(DbContextOptions<DVDCentralEntities> options, ILogger logger) : base(options, logger) { }

        public async Task<Guid> InsertAsync(Movie movie, bool rollback = false)
        {
            try
            {
                tblMovie row = Map<Movie, tblMovie>(movie);
                return await base.InsertAsync(row,
                                              null,
                                              rollback);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> UpdateAsync(Movie movie, bool rollback = false)
        {
            try
            {
                tblMovie row = Map<Movie, tblMovie>(movie);
                return await base.UpdateAsync(row,
                                              null,
                                              rollback);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static List<Genre> ConvertToGenres(ICollection<tblMovieGenre> moviegenres)
        {
            List<Genre> genres = new List<Genre>();
            foreach (tblMovieGenre mg in moviegenres)
            {
                genres.Add(new Genre { Id = mg.GenreId, Description = mg.Genre.Description });
            }
            return genres;
        }

        public async Task<List<Movie>> LoadAsync(Guid? genreId = null)
        {

            try
            {
                List<Movie> movies = new List<Movie>();
                Expression<Func<tblMovie, object>>[] includeProperties = new Expression<Func<tblMovie, object>>[4];
                includeProperties[0] = x => x.Rating;
                includeProperties[1] = x => x.Director;
                includeProperties[2] = x => x.Format;
                includeProperties[3] = x => x.MovieGenres;


                Expression<Func<tblMovie, bool>>? filter = null;
                if (genreId != null)
                    filter = mg => mg.MovieGenres.Any(_ => _.GenreId == genreId);

                //var rows = await base.LoadAsync(filter, includeProperties);

                (await base.LoadAsync(filter, includeProperties))
                    .ForEach(d =>
                    {
                        Movie movie = Map<tblMovie, Movie>(d);
                        movie.RatingDescription = d.Rating.Description;
                        movie.FormatDescription = d.Format.Description;
                        movie.DirectorFullName = d.Director.LastName + ", " + d.Director.FirstName;
                        movie.Genres = ConvertToGenres(d.MovieGenres.ToList());
                        movies.Add(movie);
                    });
                return movies;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //public async Task<Movie> LoadByIdAsync(Guid id)
        //{
        //    try
        //    {
        //        List<tblMovie> rows = await base.LoadAsync(e => e.Id == id);
        //        if (rows[0] != null)
        //            return Map<tblMovie, Movie>(rows[0]);
        //        else
        //            throw new Exception("No row");

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}
