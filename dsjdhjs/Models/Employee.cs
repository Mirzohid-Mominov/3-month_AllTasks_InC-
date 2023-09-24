using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Employee: A record with properties for an employee's name, department, and salary.

namespace N36_HT2.Models
{
    public record Employee(string Name, string Department, double Salary);
}
