﻿namespace Stores.Sales.Backend.UseCases.CreateOrder;

internal class CreateOrderInteractor(
ICreateOrderOutputPort outputPort,
ICommandsRepository repository) : ICreateOrderInputPort
{
    public async Task Handle(CreateOrderDto orderDto)
    {
        OrderAggregate Order = OrderAggregate.From(orderDto);
        await repository.CreateOrder(Order);
        await repository.SaveChanges();
        await outputPort.Handle(Order);
    }
}
