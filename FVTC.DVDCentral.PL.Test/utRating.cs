namespace FVTC.DVDCentral.PL.Test
{
    [TestClass]
    public class utRating
    {
        protected DVDCentralEntities dc;
        protected IDbContextTransaction transaction;

        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(4, dc.tblRatings.Count());
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblRating entity = new tblRating();
            entity.Description = "Rating Description";

            // Add the entity to the database
            dc.tblRatings.Add(entity);

            // Commit the changes
            int result = dc.SaveChanges();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblRating - use the first one
            tblRating entity = dc.tblRatings.FirstOrDefault();

            // Change a property value
            entity.Description = "Test";

            int result = dc.SaveChanges();
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblRating where id = 3
            tblRating entity = dc.tblRatings.Where(e => e.Id == 3).FirstOrDefault();

            dc.tblRatings.Remove(entity);
            int result = dc.SaveChanges();
            Assert.AreNotEqual(result, 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            // Select * from tblRating where id = 2
            tblRating entity = dc.tblRatings.Where(e => e.Id == 2).FirstOrDefault();
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