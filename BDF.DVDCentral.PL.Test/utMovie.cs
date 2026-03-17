using BDF.DVDCentral.PL.Test;

namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utMovie : utBase<tblMovie>
    {

        [TestMethod]
        public void LoadTest()
        {
            LoadTest(7);
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblMovie entity = new tblMovie();
            entity.Id = Guid.NewGuid();
            entity.Title = "Movie Description";
            entity.ImagePath = string.Empty;
            entity.Description = string.Empty;
            entity.Cost = 3;
            entity.DirectorId = dc.tblMovies.FirstOrDefault()!.DirectorId;
            entity.RatingId = dc.tblMovies.FirstOrDefault()!.RatingId;
            entity.FormatId = dc.tblMovies.FirstOrDefault()!.FormatId;
            entity.InStkQty = 3;

            int result = InsertTest(entity);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblMovie - use the first one
            var item = dc.tblMovies.FirstOrDefault()!;

            // Change a property value
            item.Title = "Test";

            int result = UpdateTest(item);
            Assert.IsGreaterThan(0, result);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblMovie where id = 3
            tblMovie entity = dc.tblMovies.FirstOrDefault(e => e.Title == "Other")!;
            int result = DeleteTest(entity);
            Assert.IsGreaterThan(0, result);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            var item = dc.tblMovies.FirstOrDefault();

            // Select * from tblMovie where id = 2
            tblMovie entity = dc.tblMovies
                .Include(x => x.Director)
                .Include(x => x.MovieGenres).ThenInclude(y => y.Genre)
                .Where(e => e.Id == item!.Id).FirstOrDefault()!;
            Assert.AreEqual(entity.Id, item!.Id);
            Assert.IsNotNull(entity.Director);
            var row = entity.MovieGenres.FirstOrDefault()!;

            Assert.IsNotNull(row.Genre);

        }

    }
}