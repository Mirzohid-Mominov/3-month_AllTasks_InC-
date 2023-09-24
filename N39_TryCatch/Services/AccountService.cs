using N39_TryCatch.Models;


namespace N39_TryCatch.Services;

public class AccountService
{
    private List<User> _users = new();
    private List<Email> _emails = new();

    public async ValueTask RegisterAsync(string emailAddress, string password)
    {

        if (string.IsNullOrWhiteSpace(emailAddress))
            throw new ArgumentNullException(nameof(emailAddress));

        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentNullException("password");

        var user = new User();
        user.EmailAddress = emailAddress;
        user.Password = password;
        _users.Add(user);

        try
        {
            await SendMessage(emailAddress);
        }
        catch
        {
            throw new InvalidOperationException();
        }

        async ValueTask SendMessage(string emailAddress)
        {
            await Console.Out.WriteLineAsync("Email sent");
        }
        // invalid email address
        // email address already exists
    }
}