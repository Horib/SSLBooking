using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SSLBooking.Models;
using SSLBooking.Models.ViewModels;
using Route = SSLBooking.Models.Route;


namespace SSLBooking.Controllers;

public class RoutesController : Controller
{
    private DataContext context;

    // public RoutesController(ISSLBookingRepository repo)
    // {
    //     _repository = repo;
    // }

    private IEnumerable<Route> Routes => context.Routes;
    private IEnumerable<NewsItem> NewsItems => context.NewsItems;

    private RoutesController(DataContext data)
    {
        context = data;
    }

    public IActionResult Index()
    {
        return View(context.Routes);
    }

    public async Task<IActionResult> Details(long id)
    {
        Route? r = await context.Routes.FirstOrDefaultAsync(r => r.RouteId == id) ?? new Route();
        RouteViewModel model = ViewModelFactory.Details(r);
        return View("RouteView", model);
    }

    public IActionResult Create()
    {
        return View("RouteCreate",
            ViewModelFactory.Create(new Route()));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromForm] Route route)
    {
        if (ModelState.IsValid)
        {
            route.RouteId = default;
            context.Routes.Add(route);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View("RouteView", ViewModelFactory.Create(route));
    }
}