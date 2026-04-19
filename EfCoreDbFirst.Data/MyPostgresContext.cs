using EfCoreDbFirst.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EfCoreDbFirst.Data;

public class MyPostgresContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> table_authors { get; set; }
    
    public MyPostgresContext()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        
        optionsBuilder
            .UseNpgsql(config.GetConnectionString("DefaultConnection"))
            .LogTo(Console.WriteLine, LogLevel.Information);
    }
}