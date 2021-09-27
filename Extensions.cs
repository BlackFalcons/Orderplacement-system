using Orderplacement_system.Models;
using Orderplacement_system.OrderDtos;
using Orderplacement_system.UserDtos;

namespace Orderplacement_system
{
    public static class Extensions
    {
       // Data transfer Object used to filter out what data the client should be able to access.
        public static UserDto AsUserDto(this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                Name = user.Name,
                Phone = user.Phone,
                Email = user.Email,
                City = user.City,
                ZipCode = user.ZipCode,
                Street = user.Street,
                Note = user.Note
            };
        }
        public static OrderDto AsOrderDto(this Order order)
        {
            return new OrderDto
            {
                OrderId = order.OrderId,
                ServiceOrderId = order.ServiceOrderId,
                MovingFrom = order.MovingFrom,
                MovingTo = order.MovingTo,
                OrderDate = order.OrderDate,
                Note = order.Note
            };
        }
    }
}
