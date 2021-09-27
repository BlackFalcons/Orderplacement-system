using System;

namespace Orderplacement_system.UserDtos
{
    // Data Transfer Objects (DTOs) https://docs.microsoft.com/en-us/aspnet/web-api/overview/data/using-web-api-with-entity-framework/part-5
    public record UserDto
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Note { get; set; }
    }
}
