// Don't forget to disable the warnings!
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Register.Models;
public class User
{    
    [Key]
    public int UserId { get; set; }
    // Each property in a model gets its own set of DataAnnotations
    // Each annotation applies only to the property that is directly below it
    [Required]   
    // We can stack annotations to apply multiple requirements to one property
    // In this case, a Username is required but must also be at least 3 characters long 
    [MinLength(3)]    
    public string Username { get; set; }     
    // Notice how we must use [Required] again here to apply to the next property
    [Required]   
    // This will apply a standard Email format regex to this property 
    [EmailAddress]    
    public string Email { get; set; }     
    
    [Required]    
    // You will see what the [DataType] annotation does when we get over to making our form
    [DataType(DataType.Password)]    

    public DateTime CreatedAt {get;set;} = DateTime.Now;        
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
    public string Password { get; set; } 
    [NotMapped]
    // There is also a built-in attribute for comparing two fields we can use!
    [Compare("Password")]
    public string PasswordConfirm { get; set; }
    List<Post>? Post {get;set;}
    List<Like>? Likes {get;set;}
}
