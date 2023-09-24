using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Invoice: A record with properties for an invoice's ID, customer, and total amount.

namespace N36_HT2.Models
{
    public record InVoice(Guid Id, IEnumerable<Customer> Customer, int TotalAmount);
}
