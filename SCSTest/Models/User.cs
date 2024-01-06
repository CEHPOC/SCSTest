namespace SCSTest.Models;

public class User
{
    public int UserId { get; set; }
    
    public string Login { get; set; }
    
    public string Password { get; set; }

    public User(string login, string password)
    {
        Login = login;
        Password = password;
    }
}