using Microsoft.AspNetCore.Mvc;

namespace Dairy.Controllers
{
    public class DairyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
