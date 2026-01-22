namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utDirector : utBase<tblDirector>
    {

        [TestMethod]
        public void LoadTest()
        {
            LoadTest(3);
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblDirector entity = new tblDirector();
            entity.FirstName = "Yolanda";
            entity.LastName = "Smith";
            
            int result = InsertTest(entity);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblDirector - use the first one
            tblDirector entity = base.LoadTest().FirstOrDefault()!;

            // Change a property value
            entity.FirstName = "Test";

            int result = UpdateTest(entity);

            Assert.IsGreaterThan(result, 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblDirector where id = 3
            tblDirector entity = base.LoadTest().FirstOrDefault(e => e.FirstName == "Other")!;

            int result = DeleteTest(entity);
            Assert.AreNotEqual(0, result);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            tblDirector item = base.LoadTest()!.FirstOrDefault()!;
            tblDirector entity = dc.tblDirectors.Where(e => e.Id == item.Id).FirstOrDefault()!;
            Assert.AreEqual(item.Id, entity.Id);
        }


    }
}