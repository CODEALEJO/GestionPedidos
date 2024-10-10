using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionPedidos.Models;

[Table("orders")]
public class Order
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Column("date")]
    public DateTime Date { get; set; }

    [Column("client_id")]
    public int ClientId { get; set; }

    [ForeignKey("ClientId")]
    public Client Client { get; set; }
}