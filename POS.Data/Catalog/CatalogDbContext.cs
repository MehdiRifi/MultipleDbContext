using Microsoft.EntityFrameworkCore;

namespace POS.Data.Catalog;

public class CatalogDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options) { }
}
