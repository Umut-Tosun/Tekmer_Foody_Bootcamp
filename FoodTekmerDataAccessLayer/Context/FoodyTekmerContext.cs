using FoodyTekmerEntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTekmerDataAccessLayer.Context
{
    public class FoodyTekmerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-ETHQG58O\\sqlexpress;initial catalog=FoodTekmertDb;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Testimonial> Testimonials { get; set;}
        public DbSet<Product> Products { get; set; } 
    }
}
