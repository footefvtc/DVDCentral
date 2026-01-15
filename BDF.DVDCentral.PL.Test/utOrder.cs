namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utOrder
    {
        protected DVDCentralEntities dc;
        protected IDbContextTransaction transaction;

        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(3, dc.tblOrders.Count());
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblOrder entity = new tblOrder();
            entity.CustomerId = 2;
            entity.OrderDate = DateTime.Now;
            entity.ShipDate = DateTime.Now;
            entity.UserId = 3;

            // Add the entity to the database
            dc.tblOrders.Add(entity);

            // Commit the changes
            int result = dc.SaveChanges();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblOrder - use the first one
            tblOrder entity = dc.tblOrders.FirstOrDefault();

            // Change a property value
            entity.CustomerId = 100;

            int result = dc.SaveChanges();
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblOrder where id = 3
            tblOrder entity = dc.tblOrders.Where(e => e.Id == 3).FirstOrDefault();

            dc.tblOrders.Remove(entity);
            int result = dc.SaveChanges();
            Assert.AreNotEqual(result, 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            // Select * from tblOrder where id = 2
            tblOrder entity = dc.tblOrders.Where(e => e.Id == 2).FirstOrDefault();
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