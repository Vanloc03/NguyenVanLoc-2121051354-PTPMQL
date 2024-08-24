using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers;
public class NguyenVanLocController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}