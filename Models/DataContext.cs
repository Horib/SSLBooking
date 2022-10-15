using Microsoft.EntityFrameworkCore;

namespace SSLBooking.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options){}

    public DbSet<Route> Routes => Set<Route>();
    public DbSet<NewsItem> NewsItems => Set<NewsItem>();
}