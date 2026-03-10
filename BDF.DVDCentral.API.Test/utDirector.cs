
namespace BDF.DVDCentral.API.Test
{
    [TestClass]
    public class utDirector : utBase
    {

        [TestMethod]
        public async Task LoadTestAsync()
        {
            await base.LoadTestAsync<Director>(4);
        }

        [TestMethod]
        public async Task InsertTestAsync()
        {
            await base.InsertTestAsync<Director>(new Director { FirstName = "Test", LastName = "Test" });
        }

        [TestMethod]
        public async Task DeleteTestAsync()
        {
            await base.DeleteTestAsync<Director>(e => e.FirstName == "Other");
        }

        [TestMethod]
        public async Task LoadByIdTestAsync()
        {
            await base.LoadByIdTestAsync<Director>(e => e.FirstName == "Other");
        }

        [TestMethod]
        public async Task UpdateTestAsync()
        {
            await base.UpdateTestAsync<Director>(e => e.FirstName == "Other",
                                                 new Director { FirstName = "Test", LastName = "Test" });

        }
    }
}