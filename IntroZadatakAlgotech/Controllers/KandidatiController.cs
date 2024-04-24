using IntroZadatakAlgotech.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroZadatakAlgotech.Controllers
{
    public class KandidatiController : Controller
    {

        private readonly AppDbContext _context;

        public KandidatiController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var sviKandidati = await _context.Kandidati.ToListAsync();
            return View();
        }
    }
}
