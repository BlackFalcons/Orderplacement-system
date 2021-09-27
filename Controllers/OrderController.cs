using Microsoft.AspNetCore.Mvc;
using Orderplacement_system.OrderDtos;
using Orderplacement_system.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Orderplacement_system.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IInMemOrderRepository repository;

        public OrderController(IInMemOrderRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<OrderDto> GetOrders()
        {
            var items = repository.GetOrders().Select(order => order.AsOrderDto());

            return items;
        }
    }
}
