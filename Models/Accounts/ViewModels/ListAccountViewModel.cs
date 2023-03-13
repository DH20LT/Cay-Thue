namespace CayThue.Models.Accounts.ViewModels;

// Get data from AccountLolInfo.cs
public class ListAccountViewModel
{
    public Guid AccountId { get; set; } // Id give to view AccountDetail
    public string? UserName { get; set; } //tên của người dùng.
    public float? Price { get; set; }
    public string? AvailableRiotPoints { get; set; }
    public string? Server { get; set; }
    public string? Level { get; set; }
    public string? AvailableBlueEssence { get; set; }
    public string? RankFlex { get; set; }
    public string? RankSoloDuo { get; set; }
    public string? Champions { get; set; }
    public string? Skins { get; set; }
    public string? Chromas { get; set; }
    public string? WardSkins { get; set; }
    public string? SumIcons { get; set; }
    public string? Emotes { get; set; }
    public int? Prestige { get; set; }
    public string? OfflineTime { get; set; }
    public string? WinRate { get; set; }
}