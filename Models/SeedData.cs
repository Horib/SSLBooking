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
                    Type = "sea",
                    Price = 750.00m
                },
                new Route
                {
                    Name = "Gamlarætt - Sandur",
                    RouteNumber = 60,
                    Description = "Route between Streymoy and Sandoy",
                    Location1 = "Gamlarætt",
                    Location2 = "Sandur",
                    Type = "sea",
                    Price = 580.00m
                },
                new Route
                {
                    Name = "Tórshavn - Nólsoy",
                    RouteNumber = 60,
                    Description = "Route between Streymoy and Nólsoy",
                    Location1 = "Tórshavn",
                    Location2 = "Nólsoy",
                    Type = "sea",
                    Price = 120.00m
                },
                new Route
                {
                    Name = "Tórshavn - Klaksvík",
                    RouteNumber = 400,
                    Description = "Bus route between Tórshavn and Klaksvík",
                    Location1 = "Tórshavn",
                    Location2 = "Klaksvík",
                    Type = "land",
                    Price = 100.00m
                }
            );

            if (!context.NewsItems.Any())
            {
                context.NewsItems.AddRange(
                    new NewsItem()
                    {
                        Title = "9. okt: Kunning viðv. leið 56",
                        Message = "Eftir ætlan verður siglt smbr. ferðaætlan á leið 56 tað ið eftir er av degnum.",
                        Message2 = "Galdandi fyri: 56 Klaksvík - Syðradalur "
                    },
                    new NewsItem()
                    {
                        Title = "Broytingar hjá Bygdaleiðum í viku 41",
                        Message = "Í komandi viku (vika 41) verður heystferia, og tað merkir, at okkara bussar ið koyra til og frá ymsum skúlum, at teir grønu túrarnir í ferðaætlanini verða ikki koyrdir í viku 41. Koyrt verður sum vant aftur í viku 42."
                    }
                );
            }

            context.SaveChanges();
        }
    }
}