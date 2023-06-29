using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public List<Product> Products { get; set; }

        [Required]
        public List<int> Quantity { get; set; }

        public decimal Price { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public OrderStatus Status { get; set; }
    }
}
