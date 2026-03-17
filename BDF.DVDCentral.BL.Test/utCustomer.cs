namespace BDF.DVDCentral.BL.Test
{
    [TestClass]
    public class utCustomer : utBase<tblCustomer>
    {

        [TestMethod]
        public async Task LoadAsyncTest()
        {
            Assert.IsGreaterThan(3, (await new DirectorManager(options, logger).LoadAsync()).Count);

        }

        [TestMethod]
        public async Task InsertTest()
        {
            Customer customer = new Customer
            {
                FirstName = "XXXXX",
                LastName = "XXXXX",
                Address = "XXXXX",
                City = "XXXXX",
                State = "XX",
                Zip = "XXXXX",
                Phone = "XXX-XXX-XXXX",
                UserId = (await new UserManager(options, logger).LoadAsync()).FirstOrDefault()!.Id
            };

            Guid result = await new CustomerManager(options, logger).InsertAsync(customer, true);
            Assert.AreNotEqual(result, Guid.Empty);
        }

        [TestMethod]
        public async Task UpdateTest()
        {
            Customer customer = (await new CustomerManager(options, logger).LoadAsync()).FirstOrDefault()!;
            customer.FirstName = "Blah blah";
            Assert.IsTrue(new CustomerManager(options, logger).UpdateAsync(customer, true).Result > 0);
        }

        [TestMethod]
        public async Task DeleteTest()
        {
            Customer customer = (await new CustomerManager(options, logger).LoadAsync()).FirstOrDefault(x => x.LastName == "Other")!;
            Assert.IsTrue(new CustomerManager(options, logger).DeleteAsync(customer.Id, true).Result > 0);
        }

        [TestMethod]
        public async Task LoadByIdTest()
        {
            Customer customer = (await new CustomerManager(options, logger).LoadAsync()).FirstOrDefault()!;
            Assert.AreEqual(new CustomerManager(options, logger).LoadByIdAsync(customer.Id).Result.Id, customer.Id);
        }


    }
}
