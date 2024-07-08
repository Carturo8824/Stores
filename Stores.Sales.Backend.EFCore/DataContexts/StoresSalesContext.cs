using Microsoft.Extensions.Options;
using Stores.Sales.Backend.EFCore.Options;

namespace Stores.Sales.Backend.EFCore.DataContexts
{
    internal class StoresSalesContext : DbContext
    {
        readonly IOptions<DBOptions> DBOptions;
        public StoresSalesContext(IOptions<DBOptions> dbOptions) =>
        DBOptions = dbOptions;
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(
    DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                DBOptions.Value.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
            Assembly.GetExecutingAssembly());
        }
    }
}
