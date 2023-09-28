using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//User model(id, firstName, lastName, isActive )

namespace N43_HT1
{
    public class User
    {
        public User() { }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
