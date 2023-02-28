namespace CayThue.Models.Users;

public interface IUserRep
{
    User GetUser(string id);
    IEnumerable<User> GetUserByCurrency(string currency);
}