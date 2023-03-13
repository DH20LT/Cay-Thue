using System.ComponentModel.DataAnnotations.Schema;

namespace CayThue.Models.Library;

[Table("Library.Rank")]
public class Rank
{
    public Guid? Id { get; set; }
    
    public string? Name { get; set; }
}