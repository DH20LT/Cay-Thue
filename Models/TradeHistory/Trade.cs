using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CayThue.Models.TradeHistory;

public class Trade
{
    [Key]
    [Column("ID")]
    public Guid? Id { get; set; }
    
    public Guid? AccountId { get; set; }
    
    public float? Amount { get; set; }

    public Guid? SellerId { get; set; }

    public Guid? BuyerId { get; set; }
    
    public string? PaymentType { get; set; }
    
    public DateTime? CreatedDate { get; set; }
    
    public DateTime? PaymentDate { get; set; }
    
    public DateTime? CompletionDate { get; set; }

    public int? PaymentStatus { get; set; }
    
    public DateTime? CancellationDate { get; set; }

    public int? CancellationReason { get; set; }

    public int? Status { get; set; }

    public string? Location { get; set; }
    
    public string? Mac { get; set; }

    public int? RateBySeller { get; set; }

    public int? RateByBuyer { get; set; }

    public string? CommentBySeller { get; set; }

    public string? CommentByBuyer { get; set; }
}