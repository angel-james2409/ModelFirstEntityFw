using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderProject.Models;

namespace OrderProject.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext (DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<OrderProject.Models.Product> Product { get; set; }

        public DbSet<OrderProject.Models.Order> Order { get; set; }
    }
}
