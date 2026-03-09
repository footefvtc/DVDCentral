using BDF.DVDCentral.PL.Test;

namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utOrderItem : utBase<tblOrderItem>
    {

        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(3, dc.tblOrderItems.Count());
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblOrderItem entity = new tblOrderItem();
            entity.OrderId = base.LoadTest().FirstOrDefault().OrderId;
            entity.Quantity = 2;
            entity.MovieId = base.LoadTest().FirstOrDefault().MovieId;
            entity.Cost = 16.00;

            // Add the entity to the database
            dc.tblOrderItems.Add(entity);

            // Commit the changes
            int result = dc.SaveChanges();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblOrderItems - use the first one
            tblOrderItem entity = dc.tblOrderItems.FirstOrDefault()!;

            // Change a property value
            entity.MovieId = dc.tblMovies.FirstOrDefault(x => x.Title == "Other")!.Id;

            int result = dc.SaveChanges();
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblOrderItem where id = 3
            tblOrderItem entity = dc.tblOrderItems.FirstOrDefault()!;

            dc.tblOrderItems.Remove(entity);
            int result = dc.SaveChanges();
            Assert.IsGreaterThan(0, result);
        }
    }
}