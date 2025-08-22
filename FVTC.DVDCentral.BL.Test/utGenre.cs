using FVTC.DVDCentral.PL;

namespace FVTC.DVDCentral.BL.Test
{
    [TestClass]
    public class utGenre
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(8, GenreManager.Load().Count());
        }

        [TestMethod]
        public void InsertTest1()
        {
            int id = 0;
            int results = GenreManager.Insert("Genre", ref id, true);
            Assert.AreEqual(9, id);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void InsertTest2()
        {
            int id = 0;
            Genre genre = new Genre()
            {
                Description = "Test"
            };

            int results = GenreManager.Insert(genre, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void UpdateTest()
        {
            Genre genre = GenreManager.LoadById(3);

            genre.Description = "Test";

            int results = GenreManager.Update(genre, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void DeleteTest()
        {
            int results = GenreManager.Delete(3, true);
            Assert.AreEqual(1, results);
        }
    }
}