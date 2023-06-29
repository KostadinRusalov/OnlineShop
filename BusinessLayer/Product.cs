using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public abstract class Product
    {
        [Key]
        public string Barcode { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Brand Brand { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
