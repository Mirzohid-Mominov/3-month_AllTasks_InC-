//N39 - HT1

//Modellar
//- WeatherReport(State, Degree)
//- User(FirstName, LastName)

//- ushbu modellardan bir nechta instance ochib object tipidagi List da saqlang

//ulardan
//- declaration type pattern va property pattern orqali quyidagilarni topib, ekranga chiqaring
//- 30 *C dan baland bo'lgan weather reportlarni
//- FirstName "John" ga match bo'lgan userlarni 


using WeatherReport_N39_HT1;

var userAndWeatherReports = new List<object>();
{
    new User("MuhammadRizo", "Rashidov");
    new User("Qulpiddin", "Salimov");
    new User("Azizbek", "Abdurahmonov");
    new User("Shoyad", "Sadriddinov");
    new User("Halima", "Salimova");
    new WeatherReport("New York", 72.5f);
    new WeatherReport("California", 80.0f);
    new WeatherReport("Texas", 85.3f);
    new WeatherReport("Florida", 30.5f);
    new WeatherReport("Arizona", 33.8f);
};

foreach (var users in userAndWeatherReports)
{
    if (users is User user && user is { FirstName: "Halima" })
    {
        Console.WriteLine(user);
    }

    else if (users is WeatherReport weatherReport && weatherReport is { Degree: >= 33.8f })
    {
        Console.WriteLine(weatherReport);
    }
}
