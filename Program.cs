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
        var secondUser = new User()
        {
            Id = 2,
            Name = "Ali",
            LastName = "Aliyev",
            Email = "ali@gmail.com",
            PhoneNumber = "998901234567"
        };

        userService.CreateUser(secondUser);

        var userExisting = userService.GetUserById(1);

        if (userExisting != null)
        {
            userService.PrintUser(userExisting);
        }
        else
        {
            Console.WriteLine("User Topilmadi");
        }

        var updatedUser = new User()
        {
            Id = 1,
            Name = "Vali",
            LastName = "Valiyev",
            Email = "vali@gmail.com",
            PhoneNumber = "998901112233"
        };

        userService.UpdateUser(updatedUser);
        userService.DeleteUser(1);

        foreach (var user in userService.GetAllUsers())
        {
            userService.PrintUser(user);
        }
    }

}
