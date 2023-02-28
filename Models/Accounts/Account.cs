﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CayThue.Models.Accounts;

public class Account
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
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