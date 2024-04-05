using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Northwind.Models;


var builder = WebApplication.CreateBuilder(args);

// Add configuration
IConfiguration configuration = builder.Configuration;

builder.Services.AddControllersWithViews();

// Register the DataContext service
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(configuration["Data:Northwind:ConnectionString"]));

var app = builder.Build();

// Apply migrations
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<DataContext>();
    context.Database.Migrate();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
