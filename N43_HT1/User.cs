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
        public User( string firstName, string lastName, bool isActive)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            IsActive = isActive;
        }

        public User() { }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
    }
}
