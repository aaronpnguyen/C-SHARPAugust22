#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProdCats.Models;

public class Category
{
    [Key]
    public int CategoryId {get;set;}

    [Required(ErrorMessage = "is required")]
    [Display(Name = "Name")]
    public string CategoryName {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    
    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    public List<Connection> Connections {get;set;} = new List<Connection>();
}