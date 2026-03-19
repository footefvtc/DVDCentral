using BDF.DVDCentral.API.Helpers;
using BDF.DVDCentral.API.Hubs;
using BDF.DVDCentral.API.Services;
using FVTC.Utility;
using Microsoft.Extensions.Configuration;
using Serilog;
using static Microsoft.CodeAnalysis.CSharp.SyntaxTokenParser;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        string? connectionString = KeyVaultClient.GetSecret("Connection-String-Prod").Result;
        if(connectionString == null)
            connectionString = builder.Configuration.GetConnectionString("DVDCentralConnection");

        // Add services to the container.
        builder.Services.AddDbContextPool<DVDCentralEntities>(options =>
        {
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

        var configSettings = new ConfigurationBuilder()
          .AddJsonFile("appsettings.json")
          .Build();

        Log.Logger = new LoggerConfiguration()
             .ReadFrom.Configuration(configSettings)
             .CreateLogger();

        builder.Services
            .AddLogging(c => c.AddDebug())
            .AddLogging(c => c.AddSerilog())
            .AddLogging(c => c.AddEventLog())
            .AddLogging(c => c.AddConsole());

        var app = builder.Build();

        app.Logger.LogInformation("Starting DVDCentral API...");

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseMiddleware<JwtMiddleware>();
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();

        //app.MapControllers();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapHub<DVDCentralHub>("/dvdcentralhub");
        });

        app.Run();
    }
}