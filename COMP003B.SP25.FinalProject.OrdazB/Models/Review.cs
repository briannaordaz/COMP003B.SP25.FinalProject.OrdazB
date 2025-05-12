using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.OrdazB.Models;

public class Review
{
    public int ReviewId { get; set; }
    
    public int UserId { get; set; }
    
    [Required]
    public int PropertyId { get; set; }
    
    [Required]
    public DateTime ReviewDates { get; set; }
    
    [Required]
    public string Comment { get; set; }
    
    //Nullable navigation property
    public virtual User? User { get; set; }
    public virtual Property? Property { get; set; }
}