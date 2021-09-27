using Orderplacement_system.Models;
using Orderplacement_system.UserDtos;

namespace Orderplacement_system
{
    public static class Extensions
    {
       // Data transfer Object used to filter out what data the client should be able to access.
        public static UserDto AsDto(this User user)
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
    }
}
