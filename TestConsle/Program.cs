using System.Text.RegularExpressions;



public class Program
{
    public bool IsValidEmailAddress(string emailAddress)
    {
        if (string.IsNullOrWhiteSpace(emailAddress) != null)
            return Regex.IsMatch(emailAddress, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        return false;
    }

    public bool IsValidName(string name)
    {

        if (name != null)
            return Regex.IsMatch(name, @"^[A-Za-z]+ [A-Za-z]+$");
        return false;
    }

    public static void Main(string[] args)
    {
        while(true)
        {
            var name = Console.ReadLine();
            var hello = new Program();
            Console.WriteLine(hello.IsValidName(name));
        }

       //while(true)
       // {
       //     var email = Console.ReadLine();

       //     var hello = new Program();

       //     Console.WriteLine(hello.IsValidEmailAddress(email));
       // }
    }
}
