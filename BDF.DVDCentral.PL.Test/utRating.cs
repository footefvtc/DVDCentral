using BDF.DVDCentral.PL.Test;

namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utRating : utBase<tblRating>
    {

        [TestMethod]
        public void LoadTest()
        {
            LoadTest(5);
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblRating entity = new tblRating();
            entity.Id = Guid.NewGuid();
            entity.Description = "Rating Description";

            int result = InsertTest(entity);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblRating - use the first one
            var item = dc.tblRatings.FirstOrDefault()!;

            // Change a property value
            item.Description = "Test";

            int result = UpdateTest(item);
            Assert.IsGreaterThan(0, result);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblRating where id = 3
            tblRating entity = dc.tblRatings.FirstOrDefault(e => e.Description == "Other")!;
            int result = DeleteTest(entity);
            Assert.IsGreaterThan(0, result);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            var item = base.LoadTest().FirstOrDefault();

            // Select * from tblRating where id = 2
            tblRating entity = dc.tblRatings.Where(e => e.Id == item.Id).FirstOrDefault();
            Assert.AreEqual(entity.Id, item.Id);
        }


    }
}