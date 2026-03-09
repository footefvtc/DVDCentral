namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utMovieGenre : utBase<tblMovieGenre>
    {

        [TestMethod]
        public void LoadTest()
        {
            LoadTest(13);
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblMovieGenre entity = new tblMovieGenre();
            entity.MovieId = dc.tblMovieGenres.FirstOrDefault()!.MovieId;
            entity.GenreId = dc.tblMovieGenres.FirstOrDefault()!.GenreId;

            int result = InsertTest(entity);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            tblMovieGenre item = dc.tblMovieGenres.FirstOrDefault()!;
            tblMovieGenre entity = dc.tblMovieGenres.Where(e => e.Id == item.Id).FirstOrDefault()!;
            Assert.AreEqual(item.Id, entity.Id);
        }


    }
}