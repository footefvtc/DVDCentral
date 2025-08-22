using FVTC.DVDCentral.BL.Models;
using FVTC.DVDCentral.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVTC.DVDCentral.BL.Test
{
    [TestClass]
    public class utUser
    {
        [TestMethod]
        public void LoginSuccessTest()
        {
            Seed();
            Assert.IsTrue(UserManager.Login(new User { UserId = "bfoote", Password = "maple" }));
            Assert.IsTrue(UserManager.Login(new User { UserId = "rgroff", Password = "fall2023" }));
        }

        [TestMethod]
        public void LoginFailTestNoUserId()
        {
            try
            {
                Seed();
                Assert.IsTrue(UserManager.Login(new User { UserId = "", Password = "maple" }));
            }
            catch (LoginFailureException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void LoginFailTestBadPassword()
        {
            try
            {
                Seed();
                Assert.IsTrue(UserManager.Login(new User { UserId = "bfoote", Password = "birch" }));
            }
            catch (LoginFailureException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void LoginFailTestBadUserId()
        {
            try
            {
                Seed();
                Assert.IsTrue(UserManager.Login(new User { UserId = "foote", Password = "maple" }));
            }
            catch (LoginFailureException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void LoginFailTestNoPassword()
        {
            try
            {
                Seed();
                Assert.IsTrue(UserManager.Login(new User { UserId = "bfoote", Password = "" }));
            }
            catch (LoginFailureException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void LoadTest()
        {
            Seed();
            Assert.AreEqual(2, UserManager.Load().Count());
        }

        [TestMethod]
        public void InsertTest()
        {
            User user = new User()
            {
                FirstName = "Test",
                LastName = "Test",
                UserId = "Test",
                Password = "Test"
            };

            int results = UserManager.Insert(user, true);
            Assert.AreEqual(1, results);
        }

        public void Seed()
        {
            UserManager.Seed();
        }
    }
}
