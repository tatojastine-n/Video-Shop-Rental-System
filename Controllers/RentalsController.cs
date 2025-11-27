using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Video_Shop_Rental.Models;
using static Video_Shop_Rental.Data.ApplicationDbContext;

namespace Video_Shop_Rental.Controllers
{
    public class RentalsController : Controller
    {        
        private readonly VideoShopContext _context;
        public RentalsController(VideoShopContext context) => _context = context;

        public IActionResult Create() => View(new RentalViewModel { RentalDetails = new List<RentalDetailViewModel>() });

        [HttpPost]
        public async Task<IActionResult> Return(int headerId, List<int> detailIds)
        {
            var header = await _context.RentalHeaders.Include(h => h.RentalDetails).FirstOrDefaultAsync(h => h.Id == headerId);
            if (header == null) return NotFound();

            foreach (var detail in header.RentalDetails.Where(d => detailIds.Contains(d.Id)))
            {
                detail.IsReturned = true;
                detail.ReturnDate = DateTime.Now;
                var movie = await _context.Movies.FindAsync(detail.MovieId);
                movie.Stock++;  // Restock
                                // Optional: Late fee logic (e.g., if DateTime.Now > RentalDate.AddDays(detail.DaysRented), add fee)
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Index() => View(await _context.RentalHeaders.Include(h => h.Customer).Include(h => h.RentalDetails).ThenInclude(d => d.Movie).ToListAsync());
        

    }
}
