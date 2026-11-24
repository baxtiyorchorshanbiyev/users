namespace Users.Services;

using Users.Models;

public class UserService : IUserService
{
    public List<User> _users;

    public UserService()
    {
        this._users = new List<User>();
    }
    public void CreateUser(User user)
    {
        _users.Add(user);
        Console.WriteLine($"User {user.Name} qo'shildi");
    }
}