namespace BDF.DVDCentral.BL.Test
{
    [TestClass]
    public class utOrderItem : utBase<tblOrderItem>
    {
        [TestMethod]
        public async Task LoadTest()
        {
            List<OrderItem> orderitems = await new OrderItemManager(options, logger).LoadAsync();
            int expected = 3;

            Assert.AreEqual(expected, orderitems.Count);
        }

        //[TestMethod]
        //public async Task InsertTest()
        //{
        //    OrderItem orderitem = new OrderItem
        //    {
        //        Cost = 1,


        //    };

        //    Guid result = await new OrderItemManager(options).InsertAsync(orderitem, true);
        //    Assert.AreNotEqual(result, Guid.Empty);
        //}

        [TestMethod]
        public async Task UpdateTest()
        {
            OrderItem orderitem = (await new OrderItemManager(options, logger).LoadAsync()).FirstOrDefault();
            orderitem.Quantity = -50;

            Assert.IsTrue(new OrderItemManager(options, logger).UpdateAsync(orderitem, true).Result > 0);
        }

        [TestMethod]
        public async Task DeleteTest()
        {
            OrderItem orderitem = (await new OrderItemManager(options, logger).LoadAsync()).FirstOrDefault();

            Assert.IsTrue(new OrderItemManager(options, logger).DeleteAsync(orderitem.Id, true).Result > 0);
        }

        [TestMethod]
        public async Task LoadByIdTest()
        {
            OrderItem orderitem = (await new OrderItemManager(options, logger)
            .LoadAsync())
            .FirstOrDefault()!;

            Assert.AreEqual((await new OrderItemManager(options, logger)
                            .LoadByIdAsync(orderitem.Id)).Id, orderitem.Id);
        }


    }
}
