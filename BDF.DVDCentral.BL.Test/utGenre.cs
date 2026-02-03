namespace BDF.DVDCentral.BL.Test
{
    [TestClass]
    public class utGenre : utBase<tblGenre>
    {
        [TestMethod]
        public async Task LoadTest()
        {
            Assert.AreEqual(10, (await new GenreManager(options, logger).LoadAsync()).Count);

        }


        [TestMethod]
        public async Task InsertTest()
        {
            Genre entity = new Genre()
            {
                Description = "Test"
            };

            Guid results = await new GenreManager(options, logger).InsertAsync(entity, true);
            Assert.AreNotEqual(Guid.Empty, results);
        }

        [TestMethod]
        public async Task UpdateTest()
        {
            Genre entity = (await new GenreManager(options, logger).LoadAsync()).FirstOrDefault();
            entity.Description = "Blah blah";
            Assert.IsTrue(new GenreManager(options, logger).UpdateAsync(entity, true).Result > 0);
        }

        [TestMethod]
        public async Task DeleteTest()
        {
            Genre entity = (await new GenreManager(options, logger).LoadAsync()).FirstOrDefault(x => x.Description == "Other");
            Assert.IsTrue(new GenreManager(options, logger).DeleteAsync(entity.Id, true).Result > 0);
        }

        [TestMethod]
        public async Task LoadByIdTest()
        {
            Genre entity = (await new GenreManager(options, logger).LoadAsync()).FirstOrDefault();
            Assert.AreEqual(new GenreManager(options, logger).LoadByIdAsync(entity.Id).Result.Id, entity.Id);

        }
    }
}