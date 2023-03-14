using CayThue.Models.Users;

namespace CayThue.Models.Accounts;

public interface IAccountRep
{
    Account GetAccountById(Guid id);
    IEnumerable<Account> GetAllAccounts();
    IEnumerable<Account> GetAccountsByUserId(string userId);
    IEnumerable<Account> GetAccountsByGameId(string gameID);
    IEnumerable<Account> GetAccountsByPrice(float startPrice, float endPrice);
    IEnumerable<Account> GetAccountsByDescription(string description);
    IEnumerable<Account> GetAccountsByIsVerify(bool isVerify);
    IEnumerable<Account> GetAccountsByCanChangeInfo(bool canChangeInfo);
    
    /// <summary>
    /// Get user id by account id
    /// </summary>
    /// <param name="id"> Account id
    /// </param>
    /// <returns>
    /// User
    /// </returns>
    User GetUserByAccountId(Guid id);

    void AddAccount(Account account);
    
    void IncreaseViews(Guid id);
}