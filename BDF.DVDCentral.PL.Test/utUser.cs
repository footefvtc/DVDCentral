namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utUser : utBase<tblUser>
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
            tblUser entity = new tblUser();
            entity.FirstName = "Yolanda";
            entity.LastName = "Yolanda";
            entity.UserId = "";

            int result = InsertTest(entity);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblUser - use the first one
            tblUser entity = base.LoadTest().FirstOrDefault()!;

            // Change a property value
            entity.FirstName = "Test";

            int result = UpdateTest(entity);

            Assert.IsGreaterThan(result, 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblUser where id = 3
            tblUser entity = base.LoadTest().FirstOrDefault(e => e.FirstName == "Other")!;

            int result = DeleteTest(entity);
            Assert.AreNotEqual(0, result);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            tblUser item = base.LoadTest()!.FirstOrDefault()!;
            tblUser entity = dc.tblUsers.Where(e => e.Id == item.Id).FirstOrDefault()!;
            Assert.AreEqual(item.Id, entity.Id);
        }


    }
}