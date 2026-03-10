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
            await Assert.ThrowsAsync<LoginFailureException>(async () =>
            {
                await new UserManager(options, logger).Login(new User { UserId = "", Password = "birch" });
            });
        }

        [TestMethod]
        public async Task LoginFailTestBadPassword()
        {
            await Assert.ThrowsAsync<LoginFailureException>(async () =>
            {
                await new UserManager(options, logger).Login(new User { UserId = "bfoote", Password = "birch" });
            });
        }            

        [TestMethod]
        public async Task LoginFailTestBadUserId()
        {
            await Assert.ThrowsAsync<LoginFailureException>(async () =>
            {
                await new UserManager(options, logger).Login(new User { UserId = "foote", Password = "maple" });
            });
            
        }

       
        [TestMethod]
        public async Task LoginFailTestNoPassword()
        {
            await Assert.ThrowsAsync<LoginFailureException>(async () =>
            {
                await new UserManager(options, logger).Login(new User { UserId = "bfoote", Password = "" });
            });
            
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
