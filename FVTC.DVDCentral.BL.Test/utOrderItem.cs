using FVTC.DVDCentral.PL;

namespace FVTC.DVDCentral.BL.Test
{
    [TestClass]
    public class utOrderItem
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(4, OrderItemManager.Load().Count());
        }

        [TestMethod]
        public void LoadByOrderIdTest()
        {
            int orderId = OrderItemManager.Load().FirstOrDefault().OrderId;
            Assert.IsTrue(OrderItemManager.LoadByOrderId(orderId).Count() > 0);
        }

        [TestMethod]
        public void InsertTest1()
        {
            int id = 0;
            int results = OrderItemManager.Insert(4, 2, 2, (float)15.00, ref id, true);
            Assert.AreEqual(5, id);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void InsertTest2()
        {
            int id = 0;
            OrderItem orderItem = new OrderItem()
            {
                OrderId = 5,
                Quantity = 1,
                MovieId = 2,
                Cost = (float)3.00
            };

            int results = OrderItemManager.Insert(orderItem, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void UpdateTest()
        {
            OrderItem orderItem = OrderItemManager.LoadById(3);

            orderItem.OrderId = 10;

            int results = OrderItemManager.Update(orderItem, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void DeleteTest()
        {
            int results = OrderItemManager.Delete(3, true);
            Assert.AreEqual(1, results);
        }
    }
}