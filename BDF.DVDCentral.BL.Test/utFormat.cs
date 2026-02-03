namespace BDF.DVDCentral.BL.Test
{
    [TestClass]
    public class utFormat : utBase<tblFormat>
    {
        [TestMethod]
        public async void LoadTest()
        {
            Assert.AreEqual(3, (await new FormatManager(options, logger).LoadAsync()).Count);
        }


        [TestMethod]
        public async void InsertTest()
        {
            Format entity = new Format()
            {
                Description = "Test"
            };

            Guid results = await new FormatManager(options, logger).InsertAsync(entity, true);
            Assert.AreNotEqual(Guid.Empty, results);
        }

        [TestMethod]
        public async Task UpdateTest()
        {
            Format entity = (await new FormatManager(options, logger).LoadAsync()).FirstOrDefault();
            entity.Description = "Blah blah";
            Assert.IsTrue(new FormatManager(options, logger).UpdateAsync(entity, true).Result > 0);
        }

        [TestMethod]
        public async Task DeleteTest()
        {
            Format entity = (await new FormatManager(options, logger).LoadAsync()).FirstOrDefault(x => x.Description == "Other");
            Assert.IsTrue(new FormatManager(options, logger).DeleteAsync(entity.Id, true).Result > 0);
        }

        [TestMethod]
        public async Task LoadByIdTest()
        {
            Format entity = (await new FormatManager(options, logger).LoadAsync()).FirstOrDefault();
            Assert.AreEqual(new FormatManager(options, logger).LoadByIdAsync(entity.Id).Result.Id, entity.Id);
        }
    }
}