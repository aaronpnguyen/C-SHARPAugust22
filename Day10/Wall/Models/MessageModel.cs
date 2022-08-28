#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wall.Models;

public class Message
{
    [Key]
    public int MessageId {get;set;}

    [Required]
    public string MessageContent {get;set;}

    public int UserId {get;set;}

    public User? Creator {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    public List<Comment> Comments {get;set;} = new List<Comment>();
}