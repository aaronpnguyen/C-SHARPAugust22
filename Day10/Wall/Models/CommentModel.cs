#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wall.Models;

public class Comment
{
    [Key]
    public int CommentId {get;set;}

    public int UserId {get;set;}
    public User? User {get;set;}
    
    public int MessageId {get;set;}
    public Message? Message {get;set;}

    public string CommentContent {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
}