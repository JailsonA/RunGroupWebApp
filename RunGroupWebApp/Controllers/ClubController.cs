using Microsoft.AspNetCore.Mvc;

namespace RunGroupWebApp.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
