using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.OrdazB.Models;

public class Payment
{
    [Required]
    public int PaymentId { get; set; }
    
    public int UserId { get; set; }
    
    [Required]
    public int BookingId { get; set; }
    
    [Required]
    public DateTime DateOfPayment { get; set; }
    
    [Required]
    public int PaymentAmount { get; set; }
    
    //Nullable navigation property
    public virtual User? User { get; set; }
    public virtual Booking? Booking { get; set; }
}