using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.OrdazB.Models;

public class Property
{
    public int PropertyId { get; set; }
    
    [Required]
    public string PropertyName { get; set; }
    
    public string PropertyDescription { get; set; }
    
    public string PropertyLocation { get; set; }
    
    public string PropertyAddress { get; set; }
    
    public int Price { get; set; }
}