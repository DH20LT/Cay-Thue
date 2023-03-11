namespace CayThue.Models.AccountLolInfo;

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
        throw new NotImplementedException();
    }

    public IEnumerable<AccountLolInfo> GetAllAccountLolInfos()
    {
        throw new NotImplementedException();
    }
}