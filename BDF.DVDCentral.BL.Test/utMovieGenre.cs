namespace BDF.DVDCentral.BL.Test
{
    [TestClass]
    public class utMovieGenre : utBase<tblMovieGenre>
    {

        [TestMethod]
        public async Task InsertTest()
        {
            Guid genreId = (await new GenreManager(options, logger).LoadAsync()!).FirstOrDefault()!.Id;
            Guid movieId = (await new MovieManager(options, logger).LoadAsync()!).FirstOrDefault()!.Id;
            MovieGenre movieGenre = new MovieGenre()
            {
                MovieId = movieId,
                GenreId = genreId
            };

            Guid results = await new MovieGenreManager(options, logger).InsertAsync(movieGenre, true);
            Assert.AreNotEqual(Guid.Empty, results);
        }

        [TestMethod]
        public async Task DeleteTest()
        {
            Guid id = (await new MovieGenreManager(options, logger).LoadAsync()).FirstOrDefault()!.Id;
            int results = await new MovieGenreManager(options, logger).DeleteAsync(id, true);
            Assert.AreEqual(1, results);
        }
    }
}