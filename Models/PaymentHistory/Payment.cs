using System.ComponentModel.DataAnnotations;

namespace CayThue.Models.PaymentHistory;

public class Payment
{
    [Key]
    public Guid? Id { get; set; }
    
    public Guid? UserId { get; set; }
    
    public float? Amount { get; set; }
    
    public string? PaymentType { get; set; }
    
    public DateTime? PaymentDate { get; set; }
    
    public string? Location { get; set; }
    
    public string? Mac { get; set; }
    
}