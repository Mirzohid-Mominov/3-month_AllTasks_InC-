using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Models
{
    public record Order(Guid Id, IEnumerable<Customer> Customer, string Items);
}
