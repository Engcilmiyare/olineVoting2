using Microsoft.AspNetCore.Mvc;
using OnlineVotingSystem.Models;
using OnlineVotingSystem.Data;
using System.Linq;

namespace OnlineVotingSystem.Controllers
{
    public class ElectionController : Controller
    {
        private readonly OnlineVoteDbContext _context;

        public ElectionController(OnlineVoteDbContext context)
        {
            _context = context;
        }

        // GET: Election
        public IActionResult Index()
        {
            var election = _context.Elections.ToList();
            return View(election);
        }

        // GET: Election/Create
        public IActionResult Add()
        {
            return View();
        }

        // POST: Election/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Election election)
        {
            if (ModelState.IsValid)
            {
                _context.Elections.Add(election);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(election);
        }

        // Additional actions for Edit, Details, and Delete can be implemented similarly.
    }
}
