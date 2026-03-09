namespace BDF.DVDCentral.BL.Test
{
    [TestClass]
    public class utOrder : utBase<tblOrder>
    {
        [TestMethod]
        public async Task LoadTest()
        {
            Assert.AreEqual(3, (await new OrderManager(options, logger).LoadAsync()).Count);
        }

        [TestMethod]
        public async Task InsertTest()
        {
            Order order = new Order
            {
                CustomerId = (await new CustomerManager(options, logger).LoadAsync()).FirstOrDefault().Id,
                OrderDate = DateTime.Now,
                UserId = (await new UserManager(options, logger).LoadAsync()).FirstOrDefault().Id,
                ShipDate = DateTime.Now,
                OrderItems = new List<OrderItem>()
            };

            var result = new OrderManager(options, logger).InsertAsync(order, true).Result;
            Assert.AreNotEqual(Guid.Empty, result);
        }

        [TestMethod]
        public async Task InsertOrderOrderItemsTest()
        {
            Order order = new Order
            {
                CustomerId = (await new CustomerManager(options, logger).LoadAsync()).FirstOrDefault().Id,
                OrderDate = DateTime.Now,
                UserId = (await new UserManager(options, logger).LoadAsync()).FirstOrDefault().Id,
                ShipDate = DateTime.Now,
                OrderItems = new List<OrderItem>
                {
                    new OrderItem { Id = Guid.NewGuid(),
                                    MovieId = (await new MovieManager(options, logger).LoadAsync()).FirstOrDefault(x => x.Title.Contains("Jaws")).Id,
                                    Cost = 9.99f,
                                    Quantity = 3},

                    new OrderItem { Id = Guid.NewGuid(),
                                    MovieId = (await new MovieManager(options, logger).LoadAsync()).FirstOrDefault(x => x.Title.Contains("Star")).Id,
                                    Cost = 8.99f,
                                    Quantity = 2}
                }
            };

            Guid result = new OrderManager(options, logger).InsertAsync(order, true).Result;
            Assert.AreNotEqual(result, Guid.Empty);
        }


        [TestMethod]
        public async Task UpdateTest()
        {
            Order entity = (await new OrderManager(options, logger).LoadAsync()).FirstOrDefault()!;
            entity.OrderDate = DateTime.Now;
            Assert.IsTrue(new OrderManager(options, logger).UpdateAsync(entity, true).Result > 0);
        }

        //[TestMethod]
        //public async Task DeleteTest()
        //{
        //    Order entity = (await new OrderManager(options, logger).LoadAsync()).FirstOrDefault(x => x.Description == "Other");
        //    Assert.IsTrue(new OrderManager(options, logger).DeleteAsync(entity.Id, true).Result > 0);
        //}

        [TestMethod]
        public async Task LoadByIdAsyncTest()
        {
            Order entity = (await new OrderManager(options, logger).LoadAsync()).LastOrDefault()!;
            Assert.AreEqual(new OrderManager(options, logger).LoadByIdAsync(entity.Id).Result.Id, entity.Id);
            Assert.IsNotNull(entity.UserFullName);
            Assert.IsTrue(entity.OrderItems.Count > 0);

        }
    }
}