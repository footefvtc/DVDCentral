namespace FVTC.DVDCentral.PL.Test
{
    [TestClass]
    public class utOrderItem
    {
        protected DVDCentralEntities dc;
        protected IDbContextTransaction transaction;

        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(4, dc.tblOrderItems.Count());
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblOrderItem entity = new tblOrderItem();
            entity.OrderId = 1;
            entity.Quantity = 2;
            entity.MovieId = 3;
            entity.Cost = 16.00;

            // Add the entity to the database
            dc.tblOrderItems.Add(entity);

            // Commit the changes
            int result = dc.SaveChanges();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblOrderItems - use the first one
            tblOrderItem entity = dc.tblOrderItems.FirstOrDefault();

            // Change a property value
            entity.MovieId = 5;

            int result = dc.SaveChanges();
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblOrderItem where id = 3
            tblOrderItem entity = dc.tblOrderItems.Where(e => e.Id == 3).FirstOrDefault();

            dc.tblOrderItems.Remove(entity);
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