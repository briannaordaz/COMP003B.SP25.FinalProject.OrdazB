using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.OrdazB.Models;

public class User
{
    public int UserId { get; set; }
    
    [Required]
    public string FirstName { get; set; }
    
    [Required]
    public string LastName { get; set; }
    
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [Phone]
    public int Phone { get; set; }
    
    //Added New Property
    public DateTime BirthDate { get; set; }
    
    //Collection navigation property
    public virtual ICollection<Booking> Bookings { get; set; }
    public virtual ICollection<Payment> Payments { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
}