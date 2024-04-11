using CSharpBank.Data;

namespace CSharpBank.Services;

public class AccountService
{
    private readonly AppDbContext _dbContext;

    public AccountService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

}