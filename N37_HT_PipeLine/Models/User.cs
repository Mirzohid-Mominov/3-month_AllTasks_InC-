using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//User - FirstName, LastName, Status ( Registered, Active, Deleted ) 

namespace N37_HT_PipeLine.Models
{
    public class User
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Status Status { get; set; }
        public User(string firstName, string lastName, string emailAddress, Status status)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Status = status;
        }

    }
}
