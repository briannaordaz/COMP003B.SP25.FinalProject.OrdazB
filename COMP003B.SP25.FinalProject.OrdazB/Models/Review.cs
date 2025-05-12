namespace COMP003B.SP25.FinalProject.OrdazB.Models;

public class Review
{
    public int ReviewId { get; set; }
    
    public int UserId { get; set; }
    
    public int PropertyId { get; set; }
    
    public DateTime ReviewDates { get; set; }
    
    public string Comment { get; set; }
    
    //Nullable navigation property
    public virtual User? User { get; set; }
    public virtual Property? Property { get; set; }
}