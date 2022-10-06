using Microsoft.EntityFrameworkCore;

namespace SSLBooking.Models;

public static class SeedData
{
    public static void EnsurePopulated(IApplicationBuilder app)
    {
        SSLBookingDbContext context = app.ApplicationServices.CreateScope().ServiceProvider
            .GetRequiredService<SSLBookingDbContext>();

        if (context.Database.GetPendingMigrations().Any())
        {
            context.Database.Migrate();
        }

        if (!context.Routes.Any())
        {
            context.Routes.AddRange(
                new Route
                {
                    Name = "Tórshavn - Tvøroyri",
                    RouteNumber = 7,
                    Description = "Route between Tórshavn and Little Denmark",
                    Location1 = "Tórshavn",
                    Location2 = "Tvøroyri",
                    Price = 750.00m
                },
                new Route
                {
                    Name = "Gamlarætt - Sandur",
                    RouteNumber = 60,
                    Description = "Route between Streymoy and Sandoy",
                    Location1 = "Gamlarætt",
                    Location2 = "Sandur",
                    Price = 580.00m
                },
                new Route
                {
                    Name = "Tórshavn - Nólsoy",
                    RouteNumber = 60,
                    Description = "Route between Streymoy and Nólsoy",
                    Location1 = "Tórshavn",
                    Location2 = "Nólsoy",
                    Price = 120.00m
                }
            );

            context.SaveChanges();
        }
    }
}