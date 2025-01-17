﻿namespace Stores.Sales.Backend.BusinessObjects.Interfaces.Repositories;

public interface ICommandsRepository : IUnitOfWork
{
    Task CreateOrder(OrderAggregate order);
}
