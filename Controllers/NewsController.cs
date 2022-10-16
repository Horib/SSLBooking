using Microsoft.AspNetCore.Mvc;
using SSLBooking.Models;

namespace SSLBooking.Controllers;

public class NewsController : Controller
{
    private readonly DataContext _context;

    public NewsController(DataContext data)
    {
        _context = data;
    }

    public IActionResult Index()
    {
        return View(_context.NewsItems);
    }
}