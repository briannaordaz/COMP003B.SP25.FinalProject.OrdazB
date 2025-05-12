namespace COMP003B.SP25.FinalProject.OrdazB.Models;

public class Booking
{
    public int BookingId { get; set; }
    
    public int UserId { get; set; }
    
    public int propertyId { get; set; }
    
    public DateTime BookingDates { get; set; }
    
    public int Guests { get; set; }
    
    //Nullable navigation property
    public virtual Property? Property { get; set; }
    public virtual User? User { get; set; }
    public virtual Payment? Payment { get; set; }
}