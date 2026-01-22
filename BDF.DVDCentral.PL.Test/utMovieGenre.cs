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
            entity.MovieId = base.LoadTest().FirstOrDefault()!.MovieId;
            entity.GenreId = base.LoadTest().FirstOrDefault()!.GenreId;

            int result = InsertTest(entity);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            tblMovieGenre item = base.LoadTest()!.FirstOrDefault()!;
            tblMovieGenre entity = dc.tblMovieGenres.Where(e => e.Id == item.Id).FirstOrDefault()!;
            Assert.AreEqual(item.Id, entity.Id);
        }


    }
}