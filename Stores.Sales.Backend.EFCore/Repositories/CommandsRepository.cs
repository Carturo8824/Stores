namespace Stores.Sales.Backend.EFCore.Repositories;

internal class CommandsRepository(StoresSalesContext context) :
    ICommandsRepository
{
    public async Task CreateOrder(OrderAggregate order)
    {
        await context.AddAsync(order);
        await context.AddRangeAsync(order.OrderDetails
            .Select(d => new OrderDetail
            {
                Order = order,
                ProductId = d.ProductId,
                Quantity = d.Quantity,
                UnitPrice = d.UnitPrice
            }).ToArray());
    }
    public async Task SaveChanges() =>
        await context.SaveChangesAsync();
}
