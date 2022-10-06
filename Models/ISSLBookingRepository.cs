namespace SSLBooking.Models;

public interface ISSLBookingRepository
{
    IQueryable<Route> Routes { get; }
}