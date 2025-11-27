using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Video_Shop_Rental.Models;

namespace Video_Shop_Rental.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public class VideoShopContext : DbContext
        {
            public VideoShopContext(DbContextOptions<VideoShopContext> options) : base(options) { }
            public DbSet<Movie> Movies { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<RentalHeader> RentalHeaders { get; set; }
            public DbSet<RentalDetail> RentalDetails { get; set; }
        }
    }
}
