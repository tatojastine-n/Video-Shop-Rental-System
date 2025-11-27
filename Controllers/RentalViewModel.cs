using Video_Shop_Rental.Models;

namespace Video_Shop_Rental.Controllers
{
    public class RentalViewModel
    {
        public int CustomerId { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Movie> Movies { get; set; }
        public List<RentalDetailViewModel> RentalDetails { get; set; }
    }
    public class RentalDetailViewModel { public int MovieId { get; set; } public int DaysRented { get; set; } }
}
