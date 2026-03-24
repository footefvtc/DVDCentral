using BDF.DVDCentral.BL.Models;
using BDF.DVDCentral.PL.Entities;
using FVTC.Utility.Reporting;
using Microsoft.Extensions.Options;

namespace BDF.DVDCentral.BL.Test
{
    [TestClass]
    public class utMovie : utBase<tblMovie>
    {

        [TestMethod]
        public async Task ExportDataTest()
        {
            var movies = await new MovieManager(options, logger).LoadAsync();
            string[] columns = { "Title", "DirectorFullName", "RatingDescription", "FormatDescription", "Cost", "InStkQty" };
            var data = MovieManager.ConvertData(movies, columns);
            Excel.ExportToExcel(data, "Movies.xlsx");
           
            //Excel.ExportToExcel(movies, "Movies.xlsx");
        }



        [TestMethod]
        public async Task LoadTest()
        {
            var movies = await new MovieManager(options, logger).LoadAsync();
            Assert.AreEqual(7, movies.Count);
            Assert.IsTrue(movies[0].Genres.Count > 0);
            Assert.IsNotNull(movies[0].DirectorFullName);
            Assert.IsNotNull(movies[0].FormatDescription);
        }

        [TestMethod]
        public async Task LoadByIdTest()
        {
            var movie = new MovieManager(options, logger).LoadAsync().Result.FirstOrDefault();
            Assert.AreEqual(new MovieManager(options, logger).LoadByIdAsync(movie.Id).Result.Id, movie.Id);
        }

        public async Task InsertTest()
        {
            Movie movie = new Movie
            {
                Id = Guid.NewGuid(),
                Title = "XXXXX",
                Description = "XXXXX",
                Cost = 9.99f,
                RatingId = (await new RatingManager(options, logger).LoadAsync()).FirstOrDefault().Id,
                FormatId = (await new FormatManager(options, logger).LoadAsync()).FirstOrDefault().Id,
                DirectorId = (await new DirectorManager(options, logger).LoadAsync()).FirstOrDefault().Id,
                InStkQty = 0,
                ImagePath = "XXXXXXX"
            };

            Guid result = await new MovieManager(options, logger).InsertAsync(movie, true);
            Assert.AreNotEqual(result, Guid.Empty);
        }


        [TestMethod]
        public async Task UpdateTest()
        {
            Movie entity = (await new MovieManager(options, logger).LoadAsync()).FirstOrDefault();
            entity.Description = "Blah blah";
            Assert.IsTrue(new MovieManager(options, logger).UpdateAsync(entity, true).Result > 0);
        }

        [TestMethod]
        public async Task DeleteTest()
        {
            Movie entity = (await new MovieManager(options, logger).LoadAsync()).FirstOrDefault(x => x.Title == "Other");
            Assert.IsTrue(new MovieManager(options, logger).DeleteAsync(entity.Id, true).Result > 0);
        }


    }
}