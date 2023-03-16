using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Data;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.Controllers
{
    public class ClubController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ClubController(ApplicationDbContext context)
        {
            _context = context; 
        }

        //GET: All Views Index
        public IActionResult Index()
        {
            List<Club> clubs = _context.Clubs.ToList();
            return View(clubs);
        }

        //GET: All Views Details
        public IActionResult Detail(int id)
        {    
            /*Used Include bcz Address is async join table*/
            Club club = _context.Clubs.Include(a => a.Address).FirstOrDefault(e => e.Id == id);
            return View(club);
        }
    }
}
