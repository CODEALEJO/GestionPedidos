using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionPedidos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionPedidos.Seeders
{
    public static class OrderSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, Date = DateTime.Now, ClientId = 1 },
                new Order { Id = 2, Date = DateTime.Now, ClientId = 2 }
            );
        }
    }
}