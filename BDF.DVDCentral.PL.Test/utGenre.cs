using BDF.DVDCentral.PL.Test;

namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utGenre : utBase<tblGenre>
    {

        [TestMethod]
        public void LoadTest()
        {
            LoadTest(10);
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblGenre entity = new tblGenre();
            entity.Id = Guid.NewGuid();
            entity.Description = "Genre Description";

            int result = InsertTest(entity);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblGenre - use the first one
            var item = dc.tblGenres.FirstOrDefault();

            // Change a property value
            item.Description = "Test";

            int result = UpdateTest(item);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblGenre where id = 3
            tblGenre entity = dc.tblGenres.FirstOrDefault(e => e.Description == "Other")!;
            int result = DeleteTest(entity);
            Assert.AreNotEqual(result, 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            var item = dc.tblGenres.FirstOrDefault()!;

            // Select * from tblGenre where id = 2
            tblGenre entity = dc.tblGenres.Where(e => e.Id == item.Id).FirstOrDefault()!;
            Assert.AreEqual(entity.Id, item.Id);
        }


    }
}