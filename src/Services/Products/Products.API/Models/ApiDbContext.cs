
namespace Products.API.Models;
public class ApiDbContext : DbContext
{
    public ApiDbContext()
    {

    }

    public ApiDbContext( DbContextOptions<ApiDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //        => optionsBuilder.UseNpgsql("Host=localhost;Database=ProductsDb;Username=admin;Password=admin1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Name = "Paracetamol",
                DefaultCode =   " Pa_001_g001"
            }
            );
    }
}
