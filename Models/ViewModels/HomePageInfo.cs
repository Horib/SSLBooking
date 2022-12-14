namespace SSLBooking.Models.ViewModels;

public class HomePageInfo
{
    public IEnumerable<Route> Routes { get; set; } = Enumerable.Empty<Route>();
    public IEnumerable<RouteType> RouteTypes { get; set; } = Enumerable.Empty<RouteType>();

    public IEnumerable<NewsItem> NewsItems { get; set; } = Enumerable.Empty<NewsItem>();
}