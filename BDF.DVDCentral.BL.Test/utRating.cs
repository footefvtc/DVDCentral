namespace BDF.DVDCentral.BL.Test
{
    [TestClass]
    public class utRating : utBase<tblRating>
    {
        [TestMethod]
        public async Task LoadTest()
        {
            Assert.AreEqual(5, (await new RatingManager(options, logger).LoadAsync()).Count);
        }


        [TestMethod]
        public async Task InsertTest()
        {
            Rating entity = new Rating()
            {
                Description = "Test"
            };

            Guid results = await new RatingManager(options, logger).InsertAsync(entity, true);
            Assert.AreNotEqual(Guid.Empty, results);
        }

        [TestMethod]
        public async Task UpdateTest()
        {
            Rating entity = (await new RatingManager(options, logger).LoadAsync()).FirstOrDefault();
            entity.Description = "Blah blah";
            Assert.IsTrue(new RatingManager(options, logger).UpdateAsync(entity, true).Result > 0);
        }

        [TestMethod]
        public async Task DeleteTest()
        {
            Rating entity = (await new RatingManager(options, logger).LoadAsync()).FirstOrDefault(x => x.Description == "Other");
            Assert.IsTrue(new RatingManager(options, logger).DeleteAsync(entity.Id, true).Result > 0);
        }

        [TestMethod]
        public async Task LoadByIdTest()
        {
            Rating entity = (await new RatingManager(options, logger).LoadAsync()).FirstOrDefault();
            Assert.AreEqual(new RatingManager(options, logger).LoadByIdAsync(entity.Id).Result.Id, entity.Id);
        }
    }
}