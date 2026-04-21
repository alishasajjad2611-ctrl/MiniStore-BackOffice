using System;

namespace App.Core.Models
{
    public class Customer
    {
        public string Id { get; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public Customer()
        {
            Id = $"{Guid.NewGuid():N}[0..9]C";
        }
    }
}
