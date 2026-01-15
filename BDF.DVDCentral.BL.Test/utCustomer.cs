using BDF.DVDCentral.PL;

namespace BDF.DVDCentral.BL.Test
{
    [TestClass]
    public class utCustomer
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(3, CustomerManager.Load().Count());
        }

        [TestMethod]
        public void InsertTest1()
        {
            int id = 0;
            int results = CustomerManager.Insert("Bobby", "Flay", 0, "123 Cook St", "Cooking", "FL", "78945", "7894561234", ref id, true);
            Assert.AreEqual(4, id);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void InsertTest2()
        {
            Customer customer = new Customer()
            {
                FirstName = "Test",
                LastName = "Test",
                UserId = 0,
                Address = "45 Street Name Rd.",
                City = "Malibu",
                State = "CA",
                Zip = "45612",
                Phone = "4571594567"
            };

            int results = CustomerManager.Insert(customer, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void UpdateTest()
        {
            Customer customer = CustomerManager.LoadById(3);

            customer.FirstName = "TestNameChange";

            int results = CustomerManager.Update(customer, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void DeleteTest()
        {
            int results = CustomerManager.Delete(3, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            Customer customer = CustomerManager.LoadById(1);
            Assert.AreEqual(customer.Id = 1, 1);
        }
    }
}