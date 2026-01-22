namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utGenre : utBase<tblGenre>
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
            tblGenre entity = new tblGenre();
            entity.Description = "Yolanda";

            int result = InsertTest(entity);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblGenre - use the first one
            tblGenre entity = base.LoadTest().FirstOrDefault()!;

            // Change a property value
            entity.Description = "Test";

            int result = UpdateTest(entity);

            Assert.IsGreaterThan(result, 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblGenre where id = 3
            tblGenre entity = base.LoadTest().FirstOrDefault(e => e.Description == "Other")!;

            int result = DeleteTest(entity);
            Assert.AreNotEqual(0, result);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            tblGenre item = base.LoadTest()!.FirstOrDefault()!;
            tblGenre entity = dc.tblGenres.Where(e => e.Id == item.Id).FirstOrDefault()!;
            Assert.AreEqual(item.Id, entity.Id);
        }


    }
}