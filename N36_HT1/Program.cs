/*
N36 - HT1

- quyidagi modellar va ular o'rtasida inheritance ni recordlar bilan qilib ko'ring

- Person
- Employee
- Manager

bunda modellarda qanday propertylar bo'lishi kerakligini o'ylab ko'ring va izlaning


PS : kecha inheritanceni ko'rsatmagandim, u mana bunday qilinadi


public record Person(string FirstName, string LastName);

public record User(string FirstName, string LastName, string EmailAddress, string Password) : Person(FirstName, LastName)
*/


using N36_HT1;
using System.Globalization;

var person = new Person("Asilbek", "Suyunov", 23);
var employee1 = new Employee("Eshmat", 31,  "Toshmatov", 4);
var employee2 = new Employee("Toshmat", 45, "Toshmatov", 6);

var manager = new Manager("QurbonAli", "Shodiyorov", 34, 542, "AdmeraL007", new List<Employee> { employee1, employee2});






