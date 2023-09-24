using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//User modeli(id - guid, firstname, lastname, email address)

namespace N38_HT1
{
    public class User
    {
        public User(string firstName, string lastName, string emailAddress)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set;}

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName : {LastName}, Email : {EmailAddress}";
        }
    }
}
