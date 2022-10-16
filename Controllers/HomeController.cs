using Microsoft.AspNetCore.Mvc;
using SSLBooking.Models;
using SSLBooking.Models.ViewModels;

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
        NewsItems = context.NewsItems
    });
}