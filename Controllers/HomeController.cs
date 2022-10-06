using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SSLBooking.Models;

namespace SSLBooking.Controllers;

public class HomeController : Controller
{
    private ISSLBookingRepository _repository;

    public HomeController(ISSLBookingRepository repo)
    {
        _repository = repo;
    }
    public IActionResult Index()
    {
        return View(_repository.Routes);
    }
}
