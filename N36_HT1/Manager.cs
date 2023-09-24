using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT1
{
    public record Manager(string FirstName, string LastName, int Age, int UsersNumber, string Password, IEnumerable<Employee> Employees) : Person(FirstName, LastName, Age);
}
