using CSharpBank.Data;
using CSharpBank.Models;

namespace CSharpBank.Services;

public class CustomerService
{
    private readonly AppDbContext _dbContext;

    public CustomerService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Customer> GetAllCustomers()
    {
        return _dbContext.Customers.ToList();
    }
}