namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utDirector
    {
        protected DVDCentralEntities dc;
        protected IDbContextTransaction? transaction;

        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(3, dc.tblDirectors.Count());
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblDirector entity = new tblDirector();
            entity.FirstName = "another name";
            entity.LastName = "Last Name";

            // Add the entity to the database
            dc.tblDirectors.Add(entity);

            // Commit the changes
            int result = dc.SaveChanges();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblDirector - use the first one
            tblDirector entity = dc.tblDirectors.FirstOrDefault();

            // Change a property value
            entity.FirstName = "Test";

            int result = dc.SaveChanges();
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblDirector where id = 3
            tblDirector entity = dc.tblDirectors.Where(e => e.Id == 3).FirstOrDefault()!;

            dc.tblDirectors.Remove(entity);
            int result = dc.SaveChanges();
            Assert.AreNotEqual(result, 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            // Select * from tblDirector where id = 2
            tblDirector entity = dc.tblDirectors.Where(e => e.Id == 2).FirstOrDefault();
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
            transaction?.Rollback();
            transaction?.Dispose();
            dc = null!;
        }
    }
}