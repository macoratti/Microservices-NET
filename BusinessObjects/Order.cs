using System.ComponentModel.DataAnnotations;

namespace BusinessObjects;

//SQLite
public class Order
{
    [Key]
    public int OrderID { get; set; }
    public DateTime? OrderDate { get; set; }
    public int CustomerId { get; set; }
}
