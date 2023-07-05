## Project Structure

The project consists of the following sub-projects:

- `POS.Catalog.Api`
- `POS.Payment.Api`
- `POS.Data`

Each service in the project (`POS.Catalog.Api` and `POS.Payment.Api`) has its own DbContext:

1. **`CatalogDbContext`**: This context is used by `POS.Catalog.Api`. It's aware of and responsible for the `Products` DbSet.

2. **`PaymentDbContext`**: This context is used by `POS.Payment.Api`. It's aware of and responsible for the `Transactions` DbSet.

These two contexts are limited in scope and only handle their respective areas. They are not aware of the complete database schema.

The **`POSDbContext`** in `POS.Data` knows about the entire schema of the database and is responsible for managing the migrations and controlling the structure of the database.

## Migrations

In this project, migrations are controlled by the `POSDbContext` within the `POS.Data` project. The migrations can be run using the EF Core CLI tool or package manager console tools. 

The migration process leverages an `IDesignTimeDbContextFactory<>` implementation within the `POS.Data` project, providing EF Core with the necessary information to set up the `DbContext`.

### Adding a Migration

To add a new migration, perform the following steps:

1. Open the terminal or command prompt.
2. Navigate to the `POS.Data` project directory.
3. Run the following command:

#### EF Tools
```bash
dotnet ef migrations add <MigrationName> --context POSDbContext
dotnet ef database update --context POSDbContext
```
#### Package Manager Console Tools
```powershell
Add-Migration -Name <MigrationName> -Context POSDbContext
Update-Database -Context POSDbContext
```
