using System.ComponentModel.DataAnnotations;

namespace CSharpBank.Models;

public class Account
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    [Required]
    public required Customer Customer { get; set; }
    public AccountType AccountType { get; set; }
    public decimal Balance { get; set; }
    public required ICollection<Transaction> Transactions { get; set; }  // account can have many transactions

}

public enum AccountType
{
    FLEX,
    DELUXE,
    VIVA,
    PIGGY,
    SUPA
}
