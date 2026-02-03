namespace BDF.DVDCentral.BL.Test
{
    [TestClass]
    public class utDirector : utBase<tblDirector>
    {
        [TestMethod]
        public async Task LoadTest()
        {
            Assert.IsGreaterThan(0, (await new DirectorManager(options, logger).LoadAsync()).Count);
        }

        [TestMethod]
        public async Task InsertTest()
        {
            int id = 0;
            Director entity = new Director()
            {
                FirstName = "Test",
                LastName = "Test"
            };

            Guid results = await new DirectorManager(options, logger).InsertAsync(entity, true);
            Assert.AreNotEqual(Guid.Empty, results);
        }

        [TestMethod]
        public async Task UpdateTest() 
        {
            Director entity = (await new DirectorManager(options, logger).LoadAsync()).FirstOrDefault()!;
            entity.FirstName = "Test";
            Assert.IsGreaterThan(0, new DirectorManager(options, logger).UpdateAsync(entity, true).Result);
        }

        [TestMethod]
        public async Task DeleteTest()
        {
            Director entity = (await new DirectorManager(options, logger).LoadAsync()).FirstOrDefault()!;
            Assert.IsGreaterThan(0, new DirectorManager(options, logger).DeleteAsync(entity.Id, true).Result);
        }
    }
}