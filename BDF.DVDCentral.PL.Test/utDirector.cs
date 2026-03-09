using BDF.DVDCentral.PL.Test;

namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utDirector : utBase<tblDirector>
    {

        [TestMethod]
        public void LoadTest()
        {
            base.LoadTest(6);
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblDirector entity = new tblDirector();
            entity.Id = Guid.NewGuid();
            entity.FirstName = "FirstName";
            entity.LastName = "LastName";

            int result = InsertTest(entity);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblDirector - use the first one
            tblDirector entity = dc.tblDirectors.FirstOrDefault(e => e.FirstName == "Other")!;

            // Change a property value
            entity.FirstName = "Test";

            int result = UpdateTest(entity);
            Assert.IsGreaterThan(0, result);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblDirector where id = 3
            tblDirector entity = dc.tblDirectors.FirstOrDefault(e => e.FirstName == "Other")!;
            int result = DeleteTest(entity);
            Assert.IsGreaterThan(0, result);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            var item = dc.tblDirectors.FirstOrDefault()!;

            tblDirector entity = dc.tblDirectors.Where(e => e.Id == item.Id).FirstOrDefault()!;

            Assert.IsGreaterThan(0, entity!.Movies.Count);

            Assert.AreEqual(entity.Id, item.Id);
        }


    }
}