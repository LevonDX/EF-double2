using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ED_double2.Data.Entities;

namespace ED_double2.Data.Context
{
    public class ProductDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=ProductDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Clothing" },
                new Category { Id = 3, Name = "Home Appliances" },
                new Category { Id = 4, Name = "Books" },
                new Category { Id = 5, Name = "Sports" }
            );

            // Seed products
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Price = 999.99m, CategoryId = 1 },
                new Product { Id = 2, Name = "T-Shirt", Price = 19.99m, CategoryId = 2 },
                new Product { Id = 3, Name = "Refrigerator", Price = 1499.99m, CategoryId = 3 },
                new Product { Id = 4, Name = "Novel", Price = 9.99m, CategoryId = 4 },
                new Product { Id = 5, Name = "Football", Price = 29.99m, CategoryId = 5 }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
