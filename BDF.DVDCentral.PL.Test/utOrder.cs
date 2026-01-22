namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utOrder : utBase<tblOrder>
    {

        [TestMethod]
        public void LoadTest()
        {
            LoadTest(3);
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblOrder entity = new tblOrder();
            entity.CustomerId = dc.tblOrders.FirstOrDefault()!.CustomerId;
            entity.UserId = dc.tblOrders.FirstOrDefault()!.UserId;
            entity.OrderDate = DateTime.Now;
            entity.ShipDate = DateTime.Now;

            int result = InsertTest(entity);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblOrder - use the first one
            tblOrder entity = base.LoadTest().FirstOrDefault()!;

            // Change a property value
            entity.ShipDate = DateTime.Now;

            int result = UpdateTest(entity);

            Assert.IsGreaterThan(result, 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblOrder where id = 3
            tblOrder entity = base.LoadTest().FirstOrDefault(e => e.OrderDate.Year == 2017)!;

            int result = DeleteTest(entity);
            Assert.AreNotEqual(0, result);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            tblOrder item = base.LoadTest()!.FirstOrDefault()!;
            tblOrder entity = dc.tblOrders.Where(e => e.Id == item.Id).FirstOrDefault()!;
            Assert.AreEqual(item.Id, entity.Id);
        }


    }
}