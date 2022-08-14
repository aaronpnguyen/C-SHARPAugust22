#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProdCats.Models;

public class Product
{
    [Key]
    public int ProductId {get;set;}

    [Required(ErrorMessage = "is required")]
    [Display(Name = "Name")]
    public string ProductName {get;set;}
    
    [Required(ErrorMessage = "is required")]
    public string Description {get;set;}
    
    [Required(ErrorMessage = "is required")]
    public double Price {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
    
    public List<Connection> Connections {get;set;}= new List<Connection>();
}