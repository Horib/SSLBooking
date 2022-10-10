using Microsoft.AspNetCore.Mvc;
using SSLBooking.Models;

namespace SSLBooking.Controllers;

public class RoutesController : Controller
{
    private ISSLBookingRepository _repository;

    public RoutesController(ISSLBookingRepository repo)
    {
        _repository = repo;
    }

    public IActionResult Index()
    {
        return View(_repository.Routes);
    }
}