using BettingApp.Data;
using BettingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Controllers
{
    public class MatchController : Controller
    {
        private readonly EntriesDbContext _db;

        public MatchController(EntriesDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable <Match> objMatchList = _db.Matches;

            return View(objMatchList);
        }
    }
}
