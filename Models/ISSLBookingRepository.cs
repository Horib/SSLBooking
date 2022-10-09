namespace SSLBooking.Models;

public interface ISSLBookingRepository
{
    IQueryable<Route> Routes { get; }
    IQueryable<NewsItem> NewsItems { get; }
}