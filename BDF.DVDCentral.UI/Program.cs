using FVTC.Utility;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add the ability to access http context (session in this case)
builder.Services.AddHttpContextAccessor();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(1000);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7156/api/") });
builder.Services.AddSingleton(sp => new ApiClient("https://localhost:7156/api/"));
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://dvdcentralapi-120212964.azurewebsites.net/api/") });

builder.Services
    .AddLogging(c => c.AddDebug())
    .AddLogging(c => c.AddConsole());

var app = builder.Build();

app.Logger.LogWarning("Here");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Movie/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movie}/{action=Index}/{id?}");

app.Run();
