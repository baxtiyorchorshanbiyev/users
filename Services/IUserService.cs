namespace Users.Services;

using Users.Models;
public interface IUserService
{
    void CreateUser(User user);
    User GetUserById(int id);
    void PrintUser(User user);
    User[] GetAllUsers();
    void UpdateUser(User user);
    void DeleteUser(int id);

}
