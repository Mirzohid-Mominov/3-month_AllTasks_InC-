using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Product: A record with properties for a product's ID, name, and price.

namespace N36_HT2.Models
{
    public record Product(Guid Id, string Name, Double Price);
}
