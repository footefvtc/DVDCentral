namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utFormat
    {
        protected DVDCentralEntities dc;
        protected IDbContextTransaction transaction;

        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(3, dc.tblFormats.Count());
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblFormat entity = new tblFormat();
            entity.Description = "Format Description";

            // Add the entity to the database
            dc.tblFormats.Add(entity);

            // Commit the changes
            int result = dc.SaveChanges();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblFormat - use the first one
            tblFormat entity = dc.tblFormats.FirstOrDefault();

            // Change a property value
            entity.Description = "Test";

            int result = dc.SaveChanges();
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblFormat where id = 3
            tblFormat entity = dc.tblFormats.Where(e => e.Id == 3).FirstOrDefault();

            dc.tblFormats.Remove(entity);
            int result = dc.SaveChanges();
            Assert.AreNotEqual(result, 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            // Select * from tblFormat where id = 2
            tblFormat entity = dc.tblFormats.Where(e => e.Id == 2).FirstOrDefault();
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