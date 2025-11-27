using System.ComponentModel.DataAnnotations;

namespace Video_Shop_Rental.Models
{
    public class RentalDetail
    {
        public int Id { get; set; }
        [Required] public int RentalHeaderId { get; set; }
        public RentalHeader RentalHeader { get; set; }
        [Required] public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int DaysRented { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool IsReturned { get; set; } = false;
        public decimal Cost { get; set; }
    }
}
