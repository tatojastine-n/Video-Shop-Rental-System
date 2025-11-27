using System.ComponentModel.DataAnnotations;

namespace Video_Shop_Rental.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }
        [EmailAddress] public string Email { get; set; }
        public string Phone { get; set; }
    }
}
