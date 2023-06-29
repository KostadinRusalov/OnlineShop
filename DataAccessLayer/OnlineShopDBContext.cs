using System;
using System.Data.Entity;

using BusinessLayer;

namespace DataAccessLayer
{
    public class OnlineShopDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public OnlineShopDBContext() : base("OnlineShopDB")
        {
        }
    }
}
