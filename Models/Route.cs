using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSLBooking.Models;

public class Route
{
    public long RouteId { get; set; }

    [Range(1, 999999, ErrorMessage = "PLease enter a positive number")]
    public int RouteNumber { get; set; }

    [Required(ErrorMessage = "Please enter a route name")]
    public string Name { get; set; } = String.Empty;

    [Required(ErrorMessage = "Please enter a description")]
    public string Description { get; set; } = String.Empty;

    [Required(ErrorMessage = "Please enter 1. location")]
    public string Location1 { get; set; } = String.Empty;

    [Required(ErrorMessage = "Please enter 2. location")]
    public string Location2 { get; set; } = String.Empty;

    [Range(1, 999999, ErrorMessage = "PLease enter a positive price")]
    [Column(TypeName = "decimal(8,2)")]
    public decimal Price { get; set; }

    public long RouteTypeId { get; set; }
    public RouteType? Type { get; set; }
}