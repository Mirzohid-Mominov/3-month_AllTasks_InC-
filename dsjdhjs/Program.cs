//N36 - HT2

//- quyidagi modellarni berilgan data structure tipida yarating

//Person: A record with properties for a person's name, age, and address.
//Point: A struct with properties for the x and y coordinates of a point in 2D space.
//Book: A tuple with elements for the title, author, and publication year of a book.
//Order: A record with properties for an order's ID, customer, and items.
//Product: A record with properties for a product's ID, name, and price.
//Customer: A record with properties for a customer's name, email, and phone number.
//Address: A record with properties for an address's street, city, state, and zip code.
//Invoice: A record with properties for an invoice's ID, customer, and total amount.
//Transaction: A record with properties for a transaction's ID, date, and amount.
//Employee: A record with properties for an employee's name, department, and salary.
//Company: A record with properties for a company's name, address, and phone number.
//Vehicle: A record with properties for a vehicle's make, model, and year.
//CustomerOrder: A record with properties for a customer's name, email, and a list of orders.
//AddressBookEntry: A record with properties for a contact's name, email, and phone number.
//Rectangle: A struct with properties for the width and height of a rectangle.
//Circle: A struct with properties for the radius and center point of a circle.
//Line: A struct with properties for the start and end points of a line.
//Triangle: A struct with properties for the three vertices of a triangle.
//Color: A struct with properties for the red, green, and blue values of a color.
//WeatherData: A tuple with elements for the temperature, humidity, and wind speed of a weather reading.

//- ExamScore modelidan foydalaning ( id, userId, score )
//-User modelidan foydalaning(id, firstname, lastname )
//-2 alasi uchun o'zining crud entity servisini yarating
//- ExamAnalytics servisidan foydalaning, bu service tepadagi 2 ala service uchun composition service bo'ladi
//- unda GetScores methodi bo'lsin, bu method ( fullName, score ) tipidagi IEnumerable ma'lumot qaytarsin, bunda har bitta user va uning examdagi balli qaytsin




using N36_HT2;
using N36_HT2.Interfaces;
using N36_HT2.Services;

//var user1 = new User()
//{
//    FirstName = "Asilbek",
//    LastName = "Suyunov",
//    Id = new Guid()
//};

//var user2 = new User()
//{
//    FirstName = "Joha",
//    LastName = "Qochqorov",
//    Id = new Guid()
//};

//var user3 = new User()
//{
//    FirstName = "Burxon",
//    LastName = "Qodirov",
//    Id = new Guid()
//};

//var userService = new UserSevice();
//Console.WriteLine(userService.AddAsync(user1));




var user1 = new User("Azizbek", "Abdurahmonov");
var user2 = new User("Abdurahmon", "Satriddinov");
var user3 = new User("Ilxom", "Karimjanov");

var score1 = new ExamScore(user1.Id, 39);
var score2 = new ExamScore(user2.Id, 40);
var score3 = new ExamScore(user3.Id, 48);

var userService = new UserSevice();
var scoreService = new ExamScoreService();
userService.CreateAsync(user1);
userService.CreateAsync(user2);
userService.CreateAsync(user3);

scoreService.CreateAsync(score1);
scoreService.CreateAsync(score2);
scoreService.CreateAsync(score3);


var examAnalytics = new ExamAnalytics(userService, scoreService);
examAnalytics.GetScores().ToList().ForEach(result => Console.WriteLine($"{result.FullName} {result.Score}"));
