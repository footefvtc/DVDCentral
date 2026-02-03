using Microsoft.Extensions.Logging;

namespace BDF.DVDCentral.BL.Test
{
    [TestClass]
    public abstract class utBase<T> where T : class
    {
        public required DVDCentralEntities dc;
        protected IDbContextTransaction? transaction;

        private IConfigurationRoot configuration;
        protected DbContextOptions<DVDCentralEntities> options;
        protected readonly ILogger logger;


        public utBase()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            configuration = builder.Build();

            options = new DbContextOptionsBuilder<DVDCentralEntities>()
                .UseSqlServer(configuration.GetConnectionString("DVDCentralConnection"))
                .UseLazyLoadingProxies()
                .Options;

            dc = new DVDCentralEntities(options);
        }

        [TestInitialize]
        public void Initialize()
        {
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
