namespace CayThue.Models.AccountLolInfos;

public class AccountLolInfoRep : IAccountLolInfoRep
{
    private readonly CayThueDbContext _cayThueDbContext;

    public AccountLolInfoRep(CayThueDbContext cayThueDbContext)
    {
        _cayThueDbContext = cayThueDbContext;
    }

    public AccountLolInfo GetAccountLolInfoById(string id)
    {
        return _cayThueDbContext.AccountLolInfos.Find(id);
    }

    public AccountLolInfo GetAccountLolInfoByAccountId(Guid accountId)
    {
        AccountLolInfo accountLolInfo = _cayThueDbContext.AccountLolInfos.FirstOrDefault(
            a => a.AccountId == accountId
        );
        return accountLolInfo;
    }

    public IEnumerable<AccountLolInfo> GetAllAccountLolInfos()
    {
        return _cayThueDbContext.AccountLolInfos;
    }

    public AccountLolInfo Add(AccountLolInfo accountLolInfo)
    {
        _cayThueDbContext.AccountLolInfos.Add(accountLolInfo);
        _cayThueDbContext.SaveChanges();
        return accountLolInfo;
    }
}