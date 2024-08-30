namespace service;

public interface IUserService
{
    List<User> GetUsers();
}

public class UserService : IUserService
{
    public UserService()
    {
        Console.WriteLine("service instantiated");
    }
    
    public List<User> GetUsers()
    {
        return new List<User>() { new User { Name = "User1" }, new User { Name = "User2" } };
    }
}

public class User
{
    public string Name { get; set; }
}