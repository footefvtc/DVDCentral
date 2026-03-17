using BDF.DVDCentral.PL.Test;

namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utFormat : utBase<tblFormat>
    {

        [TestMethod]
        public void LoadTest()
        {
            base.LoadTest(4);
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
            var item = dc.tblFormats.FirstOrDefault()!;

            // Change a property value
            item.Description = "Test";

            int result = UpdateTest(item);
            Assert.IsGreaterThan(0, result);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblFormat where id = 3
            tblFormat entity = dc.tblFormats.FirstOrDefault(e => e.Description == "Other")!;
            int result = DeleteTest(entity);
            Assert.IsGreaterThan(0, result);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            var item = dc.tblFormats.FirstOrDefault()!;
            tblFormat entity = dc.tblFormats.Where(e => e.Id == item.Id).FirstOrDefault()!;
            Assert.AreEqual(entity.Id, item.Id);
        }


    }
}