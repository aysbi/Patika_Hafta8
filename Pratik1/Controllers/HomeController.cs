using Microsoft.AspNetCore.Mvc;

namespace Pratik1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
            { return View(); }
    }
}
