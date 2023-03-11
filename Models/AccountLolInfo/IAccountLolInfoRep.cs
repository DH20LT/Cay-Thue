namespace CayThue.Models.AccountLolInfo;

public interface IAccountLolInfoRep
{
    AccountLolInfo GetAccountLolInfoById(string id);
    
    IEnumerable<AccountLolInfo> GetAllAccountLolInfos();
}