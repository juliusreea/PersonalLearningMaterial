using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkRelations.Models;

public class BrickAvailability
{
    public int Id { get; set; }
    public Vendor Vendor { get; set; }
    public Brick Brick { get; set; }
    public int AvailableAmount { get; set; }
    [Column(TypeName = "decimal(8, 2)")]
    public decimal PriceEur { get; set; }
}
