using BDF.DVDCentral.PL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    //private static SiteService _siteService;
    private static DVDCentralEntities dc;

    private static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddDbContext<DVDCentralEntities>(options => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BDF.DVDCentral.DB;Integrated Security=True"));

        //builder.Services.AddDbContextPool<DVDCentralEntities>(options =>
        //options.UseSqlServer(builder.Configuration.GetConnectionString("DVDCentralConnection"), builder =>
        //{
        //    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
        //}
        //));

        var serviceProvider = services.BuildServiceProvider();
        //_siteService = serviceProvider.GetService<SiteService>();
        dc = serviceProvider.GetService<DVDCentralEntities>();

        //DVDCentralEntities dc = services.BuildServiceProvider().GetRequiredService<DVDCentralEntities>();
        //var movies = dc.tblMovies.ToList();
        //movies.ForEach(m => Console.WriteLine(m.Title));
        //Console.WriteLine("Hello, World!");
        //Console.ReadLine();
    }
}