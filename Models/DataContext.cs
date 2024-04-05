using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
namespace Northwind.Models;


public class DataContext : DbContext
{
  private readonly IConfiguration _configuration;

  public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
  {
    _configuration = configuration;
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    if (!optionsBuilder.IsConfigured)
    {
      optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Data:Northwind:ConnectionString"));
    }
  }

  public DbSet<Product> Products { get; set; }
  public DbSet<Category> Categories { get; set; }
}
