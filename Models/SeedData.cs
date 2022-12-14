using Microsoft.EntityFrameworkCore;

namespace SSLBooking.Models;

public static class SeedData
{
    public static void SeedDatabase(DataContext context)
    {
        context.Database.Migrate();
        if (context.Routes.Count() == 0
            && context.NewsItems.Count() == 0
            && context.RouteTypes.Count() == 0)
        {
            RouteType routeType1 = new RouteType() { Name = "ferry" };
            RouteType routeType2 = new RouteType() { Name = "bus" };

            context.Routes.AddRange(
                new Route
                {
                    Name = "Tórshavn - Tvøroyri",
                    RouteNumber = 7,
                    Description = "Route between Tórshavn and Little Denmark",
                    Location1 = "Tórshavn",
                    Location2 = "Tvøroyri",
                    Type = routeType1,
                    Price = 750.00m
                },
                new Route
                {
                    Name = "Gamlarætt - Sandur",
                    RouteNumber = 60,
                    Description = "Route between Streymoy and Sandoy",
                    Location1 = "Gamlarætt",
                    Location2 = "Sandur",
                    Type = routeType1,
                    Price = 580.00m
                },
                new Route
                {
                    Name = "Tórshavn - Nólsoy",
                    RouteNumber = 90,
                    Description = "Route between Streymoy and Nólsoy",
                    Location1 = "Tórshavn",
                    Location2 = "Nólsoy",
                    Type = routeType1,
                    Price = 120.00m
                },
                new Route
                {
                    Name = "Tórshavn - Klaksvík",
                    RouteNumber = 400,
                    Description = "Bus route between Tórshavn and Klaksvík",
                    Location1 = "Tórshavn",
                    Location2 = "Klaksvík",
                    Type = routeType2,
                    Price = 100.00m
                }
            );

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
                    Message =
                        "Í komandi viku (vika 41) verður heystferia, og tað merkir, at okkara bussar ið koyra til og frá ymsum skúlum, at teir grønu túrarnir í ferðaætlanini verða ikki koyrdir í viku 41. Koyrt verður sum vant aftur í viku 42.",
                    Type = "sky"
                },
                new NewsItem()
                {
                    Title = "Eyka ruta til Súðuroyar",
                    Message =
                        "Næstu 5 vikurnar Siglur Smyril tveir eykatúrar um dagin",
                    Type = "emerald"
                }
            );

            context.SaveChanges();
        }
    }
}