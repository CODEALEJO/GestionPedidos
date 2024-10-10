using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionPedidos.DTOs
{
   public class ProductDTO
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    public string Description { get; set; }

    [Range(0.01, double.MaxValue)]
    public double Price { get; set; }

    [Required]
    public string Stock { get; set; }

    [Required]
    public int CategoryId { get; set; }
}

}