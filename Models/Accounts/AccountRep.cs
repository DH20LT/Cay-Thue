namespace CayThue.Models.Accounts;

public class AccountRep : IAccountRep
{
    private readonly CayThueDbContext _cayThueDbContext;
    
    public AccountRep(CayThueDbContext cayThueDbContext)
    {
        _cayThueDbContext = cayThueDbContext;
    }
    
    public IEnumerable<Account> GetAllAccounts()
    {
        return _cayThueDbContext.Accounts;
    }

    public Account GetAccountById(string id)
    {
        Account account = _cayThueDbContext.Accounts.Find(id) ?? throw new InvalidOperationException
        {
            HelpLink = null,
            HResult = 0,
            Source = null
        };
        return account;
    }

    public IEnumerable<Account> GetAccountByGameId(string gameId)
    {
        return _cayThueDbContext.Accounts;
    }

    public IEnumerable<Account> GetAccountByPrice(float startPrice, float endPrice)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Account> GetAccountByDescription(string description)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Account> GetAccountByIsVerify(bool isVerify)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Account> GetAccountByCanChangeInfo(bool canChangeInfo)
    {
        throw new NotImplementedException();
    }

    public void AddAccount(Account account)
    {
        _cayThueDbContext.Accounts.Add(account);
        _cayThueDbContext.SaveChanges();
    }
}