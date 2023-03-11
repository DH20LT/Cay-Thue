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
        throw new NotImplementedException();
    }

    public AccountLolInfo GetAccountLolInfoByAccountId(string accountId)
    {
        AccountLolInfo accountLolInfo = _cayThueDbContext.AccountLolInfos.FirstOrDefault(
            a => a.AccountId == accountId
            );
        return accountLolInfo;
    }

    public IEnumerable<AccountLolInfo> GetAllAccountLolInfos()
    {
        throw new NotImplementedException();
    }
}