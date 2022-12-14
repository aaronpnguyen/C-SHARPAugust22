#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wall.Models;

public class User
{
    [Key]
    public int UserId {get;set;}

    [Required(ErrorMessage = "is requried!")]
    [MinLength(2, ErrorMessage = "must contain more than 2 characters!")]
    [Display(Name = "First Name")]
    public string FirstName {get;set;}

    [Required(ErrorMessage = "is requried!")]
    [MinLength(2, ErrorMessage = "must contain more than 2 characters!")]
    [Display(Name = "Last Name")]
    public string LastName {get;set;}
    
    [Required(ErrorMessage = "is requried!")]
    [EmailAddress]
    public string Email {get;set;}
    
    [Required(ErrorMessage = "is required!")]
    [MinLength(8, ErrorMessage = "must contain more than 8 characters!")]
    [DataType(DataType.Password)]
    public string Password {get;set;}

    [NotMapped]
    [Compare("Password", ErrorMessage = "does not match password!")]
    [DataType(DataType.Password)]
    public string Confirm {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;


    [InverseProperty("UserTwo")]
    public List<Friend> Friends {get;set;} = new List<Friend>();
    
    public List<Comment> Comments {get;set;} = new List<Comment>();


    public string Full()
    {
        return $"{FirstName} {LastName}";
    }
}