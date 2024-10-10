using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionPedidos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionPedidos.Seeders
{
    public static class OrderProductSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>().HasData(
                new OrderProduct { Id = 1, OrderId = 1, ProductId = 1, Quantity = 1 },
                new OrderProduct { Id = 2, OrderId = 2, ProductId = 2, Quantity = 2 }
            );
        }
    }

}