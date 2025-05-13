using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.OrdazB.Models;

public class Property
{
    public int PropertyId { get; set; }
    
    [Required]
    public string PropertyName { get; set; }
    
    public string PropertyDescription { get; set; }
    
    [Required]
    public string PropertyLocation { get; set; }
    
    [Required] 
    public int Price { get; set; }
    
    //Collection navigation property
    public virtual ICollection<Review> Reviews { get; set; }
    public virtual ICollection<Booking> Bookings { get; set; }
}