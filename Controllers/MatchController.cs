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
        // GET
        public IActionResult Add()
        {
            return View();
        }
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Match obj)
        {
            if (ModelState.IsValid)
            {
                obj.Id = DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + Methods.RandomString(10);
                _db.Matches.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        
    }
}
