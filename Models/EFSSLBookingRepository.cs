namespace SSLBooking.Models;

public class EFSSLBookingRepository : ISSLBookingRepository
{
    private SSLBookingDbContext _context;

    public EFSSLBookingRepository(SSLBookingDbContext ctx)
    {
        _context = ctx;
    }

    public IQueryable<Route> Routes => _context.Routes;
    public IQueryable<NewsItem> NewsItems => _context.NewsItems;
}