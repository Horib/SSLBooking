namespace SSLBooking.Models;

public class RouteType
{
    public long RouteTypeId { get; set; }
    public string Name { get; set; } = String.Empty;

    public IEnumerable<Route>? Routes { get; set; }
}