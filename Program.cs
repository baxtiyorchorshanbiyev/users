using Users.Models;
using Users.Services;
internal class Program
{
    private static void Main()
    {
        IUserService userService = new UserService();

        var user = new User()
        {
            Name = "Test",
            LastName = "Testovv",
            Email = "Test@gmail.com",
            PhoneNumber = "998991234451"
        };

        userService.CreateUser(user);
    }

}