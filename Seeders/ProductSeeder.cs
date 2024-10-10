using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionPedidos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionPedidos.Seeders
{
    public static class ProductSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Laptop", Description = "15-inch laptop", Price = 999.99, Stock = "10", CategoryId = 1 },
            new Product { Id = 2, Name = "Sofa", Description = "Comfortable 3-seater sofa", Price = 499.99, Stock = "5", CategoryId = 2 },
            new Product { Id = 3, Name = "T-Shirt", Description = "Cotton t-shirt", Price = 19.99, Stock = "20", CategoryId = 3 }
        );
    }
}

}