using LinqExecutions_N44_HT2;

//LinqExecution.Execute();

//object value = new User
//{
//    FirstName = "Asilbek",
//    LastName = "Hoshimov"
//};


//if(value is User)
//{
//    var user = value as User;
//    Console.WriteLine(user.FirstName);
//}


//object hello = "Hello World";

//if(hello is string greeting)
//{
//    Console.WriteLine(greeting);
//}

//var langLevel = LangLevel.Beginner;

//var result = langLevel switch
//{
//    >= LangLevel.Intermediate => "Your level is good",
//    _ => "Your need to learn more"
//};

// Discard pattern
var result = (FirstName: "John", LastName: "Doe", Age: 20);
var (_, LastName, _) = result;
Console.WriteLine(LastName);

public enum LangLevel
{
    Intermediate,
    Beginner,
    Advanced
}