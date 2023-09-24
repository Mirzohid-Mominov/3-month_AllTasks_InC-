namespace N39_TryCatch.Models;

public class User
{
    public User(string password, string emailAddress)
    {
        Password = password;
        EmailAddress = emailAddress;
    }
    public User() { }
    public string Password { get; set; }
    public string EmailAddress { get; set; }
}