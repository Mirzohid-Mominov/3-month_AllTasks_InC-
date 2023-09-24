using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Customer: A record with properties for a customer's name, email, and phone number.

namespace N36_HT2.Models
{
    public record Customer(string Name, string Email, string PhoneNumber);
}
