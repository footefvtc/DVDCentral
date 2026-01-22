namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utRating : utBase<tblRating>
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
            tblRating entity = new tblRating();
            entity.Description = "Yolanda";

            int result = InsertTest(entity);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblRating - use the first one
            tblRating entity = base.LoadTest().FirstOrDefault()!;

            // Change a property value
            entity.Description = "Test";

            int result = UpdateTest(entity);

            Assert.IsGreaterThan(result, 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblRating where id = 3
            tblRating entity = base.LoadTest().FirstOrDefault(e => e.Description == "Other")!;

            int result = DeleteTest(entity);
            Assert.AreNotEqual(0, result);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            tblRating item = base.LoadTest()!.FirstOrDefault()!;
            tblRating entity = dc.tblRatings.Where(e => e.Id == item.Id).FirstOrDefault()!;
            Assert.AreEqual(item.Id, entity.Id);
        }


    }
}