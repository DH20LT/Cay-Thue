namespace CayThue.Models.AccountLolInfos;

public interface IAccountLolInfoRep
{
    AccountLolInfo GetAccountLolInfoById(string id);
    
    AccountLolInfo GetAccountLolInfoByAccountId(Guid accountId);
    
    IEnumerable<AccountLolInfo> GetAllAccountLolInfos();
    
    AccountLolInfo Add(AccountLolInfo accountLolInfo);
}