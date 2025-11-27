using System.ComponentModel.DataAnnotations;

namespace Video_Shop_Rental.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required] public string Title { get; set; }
        public string Genre { get; set; }
        public int Stock { get; set; }  // Available copies
        public decimal DailyRate { get; set; }
    }
}
