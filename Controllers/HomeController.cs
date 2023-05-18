using Microsoft.AspNetCore.Mvc;

namespace tp4Bis.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
