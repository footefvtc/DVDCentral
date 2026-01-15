namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utUser
    {
        protected DVDCentralEntities dc;
        protected IDbContextTransaction? transaction;

        //[TestMethod]
        //public void LoadTest()
        //{
        //    Assert.AreEqual(2, dc.tblUsers.Count());
        //}

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblUser entity = new tblUser();
            entity.FirstName = "Test";
            entity.LastName = "Test";
            entity.UserId = "Testtest";
            entity.Password = "TestSecret";

            // Add the entity to the database
            dc.tblUsers.Add(entity);

            // Commit the changes
            int result = dc.SaveChanges();
            Assert.AreEqual(1, result);
        }

        //[TestMethod]
        //public void UpdateTest()
        //{
        //    // SELECT * FROM tblUsers - use the first one
        //    tblUser entity = dc.tblUsers.FirstOrDefault();

        //    // Change a property value
        //    entity.FirstName = "Test";

        //    int result = dc.SaveChanges();
        //    Assert.IsTrue(result > 0);
        //}

        //[TestMethod]
        //public void DeleteTest()
        //{
        //    // Select * from tblUser where id = 2
        //    tblUser entity = dc.tblUsers.Where(e => e.Id == 2).FirstOrDefault();

        //    dc.tblUsers.Remove(entity);
        //    int result = dc.SaveChanges();
        //    Assert.AreNotEqual(result, 0);
        //}

        //[TestMethod]
        //public void LoadByIdTest()
        //{
        //    // Select * from tblUser where id = 2
        //    tblUser entity = dc.tblUsers.Where(e => e.Id == 2).FirstOrDefault();
        //    Assert.AreEqual(entity.Id, 2);
        //}

        //[TestInitialize]
        //public void Initialize()
        //{
        //    dc = new DVDCentralEntities();
        //    transaction = dc.Database.BeginTransaction();
        //}

        //[TestCleanup]
        //public void Cleanup()
        //{
        //    transaction.Rollback();
        //    transaction.Dispose();
        //    dc = null;
        //}
    }
}