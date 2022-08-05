using System.ComponentModel.DataAnnotations;
namespace Users.Models;
#pragma warning disable CS8618

public class User
{
    [Required]
    [MinLength(3)]
    public string Username {get;set;}

    [Required]
    [MinLength(3)]
    public string Email {get;set;}

    [Required]
    [MinLength(3)]
    public string Password {get;set;}
}
