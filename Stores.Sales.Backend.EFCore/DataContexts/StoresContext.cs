namespace Stores.Sales.Backend.EFCore.DataContexts;

internal class StoresContext : DbContext
{
    protected override void OnConfiguring(
DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
        "Server = 10.10.13.55; Port = 5432; Database = stores; User Id = stores; Password = stores;");
    }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
        Assembly.GetExecutingAssembly());
    }
}
