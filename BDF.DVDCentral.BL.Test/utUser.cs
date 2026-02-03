namespace BDF.DVDCentral.BL.Test
{
    [TestClass]
    public class utUser : utBase<tblUser>
    {
        [TestMethod]
        public async Task LoginSuccessTest()
        {
            Assert.IsTrue(await new UserManager(options, logger).Login(new User { UserId = "bfoote", Password = "maple" }));
            Assert.IsTrue(await new UserManager(options, logger).Login(new User { UserId = "sophie", Password = "sophie" }));
        }

        [TestMethod]
        public async Task LoginFailTestNoUserId()
        {
            try
            {
                Assert.IsTrue(await new UserManager(options, logger).Login(new User { UserId = "", Password = "maple" }));
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
        public async Task LoginFailTestBadPassword()
        {
            try
            {
                Assert.IsTrue(await new UserManager(options, logger).Login(new User { UserId = "bfoote", Password = "birch" }));
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
        public async Task LoginFailTestBadUserId()
        {
            try
            {
                Assert.IsTrue(await new UserManager(options, logger).Login(new User { UserId = "foote", Password = "maple" }));
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
        public async Task LoginFailTestNoPassword()
        {
            try
            {
                Assert.IsTrue(await new UserManager(options, logger).Login(new User { UserId = "bfoote", Password = "" }));
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
        public async Task LoadTest()
        {
            Assert.AreEqual(4, (await new UserManager(options, logger).LoadAsync()).Count);
        }

        [TestMethod]
        public async Task InsertTest()
        {
            User user = new User()
            {
                FirstName = "Test",
                LastName = "Test",
                UserId = "Test",
                Password = "Test"
            };

            Guid results = await new UserManager(options, logger).InsertAsync(user, true);
            Assert.AreNotEqual(Guid.Empty, results);
        }

    }
}
