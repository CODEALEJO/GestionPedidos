using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionPedidos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionPedidos.Seeders
{
    public static class ClientSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 1, Name = "John Doe", Address = "123 Elm St", Phone = "555-0123" },
                new Client { Id = 2, Name = "Jane Smith", Address = "456 Oak St", Phone = "555-0456" },
                new Client { Id = 3, Name = "Alice Johnson", Address = "789 Pine St", Phone = "555-0789" }
            );
        }
    }

}