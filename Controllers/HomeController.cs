using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SSLBooking.Models;
using SSLBooking.Models.ViewModels;
using Route = SSLBooking.Models.Route;

namespace SSLBooking.Controllers;

public class HomeController : Controller
{
    private readonly DataContext context;

    private IEnumerable<NewsItem> NewsItems => context.NewsItems;


    public HomeController(DataContext data)
    {
        context = data;
    }

    public IActionResult Index() => View(new HomePageInfo
    {
        Routes = context.Routes,
        RouteTypes = context.RouteTypes,
        NewsItems = context.NewsItems
    });

    public async Task<IActionResult> Details(long id)
    {
        Route? r = await context.Routes.FirstOrDefaultAsync(r => r.RouteId == id) ?? new Route();
        RouteViewModel model = ViewModelFactory.Details(r);
        return View("_RouteView", model);
    }
}