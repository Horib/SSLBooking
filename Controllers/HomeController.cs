using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SSLBooking.Models;

namespace SSLBooking.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
