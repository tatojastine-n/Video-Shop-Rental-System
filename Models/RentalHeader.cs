using System.ComponentModel.DataAnnotations;

namespace Video_Shop_Rental.Models
{
    public class RentalHeader
    {
        public int Id { get; set; }
        public DateTime RentalDate { get; set; } = DateTime.Now;
        [Required] public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public decimal TotalCost { get; set; }
        public ICollection<RentalDetail> RentalDetails { get; set; } = new List<RentalDetail>();
    }
}
