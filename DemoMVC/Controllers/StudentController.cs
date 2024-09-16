using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
{
    public IActionResult Demo()
    {
        return View();
    }
[HttpPost]
        public IActionResult Demo(string fullName)
        {
        return View();
    }
}
}
