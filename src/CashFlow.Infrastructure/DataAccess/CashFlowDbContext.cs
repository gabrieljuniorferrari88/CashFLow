using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace CashFlow.Infrastructure.DataAccess;

internal class CashFlowDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Database=CASH;User Id=sa;Password=Bisc0ito;MultipleActiveResultSets=True;Encrypt=YES;TrustServerCertificate=YES;";

        optionsBuilder.UseSqlServer(connectionString);
    }
}