using CayThue.Models.Accounts;

namespace CayThue.Models.TradeHistory.ViewModels;

/// <summary>
/// View Model for GiaoDich, contains Trade and Account
/// </summary>
public class GiaoDichViewModel
{
    public Trade Trade { get; set; }
    
    public Account Account { get; set; }
}