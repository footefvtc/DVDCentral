[assembly: DoNotParallelize]
namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utCustomer
    {
        public required DVDCentralEntities dc;
        protected IDbContextTransaction? transaction;

        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(3, dc.tblCustomers.Count());
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblCustomer entity = new tblCustomer();
            entity.Address = "123 fake address";
            entity.City = "new city";
            entity.State = "AL";
            entity.Zip = "87569";
            entity.Phone = "7485986549";
            entity.FirstName = "Yolanda";
            entity.LastName = "Smith";
            entity.UserId = -99;

            // Add the entity to the database
            dc.tblCustomers.Add(entity);

            // Commit the changes
            int result = dc.SaveChanges();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblCustomer - use the first one
            tblCustomer entity = dc.tblCustomers.FirstOrDefault();

            // Change a property value
            entity.FirstName = "Test";

            int result = dc.SaveChanges();
            Assert.IsGreaterThan(result, 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblCustomer where id = 3
            tblCustomer entity = dc.tblCustomers.Where(e => e.Id == 3).FirstOrDefault();

            dc.tblCustomers.Remove(entity);
            int result = dc.SaveChanges();
            Assert.AreNotEqual(result, 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            // Select * from tblCustomer where id = 2
            tblCustomer entity = dc.tblCustomers.Where(e => e.Id == 2).FirstOrDefault()!;
            Assert.AreEqual(2, entity.Id);
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