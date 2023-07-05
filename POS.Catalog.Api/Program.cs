using Microsoft.EntityFrameworkCore;
using POS.Data.Catalog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<CatalogDbContext>(options => options.UseSqlServer("Server=;Database=POSTestDb;Trusted_Connection=True;"));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
