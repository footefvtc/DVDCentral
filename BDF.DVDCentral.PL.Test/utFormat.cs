namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utFormat : utBase<tblFormat>
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
            tblFormat entity = new tblFormat();
            entity.Description = "Yolanda";
            
            int result = InsertTest(entity);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblFormat - use the first one
            tblFormat entity = base.LoadTest().FirstOrDefault()!;

            // Change a property value
            entity.Description = "Test";

            int result = UpdateTest(entity);

            Assert.IsGreaterThan(result, 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblFormat where id = 3
            tblFormat entity = base.LoadTest().FirstOrDefault(e => e.Description == "Other")!;

            int result = DeleteTest(entity);
            Assert.AreNotEqual(0, result);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            tblFormat item = base.LoadTest()!.FirstOrDefault()!;
            tblFormat entity = dc.tblFormats.Where(e => e.Id == item.Id).FirstOrDefault()!;
            Assert.AreEqual(item.Id, entity.Id);
        }


    }
}