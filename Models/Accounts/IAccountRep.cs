namespace CayThue.Models.Accounts;

public interface IAccountRep
{
    Account GetAccountById(string id);
    IEnumerable<Account> GetAllAccounts();
    IEnumerable<Account> GetAccountByGameId(string gameID);
    IEnumerable<Account> GetAccountByPrice(float startPrice, float endPrice);
    IEnumerable<Account> GetAccountByDescription(string description);
    IEnumerable<Account> GetAccountByIsVerify(bool isVerify);
    IEnumerable<Account> GetAccountByCanChangeInfo(bool canChangeInfo);
    
    void AddAccount(Account account);
}