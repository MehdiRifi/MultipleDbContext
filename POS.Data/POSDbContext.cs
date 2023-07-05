using Microsoft.EntityFrameworkCore;
using POS.Data.Catalog;
using POS.Data.Payment;

namespace POS.Data;

public class POSDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public POSDbContext(DbContextOptions<POSDbContext> options) : base(options) { }
}
