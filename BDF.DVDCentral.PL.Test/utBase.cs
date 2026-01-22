namespace BDF.DVDCentral.PL.Test
{
    [TestClass]
    public abstract class utBase<T> where T : class
    {
        public required DVDCentralEntities dc;
        protected IDbContextTransaction? transaction;

        private IConfigurationRoot configuration;
        private DbContextOptions<DVDCentralEntities> options;


        public utBase()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            configuration = builder.Build();

            options = new DbContextOptionsBuilder<DVDCentralEntities>()
                .UseSqlServer(configuration.GetConnectionString("DVDCentralConnection"))
                .Options;

            dc = new DVDCentralEntities(options);
        }

        public List<T> LoadTest()
        {
            return dc.Set<T>().ToList();
        }

        public void LoadTest(int expected)
        {
            Assert.HasCount(expected, dc.Set<T>().ToList());

        }

        public int InsertTest(T entity)
        {
            dc.Set<T>().Add(entity);
            return dc.SaveChanges();
        }


        public int DeleteTest(T entity)
        {
            dc.Set<T>().Remove(entity);
            return dc.SaveChanges();
        }

        public int UpdateTest(T entity)
        {
            dc.Entry(entity).State = EntityState.Modified;
            return dc.SaveChanges();
        }

        [TestInitialize]
        public void Initialize()
        {
            dc = new DVDCentralEntities();
            transaction = dc.Database.BeginTransaction();
        }

        [TestCleanup]
        public void Cleanup()
        {
            transaction?.Rollback();
            transaction?.Dispose();
            dc = null!;
        }
    }
}
