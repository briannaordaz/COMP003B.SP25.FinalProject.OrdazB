using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP003B.SP25.FinalProject.OrdazB.Models;

public class Review
{
    public int ReviewId { get; set; }
    
    [ForeignKey("UserId")]
    public int UserId { get; set; }
    
    [ForeignKey("PropertyId")]
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