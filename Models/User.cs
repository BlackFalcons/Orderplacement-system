using System;

namespace Orderplacement_system.Models
{
    // Record types have better support for immutable objects. (Cannot modify)
    // When you compare 2 instances they will be equal if all the properties are the same.
    public record User
    {
        // init so you can modify the property during when it's being constructed but not after it's created.
        // Guid object useful to generate uniqe ID's
        public Guid Id { get; init; }
        public string Name { get; set; }
        public string Phone{ get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Note { get; set; }
    }
}
