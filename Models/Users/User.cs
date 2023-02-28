using Microsoft.EntityFrameworkCore;

namespace CayThue.Models.Users;

[PrimaryKey(nameof(Id))]
public class User
{
    public Guid? Id { get; set; }
    
    public string? Username { get; set; }
    
    public string? Currency { get; set; }
    
    public DateTime? CreatedDate { get; set; }
    
    public int? Reputation { get; set; }
}