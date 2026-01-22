namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utOrderItem : utBase<tblOrderItem>
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
            tblOrderItem entity = new tblOrderItem();
            entity.OrderId = base.LoadTest().FirstOrDefault()!.OrderId;
            entity.Quantity = 1;
            entity.Cost = 1;

            int result = InsertTest(entity);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblOrderItem - use the first one
            tblOrderItem entity = base.LoadTest().FirstOrDefault()!;

            // Change a property value
            entity.MovieId = base.LoadTest().LastOrDefault().MovieId;

            int result = UpdateTest(entity);

            Assert.IsGreaterThan(result, 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblOrderItem where id = 3
            tblOrderItem entity = base.LoadTest().FirstOrDefault()!;

            int result = DeleteTest(entity);
            Assert.AreNotEqual(0, result);
        }

    }
}