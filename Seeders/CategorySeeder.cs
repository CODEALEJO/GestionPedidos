using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionPedidos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionPedidos.Seeders
{
    public static class CategorySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics", Description = "Electronic devices and gadgets." },
                new Category { Id = 2, Name = "Furniture", Description = "Household furniture." },
                new Category { Id = 3, Name = "Clothing", Description = "Apparel and accessories." }
            );
        }
    }

}