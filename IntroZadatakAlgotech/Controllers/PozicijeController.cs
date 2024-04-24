using IntroZadatakAlgotech.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroZadatakAlgotech.Controllers
{
    public class PozicijeController : Controller
    {

        private readonly AppDbContext _context;

        public PozicijeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var svePozicije = await _context.Pozicije.ToListAsync();
            return View();
        }
    }
}
