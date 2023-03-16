using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Data;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.Controllers
{
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RaceController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET: All Views Index
        public IActionResult Index()
        {
            List<Race> races = _context.Races.ToList();
            return View(races);
        }

        //GET: All Views Details
        public IActionResult Detail(int id)
        {
            /*Used Include bcz Address is async join table*/
            Race race = _context.Races.Include(a => a.Address).FirstOrDefault(e => e.Id == id);
            return View(race);
        }
    }
}
