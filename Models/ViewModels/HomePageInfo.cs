namespace SSLBooking.Models.ViewModels;

public class HomePageInfo
{
    public IEnumerable<Route> Routes { get; set; } = Enumerable.Empty<Route>();
    public IEnumerable<NewsItem> NewsItems { get; set; } = Enumerable.Empty<NewsItem>();
}