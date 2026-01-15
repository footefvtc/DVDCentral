namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utMovieGenre
    {
        protected DVDCentralEntities dc;
        protected IDbContextTransaction transaction;

        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(6, dc.tblMovieGenres.Count());
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblMovieGenre entity = new tblMovieGenre();
            entity.MovieId = 1;
            entity.GenreId = 1;

            // Add the entity to the database
            dc.tblMovieGenres.Add(entity);

            // Commit the changes
            int result = dc.SaveChanges();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblMovieGenre - use the first one
            tblMovieGenre entity = dc.tblMovieGenres.FirstOrDefault();

            // Change a property value
            entity.GenreId = 4;
            
            int result = dc.SaveChanges();
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblMovieGenre where id = 3
            tblMovieGenre entity = dc.tblMovieGenres.Where(e => e.Id == 3).FirstOrDefault();

            dc.tblMovieGenres.Remove(entity);
            int result = dc.SaveChanges();
            Assert.AreNotEqual(result, 0);
        }

        [TestInitialize]
        public void Initialize()
        {
            dc = new DVDCentralEntities();
            transaction = dc.Database.BeginTransaction();
        }

        [TestCleanup]
        public void Cleanup()
        {
            transaction.Rollback();
            transaction.Dispose();
            dc = null;
        }
    }
}