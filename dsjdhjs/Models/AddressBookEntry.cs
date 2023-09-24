using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//AddressBookEntry: A record with properties for a contact's name, email, and phone number.

namespace N36_HT2.Models
{
   public record AddressBookEntry(String ContactsName, string Email, string PhoneNumber);
}
