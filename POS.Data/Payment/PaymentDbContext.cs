using Microsoft.EntityFrameworkCore;

namespace POS.Data.Payment;

public class PaymentDbContext : DbContext
{
    public DbSet<Transaction> Transactions { get; set; }
    public PaymentDbContext(DbContextOptions<PaymentDbContext> options) : base(options) { }
}
