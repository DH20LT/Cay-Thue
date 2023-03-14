using CayThue.Models.Users;

namespace CayThue.Models.Accounts;

public class AccountRep : IAccountRep
{
    private readonly CayThueDbContext _cayThueDbContext;
    
    public AccountRep(CayThueDbContext cayThueDbContext)
    {
        _cayThueDbContext = cayThueDbContext;
    }

    public Account GetAccountById(Guid id)
    {
        Account account = _cayThueDbContext.Accounts.Find(id);
        return account;
    }

    public IEnumerable<Account> GetAllAccounts()
    {
        return _cayThueDbContext.Accounts;
    }

    public IEnumerable<Account> GetAccountsByUserId(string userId)
    {
        throw new NotImplementedException();
    }

    public Account GetAccountsById(string id)
    {
        Account account = _cayThueDbContext.Accounts.Find(id) ?? throw new InvalidOperationException
        {
            HelpLink = null,
            HResult = 0,
            Source = null
        };
        return account;
    }

    public IEnumerable<Account> GetAccountsByGameId(string gameId)
    {
        return _cayThueDbContext.Accounts;
    }

    public IEnumerable<Account> GetAccountsByPrice(float startPrice, float endPrice)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Account> GetAccountsByDescription(string description)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Account> GetAccountsByIsVerify(bool isVerify)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Account> GetAccountsByCanChangeInfo(bool canChangeInfo)
    {
        throw new NotImplementedException();
    }

    public User GetUserByAccountId(Guid id)
    {
        Account account = _cayThueDbContext.Accounts.Find(id);
        
        User user = _cayThueDbContext.Users.Find(account.UserId);
        
        return user;
    }

    public void AddAccount(Account account)
    {
        _cayThueDbContext.Accounts.Add(account);
        _cayThueDbContext.SaveChanges();
    }

    public void IncreaseViews(Guid id)
    {
        Account account = _cayThueDbContext.Accounts.Find(id);
        account.Views += 1;
        _cayThueDbContext.SaveChanges();
    }
}