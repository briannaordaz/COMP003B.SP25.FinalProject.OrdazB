using COMP003B.SP25.FinalProject.OrdazB.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.SP25.FinalProject.OrdazB.Data;

public class WebDevAcademyContext : DbContext
{
    public WebDevAcademyContext(DbContextOptions<WebDevAcademyContext> options) : base(options)
    {
        
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Property> Properties { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Review> Reviews { get; set; }
}