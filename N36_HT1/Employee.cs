using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT1
{
    public record Employee(string FirstName, int Age, string LastName, int ExperienceTime) : Person(FirstName, LastName, Age);
}
