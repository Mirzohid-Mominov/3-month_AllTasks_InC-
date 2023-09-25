using BogusLibrary_N38_Ht2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;


//Bogus library dan foydalaning quyidagi modellarga fake data generate qiling va ekranga chiqaring

//- Employee
//- Order
//- UserAddress
//- BlogPost

namespace BogusLibrary_N38_Ht2
{
    public class GenerateFakeDates
    {
        public List<Employee> GenerateFakeEmployees(int count = 1)
        {
            return new Faker<Employee>()
                .RuleFor(employee => employee.Id, Guid.NewGuid)
                .RuleFor(selector => selector.Name, faker => faker.Name.FullName())
                .RuleFor(selector => selector.Department, faker => faker.Company.CompanyName())
                .RuleFor(selector => selector.Salary, faker => faker.Random.Decimal(1_000, 10_000))
                .Generate(count);
        }

        public List<Order> GenerateFakeOrders(int count = 1)
        {
            var orders =  new Faker<Order>()
                .RuleFor(order => order.Id, Guid.NewGuid())
                .RuleFor(order => order.CustomerId, Guid.NewGuid())
                .RuleFor(order => order.OrderDate, faker => faker.Date.RecentDateOnly())
                .RuleFor(order => order.TotalAmount, faker => faker.Random.Decimal(244_232, 53_543_211))
                .RuleFor(order => order.Status, faker => faker.PickRandom(new string[]
                {
                    "boshlandi", "tugatildi", "davom ettirilmoqda"
                }))
                .Generate(count);
            var random = new Random();
            var id = orders.Select(order => order.Id).ToList();

            foreach (var order in orders)
            {
                order.CustomerId = id[random.Next(0, orders.Count)];
            }

            return orders;
        }

        public List<UserAddress> GenerateFakeUserAddress(int count = 1)
        {
            return new Faker<UserAddress>()
          .RuleFor(selector => selector.Country, faker => faker.Address.Country())
          .RuleFor(selector => selector.State, faker => faker.Address.State())
          .RuleFor(selector => selector.City, faker => faker.Address.City())
          .RuleFor(selector => selector.Street, faker => faker.Address.StreetName())
          .RuleFor(selector => selector.Number, faker => faker.Random.Int(0, 100))
          .Generate(count);
        }

        public List<BlogPost> GenerateFakeBlogPost(int count = 1)
        {
            return new Faker<BlogPost>()
                .RuleFor(post => post.Id, Guid.NewGuid())
                .RuleFor(post => post.Title, faker => faker.Lorem.Paragraph())
                .RuleFor(post => post.Content, faker => faker.Lorem.Text())
                .RuleFor(post => post.ReadTime, faker => faker.Random.Int(2, 332313))
                .RuleFor(post => post.CreatedDate, faker => faker.Date.PastDateOnly())
                .Generate(count);
        }
    }
}
