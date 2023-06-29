using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Address { get; set; }

        public string Telephone { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
