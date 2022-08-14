#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProdCats.Models;

public class Connection
{
    [Key]
    public int ConnectionId {get;set;}
    
    public int ProductId {get;set;}
    public Product? Product {get;set;}

    public int CategoryId {get;set;}
    public Category? Category {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
}