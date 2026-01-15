using BDF.DVDCentral.PL;

namespace BDF.DVDCentral.BL.Test
{
    [TestClass]
    public class utMovieGenre
    {

        [TestMethod]
        public void InsertTest1()
        {
            int id = 0;
            int results = MovieGenreManager.Insert(1, 2, ref id, true);
            Assert.AreEqual(7, id);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void InsertTest2()
        {
            int id = 0;
            MovieGenre movieGenre = new MovieGenre()
            {
                MovieId = 2,
                GenreId = 3
            };

            int results = MovieGenreManager.Insert(movieGenre, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void UpdateTest()
        {
            MovieGenre movieGenre = MovieGenreManager.LoadById(3);

            movieGenre.MovieId = 4;

            int results = MovieGenreManager.Update(movieGenre, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void DeleteTest()
        {
            int results = MovieGenreManager.Delete(3, true);
            Assert.AreEqual(1, results);
        }
    }
}