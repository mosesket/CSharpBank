using System.ComponentModel.DataAnnotations;

namespace CSharpBank.Models;

public class Transaction
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    [Required]
    public required Account Account { get; set; }  // Foreign key to Account
    public decimal Amount { get; set; }
    [Required]
    public required string TransactionType { get; set; }
    public DateTime CreatedAt { get; set; }
}
