using Microsoft.Extensions.Options;
using Stores.Sales.Backend.EFCore.Options;

namespace Stores.Sales.Backend.EFCore.DataContexts;

internal class StoresContext : DbContext
{
    readonly IOptions<DBOptions> DBOptions;
    public StoresContext(IOptions<DBOptions> dbOptions) =>
        DBOptions = dbOptions;
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }

    protected override void OnConfiguring(
DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            DBOptions.Value.ConnectionString);
    }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
        Assembly.GetExecutingAssembly());
    }
}
