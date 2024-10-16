using DEPI_Projectt.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

namespace DEPI_Projectt.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<BusinessOwner> Owners { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Follow> Follows { get; set; }
        
        public DbSet<Report> Reports { get; set; }
        public DbSet<Ban> Bans { get; set; }
        
        
        public DbSet<ShippingDetails> ShippingDetails { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

}
