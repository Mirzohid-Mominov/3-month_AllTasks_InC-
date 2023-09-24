using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Person: A record with properties for a person's name, age, and address.

namespace N36_HT2.Models
{
    public record Person(string Name, int Age, string Address);
}
