namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utGenre
    {
        protected DVDCentralEntities dc;
        protected IDbContextTransaction? transaction;

        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(8, dc.tblGenres.Count());
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblGenre entity = new tblGenre();
            entity.Description = "Genre Description";

            // Add the entity to the database
            dc.tblGenres.Add(entity);

            // Commit the changes
            int result = dc.SaveChanges();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblGenre - use the first one
            tblGenre entity = dc.tblGenres.FirstOrDefault();

            // Change a property value
            entity.Description = "Test";

            int result = dc.SaveChanges();
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblGenre where id = 3
            tblGenre entity = dc.tblGenres.Where(e => e.Id == 3).FirstOrDefault();

            dc.tblGenres.Remove(entity);
            int result = dc.SaveChanges();
            Assert.AreNotEqual(result, 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            // Select * from tblGenre where id = 2
            tblGenre entity = dc.tblGenres.Where(e => e.Id == 2).FirstOrDefault();
            Assert.AreEqual(entity.Id, 2);
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