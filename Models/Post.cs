// Don't forget to disable the warnings!
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Register.Models;
public class Post
{    
    [Key]
    public int PostId { get; set; }
    // Each property in a model gets its own set of DataAnnotations
    // Each annotation applies only to the property that is directly below it
    [Required]   
    // We can stack annotations to apply multiple requirements to one property
    // In this case, a Username is required but must also be at least 3 characters long 
    [MinLength(3)]    
    public string Content { get; set; }     
    // Notice how we must use [Required] again here to apply to the next property
    public int? UserId {get;set;}
    public User? Creator {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;        
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
    
   
}
