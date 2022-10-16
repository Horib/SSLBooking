using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SSLBooking.Models;
using SSLBooking.Models.ViewModels;
using Route = SSLBooking.Models.Route;

namespace SSLBooking.Controllers;

public class RoutesController : Controller
{
    private DataContext _context;

    private IEnumerable<RouteType> RouteTypes => _context.RouteTypes;

    public RoutesController(DataContext data)
    {
        _context = data;
    }

    // public IActionResult Index()
    // {
    //     return View(new RoutesListViewModel(
    //         Routes = _context.Routes,
    //         RouteTypes = _context.RouteTypes
    //     ));
    // }
    
    public IActionResult Index() => View(new RoutesListViewModel
    {
        Routes = _context.Routes,
        RouteTypes = _context.RouteTypes
    });

    public async Task<IActionResult> Details(long id)
    {
        Route? r = await _context.Routes.FirstOrDefaultAsync(r => r.RouteId == id) ?? new Route();
        RouteViewModel model = ViewModelFactory.Details(r);
        return View("RouteViewer", model);
    }

    public IActionResult Create()
    {
        return View("RouteCreater",
            ViewModelFactory.Create(new Route(), RouteTypes));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromForm] Route route)
    {
        if (ModelState.IsValid)
        {
            route.Type = default;
            route.RouteId = default;
            _context.Routes.Add(route);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View("RouteCreater", ViewModelFactory.Create(route, RouteTypes));
    }

    public async Task<IActionResult> Edit(long id)
    {
        Route? r = await _context.Routes.FindAsync(id);
        if (r != null)
        {
            RouteViewModel model = ViewModelFactory.Edit(r, RouteTypes);
            return View("RouteEditor", model);
        }

        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Edit([FromForm] Route route)
    {
        if (ModelState.IsValid)
        {
            route.Type = default;
            _context.Routes.Update(route);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View("RouteEditor", ViewModelFactory.Edit(route, RouteTypes));
    }

    public async Task<IActionResult> Delete(long id)
    {
        Route? route = await _context.Routes.FindAsync(id);
        if (route != null)
        {
            RouteViewModel model = ViewModelFactory.Delete(route, RouteTypes);
            return View("RouteViewer", model);
        }

        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Delete(Route route)
    {
        _context.Routes.Remove(route);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}