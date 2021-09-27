using System.ComponentModel.DataAnnotations;

namespace Orderplacement_system.UserDtos
{
    public class UpdateUserDto
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Note { get; set; }
    }
}
