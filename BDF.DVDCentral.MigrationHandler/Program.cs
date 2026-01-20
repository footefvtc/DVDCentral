using BDF.DVDCentral.PL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add a service to the project. 
builder.Services.AddDbContext<DVDCentralEntities>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DVDCentralConnection"), builder =>
    {
        builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
    }
));

var app = builder.Build();

app.Run();
