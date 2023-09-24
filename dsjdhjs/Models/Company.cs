using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Company: A record with properties for a company's name, address, and phone number.

namespace N36_HT2.Models
{
    public record Company(string Name, string Addres, string PhoneNumber);
}
