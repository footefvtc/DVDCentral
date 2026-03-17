[assembly: DoNotParallelize]
namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utCustomer : utBase<tblCustomer>
    {
        
        [TestMethod]
        public void LoadTest()
        {
            LoadTest(4);
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
            entity.UserId = dc.tblUsers.FirstOrDefault()!.Id;

            int result = InsertTest(entity);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblDirector - use the first one
            tblCustomer entity = dc.tblCustomers.FirstOrDefault()!;

            // Change a property value
            entity.FirstName = "Test";

            int result = UpdateTest(entity);

            Assert.IsGreaterThan(0, result);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblDirector where id = 3
            var entity = dc.tblCustomers.FirstOrDefault(e => e.FirstName == "Other")!;

            int result = DeleteTest(entity);
            Assert.AreNotEqual(0, result);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            tblCustomer item = dc.tblCustomers.FirstOrDefault()!;
            var entity = dc.tblCustomers.Where(e => e.Id == item.Id).FirstOrDefault()!;
            Assert.AreEqual(item.Id, entity.Id);
        }

       
    }
}