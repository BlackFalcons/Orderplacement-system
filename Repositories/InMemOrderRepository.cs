using Orderplacement_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Orderplacement_system.Repositories
{
    public class InMemOrderRepository : IInMemOrderRepository
    {
        private readonly List<Order> Orders = new()
        {
            new Order
            {
                OrderUser = new User
                {
                    Id = Guid.NewGuid(),
                    Name = "John Test",
                    Email = "John.Test@gmail.com",
                    Phone = "999 99 999",
                    City = "Testing",
                    Street = "Testroad 43",
                    ZipCode = "1000"
                },
                OrderId = Guid.NewGuid(),
                ServiceOrderId = 2,
                MovingFrom = "Grensen 3, 0159 Oslo",
                MovingTo = "Slottsplassen 1, 0010 Oslo",
                OrderDate = new DateTime(2021, 11, 10, 7, 30, 0),
                Note = "Etasje 3, er opptatt til klokka 10 på morgenen."
            }
        };

        public IEnumerable<Order> GetOrders()
        {
            return Orders;
        }

        public Order GetOrder(Guid id)
        {
            return Orders.Where(Order => Order.OrderId == id).SingleOrDefault();
        }

    }
}
