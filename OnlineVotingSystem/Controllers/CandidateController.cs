using Microsoft.AspNetCore.Mvc;
using OnlineVotingSystem.Data;
using OnlineVotingSystem.Models;

namespace OnlineVotingSystem.Controllers
{
    public class CandidateController : Controller
    {
        private readonly OnlineVoteDbContext _context;

        public CandidateController(OnlineVoteDbContext context)
        {
            _context = context;
        }
        // GET: Candidate
        public IActionResult Index()
        {

            var candidates =_context.Candidates.ToList();
            return View(candidates);
        }


        // GET: Candidate/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Candidate/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                _context.Candidates.Add(candidate);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(candidate);
        }
    }
}
