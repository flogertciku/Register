// Don't forget to disable the warnings!
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Register.Models;
public class Like
{    
    [Key]
    public int LikeId { get; set; }
     
        
    // Notice how we must use [Required] again here to apply to the next property
    public int? UserId {get;set;}
    public User? UserLike {get;set;}
    public int? PostId {get;set;}
    public Post? PostLike {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;        
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
    
   
}
