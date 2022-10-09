using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SSLBooking.Models;
using SSLBooking.Models.ViewModels;
using Route = SSLBooking.Models.Route;

namespace SSLBooking.Controllers;

public class HomeController : Controller
{
    private ISSLBookingRepository _repository;

    public HomeController(ISSLBookingRepository repo)
    {
        _repository = repo;
    }

    // public IActionResult Index()
    // {
    //     return View(_repository.Routes);
    // }
    public IActionResult Index() => View(new HomePageInfo
    {
        Routes = _repository.Routes,
        NewsItems = _repository.NewsItems
    });

    public async Task<IActionResult> Details(long id)
    {
        Route? r = await _repository.Routes.FirstOrDefaultAsync(r => r.RouteId == id) ?? new Route();
        RouteViewModel model = ViewModelFactory.Details(r);
        return View("RouteEditor", model);
    }
}