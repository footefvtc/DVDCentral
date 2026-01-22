using BDF.DVDCentral.PL.Test;

namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utDirector : utBase<tblDirector>
    {

        [TestMethod]
        public void LoadTest()
        {
            var list = base.LoadTest();
            Assert.AreEqual(6, list.Count());
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
            var item = base.LoadTest().FirstOrDefault();

            // Change a property value
            item.FirstName = "Test";

            int result = UpdateTest(item);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblDirector where id = 3
            tblDirector entity = dc.tblDirectors.FirstOrDefault(e => e.FirstName == "Other");
            int result = DeleteTest(entity);
            Assert.AreNotEqual(result, 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            var item = base.LoadTest().FirstOrDefault();

            // Select * from tblDirector where id = 2
            tblDirector entity = dc.tblDirectors.Where(e => e.Id == item.Id).FirstOrDefault();
            Assert.AreEqual(entity.Id, item.Id);
        }


    }
}