namespace CayThue.Models.Accounts.ViewModels;

public class CreateAccountViewModel
{
    public Guid Id { get; set; }
    
    public Guid? GameId { get; set; }
    
    public float? Price { get; set; }
    
    public string? Description { get; set; }
    
    public string? UserId { get; set; }
    
    public bool? IsVerify { get; set; }
    
    public bool? CanChangeInfo { get; set; }
    
    public bool? IsSold { get; set; }
    
    public DateTime? CreatedDate { get; set; }
}