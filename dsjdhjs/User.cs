using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-User modelidan foydalaning(id, firstname, lastname )

namespace N36_HT2
{
    public class User
    {
        public User(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
        }
        public User() { }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"FirstName : {FirstName}\nLastName : {LastName}\n";
        }
    }
}
