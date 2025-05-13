using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP003B.SP25.FinalProject.OrdazB.Models;

public class Booking
{
    public int BookingId { get; set; }
    
    [ForeignKey("UserId")]
    public int UserId { get; set; }
    
    [ForeignKey("PropertyId")]
    public int propertyId { get; set; }
    
    [Required]
    public DateTime CheckIn { get; set; }
    
    [Required]
    public DateTime CheckOut { get; set; }
    
    [Required]
    public int Guests { get; set; }
    
    
    //Nullable navigation property
    public virtual Property? Property { get; set; }
    public virtual User? User { get; set; }
    public virtual Payment? Payment { get; set; }
}