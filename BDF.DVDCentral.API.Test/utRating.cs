namespace BDF.DVDCentral.API.Test
{
    [TestClass]
    public class utRating : utBase
    {
        [TestMethod]
        public async Task LoadTestAsync()
        {
            await LoadTestAsync<Rating>(4);
        }
        [TestMethod]
        public async Task InsertTestAsync()
        {
            await base.InsertTestAsync<Rating>(new Rating { Description = "Test" });
        }

        [TestMethod]
        public async Task DeleteTestAsync()
        {
            await base.DeleteTestAsync<Rating>(e => e.Description == "Other");
        }

        [TestMethod]
        public async Task LoadByIdTestAsync()
        {
            await base.LoadByIdTestAsync<Rating>(e => e.Description == "Other");
        }

        [TestMethod]
        public async Task UpdateTestAsync()
        {
            await base.UpdateTestAsync<Rating>(e => e.Description == "Other", new Rating { Description = "Test" });

        }


    }
}