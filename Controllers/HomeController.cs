using Microsoft.AspNetCore.Mvc;
using tp4Bis.Models;

namespace tp4Bis.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaPaises=Info.ListarPaises();
        return View();
    }
   public IActionResult DetallePais(string paisBuscado){
        ViewBag.Pais=Info.DetallePais(paisBuscado);
        return View();
   }
}
