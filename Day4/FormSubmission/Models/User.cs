using System.ComponentModel.DataAnnotations;
namespace Users.Models;
#pragma warning disable CS8618

public class User
{
    [Required]
    [MinLength(4)]
    public string FirstName {get;set;}

    [Required]
    [MinLength(4)]
    public string LastName {get;set;}

    [Required]
    [Range(0, Int32.MaxValue)]
    public int Age {get;set;}

    [Required]
    [EmailAddress]
    public string Email {get;set;}

    [Required]
    [DataType(DataType.Password)]
    [MinLength(8)]
    public string Password {get;set;}
}
