using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionPedidos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionPedidos.Data;
public class ApplicationDbcontext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }


    public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options)
        : base(options)
    {
    }

}
