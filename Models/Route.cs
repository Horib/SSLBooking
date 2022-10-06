using System.ComponentModel.DataAnnotations.Schema;

namespace SSLBooking.Models;

public class Route
{
    public long? RouteId { get; set; }
    public int RouteNumber { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;

    public string Location1 { get; set; } = String.Empty;
    public string Location2 { get; set; } = String.Empty;

    [Column(TypeName = "decimal(8,2)")] public decimal Price { get; set; }
}