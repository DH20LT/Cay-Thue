namespace CayThue.Models.Accounts.ViewModels;

// Get data from AccountLolInfo.cs
public class DetailAccountViewModel
{
    public Guid AccountId { get; set; }
    public string? UserName { get; set; } //tên của người dùng.
    public float? Price { get; set; }
    public string? AvailableRiotPoints { get; set; }
    public string? Level { get; set; }
    public string? Honor { get; set; }
    public string? AvailableBlueEssence { get; set; }
    public string? PrevSeasonSoloDuo { get; set; }
    public string? PrevSeasonFlex { get; set; }
    public string? RankFlex { get; set; }
    public string? RankSoloDuo { get; set; }
    public string? FirstServerOfAccount { get; set; }
    public string? AccountCreatedAt { get; set; }
    public string? Champions { get; set; }
    public string? Skins { get; set; }
    public string? Chroma { get; set; }
    public string? WardSkins { get; set; }
    public string? SumIcons { get; set; }
    public string? Emotes { get; set; }
    public int? Prestige { get; set; }
    public string? OffineTime { get; set; }
    public string? DateUpdateAccount { get; set; }
    public string? Views { get; set; }
}