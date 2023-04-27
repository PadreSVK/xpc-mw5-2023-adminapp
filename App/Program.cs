using AdminApp.App;
using AdminApp.DAL;
using System.Reflection;
using AdminApp.BLL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// todo-maintability why? it is already configured via WebApplication.CreateBuilder
var configurationBuilder = new ConfigurationBuilder();

configurationBuilder.AddJsonFile("appsettings.json");

var configuration = configurationBuilder.Build();
builder.Configuration.AddConfiguration(configuration);
// ⬆️ this is redundant why youy do it?

builder.Services
    .AddDALServices(builder.Configuration)
    .AddBLLServices()
    .AddControllersWithViews();

var app = builder.Build();

// todo you could use async.... why 
app.Services.GetRequiredService<IDbMigrator>().Migrate();

// Configure the HTTP request pipeline.
// todo-maintability why you do this? 
// https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-dev-certs
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
