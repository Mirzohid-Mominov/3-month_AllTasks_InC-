using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogusLibrary_N38_Ht2.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Department : {Department}, Salary: {Salary.ToString()}";
        }
    }
}
