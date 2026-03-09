using BDF.DVDCentral.PL.Test;

namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public class utUser : utBase<tblUser>
    {

        [TestMethod]
        public void LoadTest()
        {
            LoadTest(4);
        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblUser entity = new tblUser();
            entity.FirstName = "Test";
            entity.LastName = "Test";
            entity.UserId = "bfoote";
            entity.Password = "TestSecret";

            // Add the entity to the database
            dc.tblUsers.Add(entity);

            // Commit the changes
            int result = dc.SaveChanges();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // SELECT * FROM tblUsers - use the first one
            tblUser entity = dc.tblUsers.FirstOrDefault()!;

            // Change a property value
            entity.FirstName = "Test";

            int result = dc.SaveChanges();
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Select * from tblUser where id = 2
            tblUser entity = dc.tblUsers.FirstOrDefault(x => x.FirstName == "Other")!;

            dc.tblUsers.Remove(entity);
            int result = dc.SaveChanges();
            Assert.IsGreaterThan(0, result);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            //var items = base.LoadTest();
            // Select * from tblUser where id = 2
            //tblUser entity = dc.tblUsers.FirstOrDefault(u => u.FirstName == "Other");
            // Assert.AreEqual(entity.Id, 2);
        }

    }
}