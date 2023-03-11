namespace CayThue.Models.AccountLolInfos;

public interface IAccountLolInfoRep
{
    AccountLolInfo GetAccountLolInfoById(string id);
    
    AccountLolInfo GetAccountLolInfoByAccountId(string accountId);
    
    IEnumerable<AccountLolInfo> GetAllAccountLolInfos();
}