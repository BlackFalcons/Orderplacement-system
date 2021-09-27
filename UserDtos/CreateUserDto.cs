using System.ComponentModel.DataAnnotations;

namespace Orderplacement_system.UserDtos
{
    public class CreateUserDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string Street { get; set; }
        public string Note { get; set; }
    }
}
