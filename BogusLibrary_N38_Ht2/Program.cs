using Bogus;
using BogusLibrary_N38_Ht2;


//Bogus library dan foydalaning quyidagi modellarga fake data generate qiling va ekranga chiqaring

//- Employee
//- Order
//- UserAddress
//- BlogPost
//- WeatherReport

var createFaker = new GenerateFakeDates();

var employee = createFaker.GenerateFakeBlogPost(5);
var blogPost = createFaker.GenerateFakeBlogPost(5);
var userAddress = createFaker.GenerateFakeUserAddress(5);
var order = createFaker.GenerateFakeOrders(5);

employee.ForEach(Console.WriteLine);
Console.WriteLine();
blogPost.ForEach(Console.WriteLine);
Console.WriteLine();
userAddress.ForEach(Console.WriteLine);
Console.WriteLine();
order.ForEach(Console.WriteLine);