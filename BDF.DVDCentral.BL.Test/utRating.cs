using BDF.DVDCentral.BL.Models;
using BDF.DVDCentral.PL;

namespace BDF.DVDCentral.BL.Test
{
    [TestClass]
    public class utRating
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(4, RatingManager.Load().Count());
        }

        [TestMethod]
        public void InsertTest1()
        {
            int id = 0;
            int results = RatingManager.Insert("Not Rated", ref id, true);
            Assert.AreEqual(5, id);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void InsertTest2()
        {
            int id = 0;
            Rating rating = new Rating()
            {
                Description = "Rating Description"
            };

            int results = RatingManager.Insert(rating, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void UpdateTest()
        {
            Rating rating = RatingManager.LoadById(3);

            rating.Description = "Test";

            int results = RatingManager.Update(rating, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void DeleteTest()
        {
            int results = RatingManager.Delete(3, true);
            Assert.AreEqual(1, results);
        }
    }
}