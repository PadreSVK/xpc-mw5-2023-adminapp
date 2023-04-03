using AdminApp.App;
using AdminApp.DAL;
using System.Reflection;
using AdminApp.BLL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var configurationBuilder = new ConfigurationBuilder();
configurationBuilder.AddJsonFile("appsettings.json");

var configuration = configurationBuilder.Build();
builder.Configuration.AddConfiguration(configuration);

builder.Services
    .AddDALServices(builder.Configuration)
    .AddBLLServices()
    .AddControllersWithViews();

var app = builder.Build();

app.Services.GetRequiredService<IDbMigrator>().Migrate();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
