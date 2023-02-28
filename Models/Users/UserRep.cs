namespace CayThue.Models.Users;

public class UserRep : IUserRep
{
    private readonly CayThueDbContext _cayThueDbContext;

    public UserRep(CayThueDbContext cayThueDbContext)
    {
        _cayThueDbContext = cayThueDbContext;
    }

    public User GetUser(string id)
    {
        User user = _cayThueDbContext.Users.Find(id) ?? throw new InvalidOperationException
        {
            HelpLink = null,
            HResult = 0,
            Source = null
        };
        return user;
    }

    public IEnumerable<User> GetUserByCurrency(string currency)
    {
        return _cayThueDbContext.Users;
    }
}