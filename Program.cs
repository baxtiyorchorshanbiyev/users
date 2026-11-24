using Users.Models;
using Users.Services;
internal class Program
{
    private static void Main()
    {
        IUserService userService = new UserService();

        var newUser = new User()
        {
            Id = 1,
            Name = "Test",
            LastName = "Testovv",
            Email = "Test@gmail.com",
            PhoneNumber = "998991234451"
        };

        userService.CreateUser(newUser);
        var userExisting = userService.GetUserById(1);

        if (userExisting != null)
        {
            userService.PrintUser(userExisting);
        }
        else
        {
            Console.WriteLine("User Topilmadi");
        }

    }

}