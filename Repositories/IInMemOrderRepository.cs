using Orderplacement_system.Models;
using System;
using System.Collections.Generic;

namespace Orderplacement_system.Repositories
{
    public interface IInMemOrderRepository
    {
        Order GetOrder(Guid orderId);
        IEnumerable<Order> GetOrders();
    }
}