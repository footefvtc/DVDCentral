namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utMovie : utBase<tblMovie>
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
            tblMovie entity = new tblMovie();
            entity.Description = "Yolanda";

            int result = InsertTest(entity);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblMovie - use the first one
            tblMovie entity = base.LoadTest().FirstOrDefault()!;

            // Change a property value
            entity.Description = "Test";

            int result = UpdateTest(entity);

            Assert.IsGreaterThan(result, 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblMovie where id = 3
            tblMovie entity = base.LoadTest().FirstOrDefault(e => e.Description == "Other")!;

            int result = DeleteTest(entity);
            Assert.AreNotEqual(0, result);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            tblMovie item = base.LoadTest()!.FirstOrDefault()!;
            tblMovie entity = dc.tblMovies.Where(e => e.Id == item.Id).FirstOrDefault()!;
            Assert.AreEqual(item.Id, entity.Id);
        }


    }
}