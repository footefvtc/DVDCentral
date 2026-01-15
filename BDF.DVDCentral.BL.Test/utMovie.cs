using BDF.DVDCentral.PL;

namespace BDF.DVDCentral.BL.Test
{
    [TestClass]
    public class utMovie
    {
        [TestMethod]
        public void LoadTest() 
        {
            var items = MovieManager.Load();
            Assert.AreEqual(3, items.Count());
        }

        [TestMethod]
        public void InsertTest1()
        {
            int id = 0;
            int results = MovieManager.Insert("Titanic", "Ship sinking", 1, 3, 3, (float)20.00, 1, "test.jpg", ref id, true);
            Assert.AreEqual(4, id);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void InsertTest2()
        {
            int id = 0;
            Movie movie = new Movie()
            {
                Title = "Movie Title",
                Description = "Movie Description",
                FormatId = 1,
                DirectorId = 2,
                RatingId = 3,
                Cost = (float)15.00,
                InStkQty = 4,
                ImagePath = "test.png"
            };

            int results = MovieManager.Insert(movie, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void UpdateTest()
        {
            Movie movie = MovieManager.LoadById(3);

            movie.Title = "Test";

            int results = MovieManager.Update(movie, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void DeleteTest()
        {
            int results = MovieManager.Delete(3, true);
            Assert.AreEqual(1, results);
        }
    }
}