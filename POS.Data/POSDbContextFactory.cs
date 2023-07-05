using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using POS.Data.Catalog;
using POS.Data.Payment;

namespace POS.Data;

public class POSDbContextFactory : IDesignTimeDbContextFactory<POSDbContext>
{

    public POSDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<POSDbContext>();
        optionsBuilder.UseSqlServer("Server=;Database=POSTestDb;Trusted_Connection=True;");

        return new POSDbContext(optionsBuilder.Options);
    }
}
