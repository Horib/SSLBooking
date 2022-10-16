namespace SSLBooking.Models.ViewModels;

public class RoutesListViewModel
{
    public IEnumerable<Route> Routes { get; set; } = Enumerable.Empty<Route>();
    public IEnumerable<RouteType> RouteTypes { get; set; } = Enumerable.Empty<RouteType>();
}