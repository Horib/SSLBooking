using Microsoft.EntityFrameworkCore;

namespace SSLBooking.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public DbSet<Route> Routes => Set<Route>();
    public DbSet<RouteType> RouteTypes => Set<RouteType>();
    public DbSet<NewsItem> NewsItems => Set<NewsItem>();
}