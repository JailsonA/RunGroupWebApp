using Microsoft.AspNetCore.Mvc;

namespace RunGroupWebApp.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
