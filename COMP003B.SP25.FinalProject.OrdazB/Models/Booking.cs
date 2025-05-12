namespace COMP003B.SP25.FinalProject.OrdazB.Models;

public class Booking
{
    public int BookingId { get; set; }
    
    public int UserId { get; set; }
    
    public int propertyId { get; set; }
    
    public DateTime BookingDates { get; set; }
    
    public int Guests { get; set; }
}