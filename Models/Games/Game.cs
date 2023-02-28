using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CayThue.Models.Games;

public class Game
{
    [Key]
    [Column("ID")]
    public Guid? Id { get; set; }
    
    public string? Code { get; set; }
}