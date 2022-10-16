namespace SSLBooking.Models;

public class RouteViewModel
{
    public Route Route { get; set; } = new Route();
    public string Action { get; set; } = "Create";
    public bool ShowAction { get; set; } = true;

    public IEnumerable<RouteType> RouteTypes { get; set; }
        = Enumerable.Empty<RouteType>();
}