using System;

namespace Orderplacement_system.Models
{
    public record Order
    {
        public User OrderUser { get; init; }
        public Guid OrderId { get; init; }
        public int ServiceOrderId { get; set; } // 1 = Moving, 2 = Packing, 3 = Cleaning
        public string MovingFrom { get; set; } // Grensen 3, 0159 Oslo
        public string MovingTo { get; set; } // Slottsplassen 1, 0010 Oslo
        public DateTime OrderDate { get; set; } // MM/dd/yyyy HH:mm
        public string Note { get; set; } // 3. Etasje og kunden er ikke tilgjengelig før klokken 12.
    }
}
