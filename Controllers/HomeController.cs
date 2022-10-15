using Microsoft.AspNetCore.Mvc;
using SSLBooking.Models;
using SSLBooking.Models.ViewModels;

namespace SSLBooking.Controllers;

public class HomeController : Controller
{
    private readonly ISSLBookingRepository _repository;

    public HomeController(ISSLBookingRepository repo)
    {
        _repository = repo;
    }

    public IActionResult Index() => View(new HomePageInfo
    {
        Routes = _repository.Routes,
        NewsItems = _repository.NewsItems
    });
}