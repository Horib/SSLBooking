namespace SSLBooking.Models.ViewModels;

public class RouteViewModel
{
    public Route Route { get; set; } = new Route();
    public string Action { get; set; } = "Create";
}