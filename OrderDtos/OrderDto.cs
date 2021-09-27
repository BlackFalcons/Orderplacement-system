using System;

namespace Orderplacement_system.OrderDtos
{
    public record OrderDto
    {
        public Guid OrderId { get; init; }
        public int ServiceOrderId { get; set; }
        public string MovingFrom { get; set; }
        public string MovingTo { get; set; }
        public DateTime OrderDate { get; set; }
        public string Note { get; set; }
    }
}
