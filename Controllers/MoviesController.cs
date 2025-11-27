using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Video_Shop_Rental.Models;
using static Video_Shop_Rental.Data.ApplicationDbContext;

namespace Video_Shop_Rental.Controllers
{
    public class MoviesController : Controller
    {
        private readonly VideoShopContext _context;
        public MoviesController(VideoShopContext context) => _context = context;
        public async Task<IActionResult> Index(string search) => View(await _context.Movies.Where(m => string.IsNullOrEmpty(search) || m.Genre.Contains(search)).ToListAsync());
        public IActionResult Create() => View();
        [HttpPost] public async Task<IActionResult> Create(Movie movie) { if (ModelState.IsValid) { _context.Add(movie); await _context.SaveChangesAsync(); return RedirectToAction(nameof(Index)); } return View(movie); }
       
    }

}

