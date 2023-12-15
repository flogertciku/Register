// Don't forget to disable the warnings!
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Register.Models;
public class SignIn
{    
 
    // Each property in a model gets its own set of DataAnnotations
    // Each annotation applies only to the property that is directly below it
       
    // Notice how we must use [Required] again here to apply to the next property
    [Required]   
    // This will apply a standard Email format regex to this property 
    [EmailAddress]    
    public string SEmail { get; set; }     
    
    [Required]    
    // You will see what the [DataType] annotation does when we get over to making our form
    [DataType(DataType.Password)]    
    public string SPassword { get; set; } 
    
}
