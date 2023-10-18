using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjects;

//SQL Server
public class Product
{
    [Key]
    public int ProductId { get; set; }
    [MaxLength(100)]
    public string? ProductName { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal Price { get; set; }
    [MaxLength(300)]
    public string? Description { get; set; }
}
