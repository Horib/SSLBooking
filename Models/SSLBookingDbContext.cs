using Microsoft.EntityFrameworkCore;

namespace SSLBooking.Models;

public class SSLBookingDbContext : DbContext
{
    public SSLBookingDbContext(DbContextOptions<SSLBookingDbContext> options)
        : base(options){}

    public DbSet<Route> Routes => Set<Route>();
}