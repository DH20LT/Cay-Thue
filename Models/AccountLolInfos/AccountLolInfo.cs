using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CayThue.Models.AccountLolInfos;

public class AccountLolInfo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }
    public Guid? AccountId { get; set; }
    public string? AvailableRiotPoints { get; set; }
    public string? Level { get; set; }
    public string? ProfileBanner { get; set; }
    public string? Honor { get; set; }
    public string? Server { get; set; }
    public string? Champions { get; set; }
    public string? Skins { get; set; }
    public string? Chroma { get; set; }
    public string? WardSkins { get; set; }
    public string? SumIcons { get; set; }
    public string? Emotes { get; set; }
    public string? FlexDivision { get; set; }
}