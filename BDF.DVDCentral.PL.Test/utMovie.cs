namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utMovie
    {
        protected DVDCentralEntities dc;
        protected IDbContextTransaction? transaction;

        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(3, dc.tblMovies.Count());
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblMovie entity = new tblMovie();
            entity.Title = "Movie Title";
            entity.Description = "Movie Description";
            entity.FormatId = 1;
            entity.DirectorId = 1;
            entity.RatingId = 1;
            entity.Cost = 1.00;
            entity.InStkQty = 0;
            entity.ImagePath = "testphoto.jpg";

            // Add the entity to the database
            dc.tblMovies.Add(entity);

            // Commit the changes
            int result = dc.SaveChanges();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblMovie - use the first one
            tblMovie entity = dc.tblMovies.FirstOrDefault();

            // Change a property value
            entity.Title = "Test";

            int result = dc.SaveChanges();
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblMovie where id = 3
            tblMovie entity = dc.tblMovies.Where(e => e.Id == 3).FirstOrDefault();

            dc.tblMovies.Remove(entity);
            int result = dc.SaveChanges();
            Assert.AreNotEqual(result, 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            // Select * from tblMovie where id = 2
            tblMovie entity = dc.tblMovies.Where(e => e.Id == 2).FirstOrDefault();
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