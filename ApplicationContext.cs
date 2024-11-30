using Microsoft.EntityFrameworkCore;

namespace ShopBook;

public class ApplicationContext : DbContext
{
    public DbSet<User> User { get; set; } = null!;
    public DbSet<Book> Book { get; set; }

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Base_1;Username=postgres;Password=1234");
    }
}