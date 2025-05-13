using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

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
    public string Phone { get; set; }
    
    
    
    //Collection navigation property
    public virtual ICollection<Booking> Bookings { get; set; }
    public virtual ICollection<Payment> Payments { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
}