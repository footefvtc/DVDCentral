using BDF.DVDCentral.PL.Test;

namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utFormat : utBase<tblFormat>
    {

        [TestMethod]
        public void LoadTest()
        {
            var list = base.LoadTest();
            Assert.AreEqual(4, list.Count());
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblFormat entity = new tblFormat();
            entity.Id = Guid.NewGuid();
            entity.Description = "Format Description";

            int result = InsertTest(entity);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblFormat - use the first one
            var item = base.LoadTest().FirstOrDefault();

            // Change a property value
            item.Description = "Test";

            int result = UpdateTest(item);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblFormat where id = 3
            tblFormat entity = dc.tblFormats.FirstOrDefault(e => e.Description == "Other");
            int result = DeleteTest(entity);
            Assert.AreNotEqual(result, 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            var item = base.LoadTest().FirstOrDefault();

            // Select * from tblFormat where id = 2
            tblFormat entity = dc.tblFormats.Where(e => e.Id == item.Id).FirstOrDefault();
            Assert.AreEqual(entity.Id, item.Id);
        }


    }
}