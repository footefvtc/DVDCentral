using BDF.DVDCentral.PL.Test;

namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utOrder : utBase<tblOrder>
    {
        [TestMethod]
        public void LoadTest()
        {
            base.LoadTest(3);
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblOrder entity = new tblOrder();
            entity.CustomerId = dc.tblOrders.FirstOrDefault()!.CustomerId;
            entity.OrderDate = DateTime.Now;
            entity.ShipDate = DateTime.Now;
            entity.UserId = dc.tblOrders.FirstOrDefault()!.UserId; ;

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
            tblOrder entity = dc.tblOrders.FirstOrDefault(x => x.OrderDate.Year == 2017)!;

            // Change a property value
            entity.OrderDate = DateTime.Now.AddDays(-5);

            int result = dc.SaveChanges();
            Assert.IsGreaterThan(0, result);
        }

        [TestMethod]
        public void DeleteTest()
        {
            tblOrder entity = dc.tblOrders
                                .First(x => x.OrderDate.Year == 2017);

            Assert.IsGreaterThan(0, base.DeleteTest(entity));
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            // Select * from tblOrder where id = 2
            // Select * from tblOrder where id = 2
            //tblOrder entity = dc.tblOrders.FirstOrDefault();
            //Assert.AreEqual(entity.Id, 2);
        }
    }
}