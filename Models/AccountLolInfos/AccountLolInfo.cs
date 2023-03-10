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
    
    public string? Honor { get; set; }
    
    public string? Server { get; set; }
    
    public string? Champions { get; set; }
    
    public string? Skins { get; set; }
    
    public string? Chroma { get; set; }
    
    public string? WardSkins { get; set; }
    
    public string? SumIcons { get; set; }
    
    public string? Emotes { get; set; }

    public string? RankFlex { get; set; }
    
    public string? RankSoloDuo { get; set; }
    
    public string? PrevSeasonSoloDuo  { get; set; }
    
    public string? PrevSeasonFlex { get; set; }
    
    public int? AvailableBlueEssence { get; set; }
    
    public string? FirstServerOfAccount { get; set; }
    
    public int? AccountCreatedAt { get; set; }
    
    public int? Prestige { get; set; }
    
    public DateTime? OffineTime { get; set; }
    
    public DateTime? DateUpdateAccount { get; set; }

    public string? toString()
    {
        return "AccountLolInfo: " + Id + " " + AccountId + " " + AvailableRiotPoints + " " + Level + " " + Honor + " " +
               Server + " " + Champions + " " + Skins + " " + Chroma + " " + WardSkins + " " + SumIcons + " " + Emotes +
               " " + RankFlex;
    }
}