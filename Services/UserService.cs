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

    public User GetUserById(int id)
    {
        var user = _users.Find(v => v.Id == id);
        return new User()
        {
            Id = user.Id,
            Name = user.Name,
            LastName = user.LastName,
            Email = user.Email,
            PhoneNumber = user.PhoneNumber
        };

    }

    public void PrintUser(User user)
    {
        Console.WriteLine($"""
        User topildi, Ma'lumotlari => Name:{user.Name}, LastName: {user.LastName}, Email: {user.Email}, PhoneNumber: {user.PhoneNumber}
        """);
    }

    public User[] GetAllUsers()
    {
        return this._users.ToArray();
    }

}