namespace CSharpBank.Models;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public ICollection<Account> Accounts { get; set; }

    public Customer()
    {
        Accounts = new List<Account>();
    }
}
