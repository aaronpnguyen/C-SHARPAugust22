#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace EntityFrameworkLecture.Models;
public class Post
{
    [Key]
    public int PostId {get;set;}

    [Required]
    [MinLength(2, ErrorMessage = "must be at least 2 characters")]
    [MaxLength(45, ErrorMessage = "must be shorter than 45 characters")]
    public string Topic {get;set;}

    [Required]
    [MinLength(2, ErrorMessage = "must be at least 2 characters")]
    public string Body {get;set;}

    [Display(Name = "Image URL")]
    public string? ImgUrl {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
}