using Microsoft.AspNetCore.Mvc;
using SSLBooking.Models;

namespace SSLBooking.Controllers;

public class NewsController : Controller
{
    private ISSLBookingRepository _repository;

    public NewsController(ISSLBookingRepository repo)
    {
        _repository = repo;
    }

    public IActionResult Index()
    {
        return View(_repository.NewsItems);
    }
}