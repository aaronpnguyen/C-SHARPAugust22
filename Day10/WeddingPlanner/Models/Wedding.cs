#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models;

public class Wedding
{
    [Key]
    public int WeddingId {get;set;}

    [Required(ErrorMessage = "is requried")]
    [Display(Name = "Wedder One")]
    public string PersonOne {get;set;}

    [Required(ErrorMessage = "is requried")]
    [Display(Name = "Wedder Two")]
    public string PersonTwo {get;set;}
    
    [Required(ErrorMessage = "is requried")]
    [FutureDate]
    public DateTime Date {get;set;}
    
    [Required(ErrorMessage = "is required")]
    public string Address {get;set;}

    public int UserId {get;set;}
    
    public User? Creator {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    public List<Connection> Connections {get;set;} = new List<Connection>();

    public string Names()
    {
        return $"{PersonOne} & {PersonTwo}";
    }
}