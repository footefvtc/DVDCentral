using Azure.Identity;
using BDF.DVDCentral.API.Hubs;
using BDF.DVDCentral.API.Services;
using FVTC.Utility;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Ui.MsSqlServerProvider;
using Serilog.Ui.Web;
using Serilog.Ui.Web.Extensions;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        string? connectionString = null;
        connectionString = KeyVaultClient.GetSecret("Connection-String-Prod").Result;
        string info = "Connection string retrieved from Key Vault: " + (connectionString != null ? "Yes" : "No");
        if (connectionString == null)
        {
            connectionString = builder.Configuration.GetConnectionString("DVDCentralConnection");
            info += " (fallback to appsettings.json)";
        }

        // Add services to the container.
        builder.Services.AddDbContextPool<DVDCentralEntities>(options =>
        {
            //options.UseSqlServer(builder.Configuration.GetConnectionString("DVDCentralConnection"));
            options.UseSqlServer(connectionString);
            options.UseLazyLoadingProxies();
        });

        builder.Services.AddSignalR()
            .AddJsonProtocol(options =>
            {
                options.PayloadSerializerOptions.PropertyNamingPolicy = null;
            });

        // configure strongly typed settings object
        builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
        // configure DI for application services
        builder.Services.AddScoped<IUserService, UserService>();

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddSerilogUi(options =>
        {
            options.UseSqlServer(connectionString, "Logs");
        });


        var configSettings = new ConfigurationBuilder()
          .AddJsonFile("appsettings.json")
          .Build();

        Log.Logger = new LoggerConfiguration()
             .ReadFrom.Configuration(configSettings)
             .CreateLogger();
#pragma warning disable CA1416
        builder.Services
            .AddLogging(c => c.AddDebug())
            .AddLogging(c => c.AddSerilog())
            .AddLogging(c => c.AddEventLog())
            .AddLogging(c => c.AddConsole());

        var app = builder.Build();

        app.Logger.LogInformation("Starting DVDCentral API...");
        
        //ManagedIdentityCredential credential = new ManagedIdentityCredential();
        //DefaultAzureCredential credential = new DefaultAzureCredential();
        app.Logger.LogWarning(info + " {UserId}", "System");

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment() || true)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseMiddleware<JwtMiddleware>();
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();

        app.MapControllers();
        app.MapHub<DVDCentralHub>("/dvdcentralhub");

        app.Run();
    }
}